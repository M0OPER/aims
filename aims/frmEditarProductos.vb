Imports System.Data.Odbc
Public Class frmEditarProductos
    Dim todos, activos, inactivos, state, id As Integer
    Dim antes, ahora, ruta, nombre As String

    Private Sub cbListar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbListar.SelectedIndexChanged
        If cbListar.Text = "Todos" Then
            listarEliminar("Todos")
        ElseIf cbListar.Text = "Activos"
            listarEliminar("Activos")
        ElseIf cbListar.Text = "Inactivos"
            listarEliminar("Inactivos")
        End If
    End Sub

    Private Sub frmNieto3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs)
        frmHome.Enabled = False
        frmVer.pbImagen.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\" + ruta)
        frmVer.Show()
    End Sub

    Private Sub dgvListadoEditar_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoEditar.RowEnter
        Try
            If dgvListadoEditar.Rows(e.RowIndex).Cells(5).Value.ToString() <> "" Then
                nombre = dgvListadoEditar.Rows(e.RowIndex).Cells(1).Value.ToString()
                ruta = dgvListadoEditar.Rows(e.RowIndex).Cells(2).Value.ToString()
                antes = dgvListadoEditar.Rows(e.RowIndex).Cells(3).Value.ToString()
                ahora = dgvListadoEditar.Rows(e.RowIndex).Cells(4).Value.ToString()
                id = dgvListadoEditar.Rows(e.RowIndex).Cells(5).Value
                frmEditar.pbImagen.Image = System.Drawing.Image.FromFile(Me.dgvListadoEditar.CurrentRow.Cells.Item(2).Value.ToString())
            End If
        Catch ex As Exception
            lblError.Text = "Seleccione una fila"
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        frmEditar.txtNombre.Text = nombre
        frmEditar.txtRuta.Text = ("E:\buzzers\godred\aims\aims\media\" + ruta)
        frmEditar.pbImagen.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\" + ruta)
        frmEditar.txtAntes.Text = antes
        frmEditar.txtAhora.Text = ahora
        frmEditar.lblId.Text = id
        frmEditar.Show()
        frmEditar.temp1 = nombre
        frmEditar.temp2 = ("E:\buzzers\godred\aims\aims\media\" + ruta)
        frmEditar.temp3 = antes
        frmEditar.temp4 = ahora
        frmHome.Enabled = False
    End Sub


    Dim i As Integer = 0
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query As New OdbcCommand("select * from productos where nombre Like '%" & txtNombre.Text & "%'", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            dgvListadoEditar.Rows.Clear()
            dgvListadoEditar.Columns.Clear()
            dgvListadoEditar.DataSource = Nothing
            dgvListadoEditar.Columns.Add("txtNumeroList", "#")
            dgvListadoEditar.Columns.Add("txtNombreList", "Nombre")
            dgvListadoEditar.Columns.Add("btnImagenList", "Imagen")
            dgvListadoEditar.Columns.Add("txtAntesList", "Antes")
            dgvListadoEditar.Columns.Add("txtAhoraList", "Ahora")
            dgvListadoEditar.Columns.Add("txtIdList", "ID")
            dgvListadoEditar.Columns.Add("txtEstadoList", "Estado")
            dgvListadoEditar.Columns("txtIdList").Visible = False
            dgvListadoEditar.Columns(1).Width = 250
            dgvListadoEditar.Columns(2).Width = 147
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    If rs.Item("estado").ToString() = "1" Then
                        activos = activos + 1
                    ElseIf rs.Item("estado").ToString() = "2"
                        inactivos = inactivos + 1
                    End If
                    dgvListadoEditar.Rows.Add()
                    dgvListadoEditar.Item(0, i).Value = i + 1
                    dgvListadoEditar.Item(1, i).Value = rs.Item("nombre").ToString()
                    dgvListadoEditar.Item(2, i).Value = rs.Item("foto").ToString()
                    dgvListadoEditar.Item(3, i).Value = rs.Item("antes").ToString()
                    dgvListadoEditar.Item(4, i).Value = rs.Item("ahora").ToString()
                    dgvListadoEditar.Item(5, i).Value = rs.Item("id").ToString()
                    i = i + 1
                End While
                todos = i
                lblTodos.Text = todos
                lblActivos.Text = activos
                lblInactivos.Text = inactivos
                lblError.Text = "Productos cargados"
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = "No hay productos para mostrar"
            End If
            i = 0 : activos = 0 : inactivos = 0 : todos = 0
        Catch exx As Exception
            lblError.Text = exx.Message : lblError.ForeColor = Color.Red
        End Try
    End Sub


    Public Sub listarEliminar(ByVal listar As String)
        Try
            Dim query As New OdbcCommand("SELECT * FROM productos", conexion)
            Dim rs As OdbcDataReader
            If conexion.State = 0 Then
                conexion.Open()
            End If
            If listar = "Todos" Then
                Try
                    dgvListadoEditar.Rows.Clear()
                    dgvListadoEditar.Columns.Clear()
                    dgvListadoEditar.DataSource = Nothing
                    dgvListadoEditar.Columns.Add("txtNumeroList", "#")
                    dgvListadoEditar.Columns.Add("txtNombreList", "Nombre")
                    dgvListadoEditar.Columns.Add("btnImagenList", "Imagen")
                    dgvListadoEditar.Columns.Add("txtAntesList", "Antes")
                    dgvListadoEditar.Columns.Add("txtAhoraList", "Ahora")
                    dgvListadoEditar.Columns.Add("txtIdList", "ID")
                    dgvListadoEditar.Columns.Add("txtEstadoList", "Estado")
                    dgvListadoEditar.Columns("txtIdList").Visible = False
                    dgvListadoEditar.Columns(1).Width = 250
                    dgvListadoEditar.Columns(2).Width = 147
                    rs = query.ExecuteReader()
                    If rs.HasRows Then
                        While (rs.Read)
                            If rs.Item("estado").ToString() = "1" Then
                                activos = activos + 1
                            ElseIf rs.Item("estado").ToString() = "2"
                                inactivos = inactivos + 1
                            End If
                            dgvListadoEditar.Rows.Add()
                            dgvListadoEditar.Item(0, i).Value = i + 1
                            dgvListadoEditar.Item(1, i).Value = rs.Item("nombre").ToString()
                            dgvListadoEditar.Item(2, i).Value = rs.Item("foto").ToString()
                            dgvListadoEditar.Item(3, i).Value = rs.Item("antes").ToString()
                            dgvListadoEditar.Item(4, i).Value = rs.Item("ahora").ToString()
                            dgvListadoEditar.Item(5, i).Value = rs.Item("id").ToString()
                            If rs.Item("estado").ToString() = "1" Then
                                dgvListadoEditar.Item(6, i).Value = "Activo"
                            ElseIf rs.Item("estado").ToString() = "2"
                                dgvListadoEditar.Item(6, i).Value = "Inactivo"
                            End If
                            i = i + 1
                        End While
                        todos = i
                        lblTodos.Text = todos
                        lblActivos.Text = activos
                        lblInactivos.Text = inactivos
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
                dgvListadoEditar.Rows.Clear()
                dgvListadoEditar.Columns.Clear()
                dgvListadoEditar.DataSource = Nothing
                dgvListadoEditar.Columns.Add("txtNumeroList", "#")
                dgvListadoEditar.Columns.Add("txtNombreList", "Nombre")
                dgvListadoEditar.Columns.Add("btnImagenList", "Imagen")
                dgvListadoEditar.Columns.Add("txtAntesList", "Antes")
                dgvListadoEditar.Columns.Add("txtAhoraList", "Ahora")
                dgvListadoEditar.Columns.Add("txtIdList", "ID")
                dgvListadoEditar.Columns.Add("txtEstadoList", "Estado")
                dgvListadoEditar.Columns("txtIdList").Visible = False
                dgvListadoEditar.Columns("txtEstadoList").Visible = False
                dgvListadoEditar.Columns(1).Width = 300
                dgvListadoEditar.Columns(2).Width = 200
                Try
                    rs = query.ExecuteReader()
                    If rs.HasRows Then
                        While (rs.Read)
                            If rs.Item("estado").ToString() = "1" Then
                                If rs.Item("estado").ToString() = "1" Then
                                    activos = activos + 1
                                ElseIf rs.Item("estado").ToString() = "2"
                                    inactivos = inactivos + 1
                                End If
                                dgvListadoEditar.Rows.Add()
                                dgvListadoEditar.Item(0, i).Value = i + 1
                                dgvListadoEditar.Item(1, i).Value = rs.Item("nombre").ToString()
                                dgvListadoEditar.Item(2, i).Value = rs.Item("foto").ToString()
                                dgvListadoEditar.Item(3, i).Value = rs.Item("antes").ToString()
                                dgvListadoEditar.Item(4, i).Value = rs.Item("ahora").ToString()
                                dgvListadoEditar.Item(5, i).Value = rs.Item("id").ToString()
                                dgvListadoEditar.Item(6, i).Value = "Activo"
                                i = i + 1
                            End If
                        End While
                        todos = i
                        lblTodos.Text = todos
                        lblActivos.Text = activos
                        lblInactivos.Text = inactivos
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
                dgvListadoEditar.Rows.Clear()
                dgvListadoEditar.Columns.Clear()
                dgvListadoEditar.DataSource = Nothing
                dgvListadoEditar.Columns.Add("txtNumeroList", "#")
                dgvListadoEditar.Columns.Add("txtNombreList", "Nombre")
                dgvListadoEditar.Columns.Add("btnImagenList", "Imagen")
                dgvListadoEditar.Columns.Add("txtAntesList", "Antes")
                dgvListadoEditar.Columns.Add("txtAhoraList", "Ahora")
                dgvListadoEditar.Columns.Add("txtIdList", "ID")
                dgvListadoEditar.Columns.Add("txtEstadoList", "Estado")
                dgvListadoEditar.Columns("txtIdList").Visible = False
                dgvListadoEditar.Columns("txtEstadoList").Visible = False
                dgvListadoEditar.Columns(1).Width = 300
                dgvListadoEditar.Columns(2).Width = 200
                Try
                    rs = query.ExecuteReader()
                    If rs.HasRows Then
                        While (rs.Read)
                            If rs.Item("estado").ToString() = "2" Then
                                If rs.Item("estado").ToString() = "1" Then
                                    activos = activos + 1
                                ElseIf rs.Item("estado").ToString() = "2"
                                    inactivos = inactivos + 1
                                End If
                                dgvListadoEditar.Rows.Add()
                                dgvListadoEditar.Item(0, i).Value = i + 1
                                dgvListadoEditar.Item(1, i).Value = rs.Item("nombre").ToString()
                                dgvListadoEditar.Item(2, i).Value = rs.Item("foto").ToString()
                                dgvListadoEditar.Item(3, i).Value = rs.Item("antes").ToString()
                                dgvListadoEditar.Item(4, i).Value = rs.Item("ahora").ToString()
                                dgvListadoEditar.Item(5, i).Value = rs.Item("id").ToString()
                                dgvListadoEditar.Item(6, i).Value = "Inactivo"
                                i = i + 1
                            End If
                        End While
                        todos = i
                        lblTodos.Text = todos
                        lblActivos.Text = activos
                        lblInactivos.Text = inactivos
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
            ElseIf listar = "LIMPIAR" Then
                dgvListadoEditar.Rows.Clear()
                dgvListadoEditar.Columns.Clear()
                dgvListadoEditar.DataSource = Nothing
            End If
        Catch ex As Exception
            Msg_exe()
        End Try
    End Sub
    Sub Msg_exe()
        MsgBox("Error con el servidor", vbExclamation, "ERROR ::: N003")
    End Sub
    'Texto de cada imput
    Private Sub txtNombre_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        lblNombre.Visible = True
        If txtNombre.Text = "Nombre" Then
            txtNombre.Text = ""
        End If
    End Sub
    Private Sub txtNombre_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        lblNombre.Visible = False
        If txtNombre.Text = "" Then
            txtNombre.Text = "Nombre"
        End If
    End Sub
End Class