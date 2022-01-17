Imports System.Data.Odbc
Public Class frmEliminarOnOffProductos
    Dim todos, activos, inactivos, state, id As Integer
    Dim ruta As String
    Dim i As Integer = 0

    Private Sub cbListar_TextChanged(sender As Object, e As EventArgs) Handles cbListar.TextChanged
        If cbListar.Text = "Todos" Then
            listarEliminar("Todos")
        ElseIf cbListar.Text = "Activos"
            listarEliminar("Activos")
        ElseIf cbListar.Text = "Inactivos"
            listarEliminar("Inactivos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As New OdbcCommand("select * from productos where nombre Like '%" & txtNombre.Text & "%'", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            dgvListadoEliminar.Rows.Clear()
            dgvListadoEliminar.Columns.Clear()
            dgvListadoEliminar.DataSource = Nothing
            dgvListadoEliminar.Columns.Add("txtNumeroList", "#")
            dgvListadoEliminar.Columns.Add("txtNombreList", "Nombre")
            dgvListadoEliminar.Columns.Add("btnImagenList", "Imagen")
            dgvListadoEliminar.Columns.Add("txtAntesList", "Antes")
            dgvListadoEliminar.Columns.Add("txtAhoraList", "Ahora")
            dgvListadoEliminar.Columns.Add("txtIdList", "ID")
            dgvListadoEliminar.Columns.Add("txtEstadoList", "Estado")
            dgvListadoEliminar.Columns("txtIdList").Visible = False
            dgvListadoEliminar.Columns(1).Width = 250
            dgvListadoEliminar.Columns(2).Width = 147
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    If rs.Item("estado").ToString() = "1" Then
                        activos = activos + 1
                    ElseIf rs.Item("estado").ToString() = "2" Then
                        inactivos = inactivos + 1
                    End If
                    dgvListadoEliminar.Rows.Add()
                    dgvListadoEliminar.Item(0, i).Value = i + 1
                    dgvListadoEliminar.Item(1, i).Value = rs.Item("nombre").ToString()
                    dgvListadoEliminar.Item(2, i).Value = rs.Item("foto").ToString()
                    dgvListadoEliminar.Item(3, i).Value = rs.Item("antes").ToString()
                    dgvListadoEliminar.Item(4, i).Value = rs.Item("ahora").ToString()
                    dgvListadoEliminar.Item(5, i).Value = rs.Item("id").ToString()
                    If rs.Item("estado").ToString() = "1" Then
                        dgvListadoEliminar.Item(6, i).Value = "Activo"
                    ElseIf rs.Item("estado").ToString() = "2"
                        dgvListadoEliminar.Item(6, i).Value = "Inactivo"
                    End If
                    i = i + 1
                End While
                todos = i
                lblActivos.Text = activos
                lblInactivos.Text = inactivos
                lblTodos.Text = todos
                lblError.Text = "Productos cargados"
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = "No hay productos para mostrar"
            End If
            i = 0 : activos = 0 : inactivos = 0 : todos = 0
        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub
    Private Sub dgvListadoEliminar_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoEliminar.RowEnter
        Try
            If dgvListadoEliminar.Rows(e.RowIndex).Cells(5).Value.ToString() <> "" Then
                id = dgvListadoEliminar.Rows(e.RowIndex).Cells(5).Value
                ruta = dgvListadoEliminar.Rows(e.RowIndex).Cells(2).Value.ToString()
                If dgvListadoEliminar.Rows(e.RowIndex).Cells(6).Value.ToString() = "Activo" Then
                    btnEstado.Text = "Desactivar"
                ElseIf dgvListadoEliminar.Rows(e.RowIndex).Cells(6).Value.ToString() = "Inactivo" Then
                    btnEstado.Text = "Activar"
                End If
            End If
        Catch ex As Exception
            lblError.Text = "Seleccione una fila"
        End Try
    End Sub

    Private Sub btnEstado_Click(sender As Object, e As EventArgs) Handles btnEstado.Click
        frmHome.Enabled = False
        If btnEstado.Text = "Activar" Then
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Try
                Dim query As New OdbcCommand("UPDATE productos SET estado = 1 WHERE id = " & id, conexion)
                query.ExecuteNonQuery()
                cbListar.Text = "Todos"
                listarEliminar(cbListar.Text)
                lblError.Text = "Producto activado"
                lblError.ForeColor = Color.MediumSeaGreen
            Catch ex As Exception
                lblError.ForeColor = Color.Red
                lblError.Text = ex.Message
            End Try
        ElseIf btnEstado.Text = "Desactivar" Then
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Try
                Dim query As New OdbcCommand("UPDATE productos SET estado = 2 WHERE id = " & id, conexion)
                query.ExecuteNonQuery()
                cbListar.Text = "Todos"
                listarEliminar(cbListar.Text)
                lblError.ForeColor = Color.MediumSeaGreen
            Catch ex As Exception
                lblError.ForeColor = Color.Red
                lblError.Text = ex.Message
            End Try
        End If
        frmHome.Enabled = True
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        frmHome.Enabled = False
        frmVer.pbImagen.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\" + ruta)
        frmVer.Show()
    End Sub


    Private Sub dgvListadoEliminar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoEliminar.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            Dim query As New OdbcCommand("DELETE FROM productos WHERE id = " & id, conexion)
            query.ExecuteNonQuery()
            lblError.Text = "Registro eliminado"
            lblError.ForeColor = Color.Aquamarine
            cbListar.Text = ("Todos")
            listarEliminar(cbListar.Text)
        Catch ex As Exception
            lblError.Text = "Error del servidor" + ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub t001_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        lblNombre.Visible = True
        If txtNombre.Text = "Nombre" Then
            txtNombre.Text = ""
        End If
    End Sub
    Private Sub t001_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        lblNombre.Visible = False
        If txtNombre.Text = "" Then
            txtNombre.Text = "Nombre"
        End If
    End Sub
    Public Sub listarEliminar(ByVal listar As String)
        Dim query As New OdbcCommand("SELECT * FROM productos", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        If listar = "Todos" Then
            Try
                dgvListadoEliminar.Rows.Clear()
                dgvListadoEliminar.Columns.Clear()
                dgvListadoEliminar.DataSource = Nothing
                dgvListadoEliminar.Columns.Add("txtNumeroList", "#")
                dgvListadoEliminar.Columns.Add("txtNombreList", "Nombre")
                dgvListadoEliminar.Columns.Add("btnImagenList", "Imagen")
                dgvListadoEliminar.Columns.Add("txtAntesList", "Antes")
                dgvListadoEliminar.Columns.Add("txtAhoraList", "Ahora")
                dgvListadoEliminar.Columns.Add("txtIdList", "ID")
                dgvListadoEliminar.Columns.Add("txtEstadoList", "Estado")
                dgvListadoEliminar.Columns("txtIdList").Visible = False
                dgvListadoEliminar.Columns(1).Width = 250
                dgvListadoEliminar.Columns(2).Width = 147
                rs = query.ExecuteReader()
                If rs.HasRows Then
                    While (rs.Read)
                        If rs.Item("estado").ToString() = "1" Then
                            activos = activos + 1
                        ElseIf rs.Item("estado").ToString() = "2" Then
                            inactivos = inactivos + 1
                        End If
                        dgvListadoEliminar.Rows.Add()
                        dgvListadoEliminar.Item(0, i).Value = i + 1
                        dgvListadoEliminar.Item(1, i).Value = rs.Item("nombre").ToString()
                        dgvListadoEliminar.Item(2, i).Value = rs.Item("foto").ToString()
                        dgvListadoEliminar.Item(3, i).Value = rs.Item("antes").ToString()
                        dgvListadoEliminar.Item(4, i).Value = rs.Item("ahora").ToString()
                        dgvListadoEliminar.Item(5, i).Value = rs.Item("id").ToString()
                        If rs.Item("estado").ToString() = "1" Then
                            dgvListadoEliminar.Item(6, i).Value = "Activo"
                        ElseIf rs.Item("estado").ToString() = "2"
                            dgvListadoEliminar.Item(6, i).Value = "Inactivo"
                        End If
                        i = i + 1
                    End While
                    todos = i
                    lblActivos.Text = activos
                    lblInactivos.Text = inactivos
                    lblTodos.Text = todos
                    lblError.Text = "Productos cargados"
                    lblError.ForeColor = Color.MediumSeaGreen
                Else
                    lblError.ForeColor = Color.Green
                    lblError.Text = "No hay productos para mostrar"
                End If
                i = 0 : activos = 0 : inactivos = 0 : todos = 0
                rs.Close()
            Catch ex As Exception
                lblError.Text = ex.Message
                lblError.ForeColor = Color.Red
            End Try
        ElseIf listar = "Activos" Then
            dgvListadoEliminar.Rows.Clear()
            dgvListadoEliminar.Columns.Clear()
            dgvListadoEliminar.DataSource = Nothing
            dgvListadoEliminar.Columns.Add("txtNumeroList", "#")
            dgvListadoEliminar.Columns.Add("txtNombreList", "Nombre")
            dgvListadoEliminar.Columns.Add("btnImagenList", "Imagen")
            dgvListadoEliminar.Columns.Add("txtAntesList", "Antes")
            dgvListadoEliminar.Columns.Add("txtAhoraList", "Ahora")
            dgvListadoEliminar.Columns.Add("txtIdList", "ID")
            dgvListadoEliminar.Columns.Add("txtEstadoList", "Estado")
            dgvListadoEliminar.Columns("txtIdList").Visible = False
            dgvListadoEliminar.Columns("txtEstadoList").Visible = False
            dgvListadoEliminar.Columns(1).Width = 300
            dgvListadoEliminar.Columns(2).Width = 200
            Try
                rs = query.ExecuteReader()
                If rs.HasRows Then
                    While (rs.Read)
                        If rs.Item("estado").ToString() = "1" Then
                            activos = activos + 1
                        ElseIf rs.Item("estado").ToString() = "2" Then
                            inactivos = inactivos + 1
                        End If
                        If rs.Item("estado").ToString() = "1" Then
                            dgvListadoEliminar.Rows.Add()
                            dgvListadoEliminar.Item(0, i).Value = i + 1
                            dgvListadoEliminar.Item(1, i).Value = rs.Item("nombre").ToString()
                            dgvListadoEliminar.Item(2, i).Value = rs.Item("foto").ToString()
                            dgvListadoEliminar.Item(3, i).Value = rs.Item("antes").ToString()
                            dgvListadoEliminar.Item(4, i).Value = rs.Item("ahora").ToString()
                            dgvListadoEliminar.Item(5, i).Value = rs.Item("id").ToString()
                            dgvListadoEliminar.Item(6, i).Value = "Activo"
                            i = i + 1
                        End If
                    End While
                    todos = i
                    lblActivos.Text = activos
                    lblInactivos.Text = inactivos
                    lblTodos.Text = todos
                    lblError.Text = "Productos cargados"
                    lblError.ForeColor = Color.MediumSeaGreen
                Else
                    lblError.ForeColor = Color.Green
                    lblError.Text = "No hay productos para mostrar"
                End If
                i = 0 : activos = 0 : inactivos = 0 : todos = 0
                rs.Close()
            Catch ex As Exception
                lblError.Text = ex.Message
                lblError.ForeColor = Color.Red
            End Try
        ElseIf listar = "Inactivos" Then
            dgvListadoEliminar.Rows.Clear()
            dgvListadoEliminar.Columns.Clear()
            dgvListadoEliminar.DataSource = Nothing
            dgvListadoEliminar.Columns.Add("txtNumeroList", "#")
            dgvListadoEliminar.Columns.Add("txtNombreList", "Nombre")
            dgvListadoEliminar.Columns.Add("btnImagenList", "Imagen")
            dgvListadoEliminar.Columns.Add("txtAntesList", "Antes")
            dgvListadoEliminar.Columns.Add("txtAhoraList", "Ahora")
            dgvListadoEliminar.Columns.Add("txtIdList", "ID")
            dgvListadoEliminar.Columns.Add("txtEstadoList", "Estado")
            dgvListadoEliminar.Columns("txtIdList").Visible = False
            dgvListadoEliminar.Columns("txtEstadoList").Visible = False
            dgvListadoEliminar.Columns(1).Width = 250
            dgvListadoEliminar.Columns(2).Width = 147
            Try
                rs = query.ExecuteReader()
                If rs.HasRows Then
                    While (rs.Read)
                        If rs.Item("estado").ToString() = "1" Then
                            activos = activos + 1
                        ElseIf rs.Item("estado").ToString() = "2" Then
                            inactivos = inactivos + 1
                        End If
                        If rs.Item("estado").ToString() = "2" Then
                            dgvListadoEliminar.Rows.Add()
                            dgvListadoEliminar.Item(0, i).Value = i + 1
                            dgvListadoEliminar.Item(1, i).Value = rs.Item("nombre").ToString()
                            dgvListadoEliminar.Item(2, i).Value = rs.Item("foto").ToString()
                            dgvListadoEliminar.Item(3, i).Value = rs.Item("antes").ToString()
                            dgvListadoEliminar.Item(4, i).Value = rs.Item("ahora").ToString()
                            dgvListadoEliminar.Item(5, i).Value = rs.Item("id").ToString()
                            dgvListadoEliminar.Item(6, i).Value = "Inactivo"
                            i = i + 1
                        End If
                    End While
                    todos = i
                    lblActivos.Text = activos
                    lblInactivos.Text = inactivos
                    lblTodos.Text = todos
                    lblError.Text = "Productos cargados"
                    lblError.ForeColor = Color.MediumSeaGreen
                Else
                    lblError.ForeColor = Color.Green
                    lblError.Text = "No hay productos para mostrar"
                End If
                i = 0 : activos = 0 : inactivos = 0 : todos = 0
                rs.Close()
            Catch ex As Exception
                lblError.Text = ex.Message
                lblError.ForeColor = Color.Red
            End Try
        End If
    End Sub
End Class