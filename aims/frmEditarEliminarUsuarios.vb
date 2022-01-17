Imports System.Data.Odbc
Public Class frmEditarEliminarUsuarios
    Dim i, id, sexoBD, tipoBD, numero As Integer
    Dim sexo, tipo, temp1, temp2, temp3, temp4, temp5, temp6, temp7, exist As String

    Private Sub dgvListadoUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoUsuarios.CellContentClick

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        frmHome.Enabled = False
        If txtNombres.Text = temp1 And txtUsuario.Text = temp2 And txtContrasena.Text = temp3 And txtTelefono.Text = temp4 And txtEmail.Text = temp5 And cbSexo.Text = temp6 And cbTipo.Text = temp7 Then
            lblError.Text = "Debe hacer algún cambio para hacer la actualizacion"
        Else
            If conexion.State = 0 Then
                conexion.Open()
            End If
            If cbSexo.Text = "Masculino" Then
                sexoBD = 1
            ElseIf cbSexo.Text = "Femenino" Then
                sexoBD = 2
            End If
            If cbTipo.Text = "Engine" Then
                tipoBD = 5
            ElseIf cbTipo.Text = "Administrador"
                tipoBD = 6
            ElseIf cbTipo.Text = "Employer"
                tipoBD = 9
            ElseIf cbTipo.Text = "Ventas"
                tipoBD = 4
            ElseIf cbTipo.Text = "Cliente"
                tipoBD = 3
            End If
            Try
                Dim query As New OdbcCommand("UPDATE usuarios SET nombres = '" & txtNombres.Text & "', usuario = '" & txtUsuario.Text & "', contrasena = '" & txtContrasena.Text & "', telefono = " & CInt(txtTelefono.Text) & ", email = '" & txtEmail.Text & "', sexo = " & sexoBD & ", tipo_use = " & tipoBD & " WHERE id = " & id, conexion)
                query.ExecuteNonQuery()
                listarUsuarios()
                dgvListadoUsuarios.CurrentCell.Selected = False
                txtNombres.Text = "Nombres"
                txtUsuario.Text = "Usuario"
                txtContrasena.Text = "Contraseña"
                txtTelefono.Text = "0"
                txtEmail.Text = "Email"
                cbSexo.Text = "--Seleccionar--"
                cbTipo.Text = "--Seleccionar--"
                lblError.Text = "Usuario actualizado"
                btnEditar.Enabled = False
                lblError.ForeColor = Color.MediumSeaGreen
            Catch ex As Exception
                lblError.ForeColor = Color.Red
                lblError.Text = "ERROR CON EL SERVIDOR, " + ex.Message
            End Try
        End If
        frmHome.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Dim query1 As New OdbcCommand("SELECT * FROM testimonios, usuarios u WHERE u.id = id_cod_usuario AND id_cod_usuario = " & id, conexion)
            Dim rs1 As OdbcDataReader
            rs1 = query1.ExecuteReader()
            If rs1.Read Then
                exist = "OK"
            End If
            rs1.Close()
            If exist = "OK" Then
                Try
                    If conexion.State = 0 Then
                        conexion.Open()
                    End If
                    Dim query2 As New OdbcCommand("DELETE FROM testimonios WHERE id_cod_usuario = " & id, conexion)
                    query2.ExecuteNonQuery()
                Catch ex As Exception
                    lblError.Text = "Error del servidor" + ex.Message
                    lblError.ForeColor = Color.Red
                End Try
            End If
        Catch ex As Exception
            If ex.Message = "ERROR [HY000] [MySQL][ODBC 5.1 Driver]Can't connect to MySQL server on 'localhost' (10061)" Then
                frmHome.btnReconectar.Visible = True
            End If
            lblError.Text = ex.Message
        End Try
        Try
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Dim query3 As New OdbcCommand("DELETE FROM usuarios WHERE id = " & id, conexion)
            query3.ExecuteNonQuery()
            lblError.Text = "Usuario eliminado"
            lblError.ForeColor = Color.Aquamarine
            txtNombres.Text = "Nombres"
            txtUsuario.Text = "Usuario"
            txtContrasena.Text = "Contraseña"
            listarUsuarios()
        Catch ex As Exception
            lblError.Text = "Error del servidor" + ex.Message
            lblError.ForeColor = Color.Red
        End Try
        exist = "FAIL"
    End Sub

    Private Sub dgvListadoUsuarios_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoUsuarios.RowEnter
        Try
            If dgvListadoUsuarios.Rows(e.RowIndex).Cells(8).Value.ToString() <> "Vacío" Then
                id = dgvListadoUsuarios.Rows(e.RowIndex).Cells(8).Value
                numero = dgvListadoUsuarios.Rows(e.RowIndex).Cells(0).Value
                txtNombres.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(1).Value
                txtUsuario.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(2).Value
                txtContrasena.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(3).Value
                txtTelefono.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(4).Value
                txtEmail.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(5).Value
                cbSexo.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(6).Value
                cbTipo.Text = dgvListadoUsuarios.Rows(e.RowIndex).Cells(7).Value
                temp1 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(1).Value
                temp2 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(2).Value
                temp3 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(3).Value
                temp4 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(4).Value
                temp5 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(5).Value
                temp6 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(6).Value
                temp7 = dgvListadoUsuarios.Rows(e.RowIndex).Cells(7).Value
                dgvListadoUsuarios.Rows(numero - 1).Selected = True
                btnEditar.Enabled = True
                lblError.Text = "Usuario #" & numero & " seleccionado"
            End If
        Catch ex As Exception
            lblError.Text = "Seleccione una fila"
        End Try
    End Sub

    Private Sub frmNieto5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuarios()
    End Sub
    Sub listarUsuarios()
        Dim query As New OdbcCommand("SELECT * FROM usuarios", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            dgvListadoUsuarios.Rows.Clear()
            dgvListadoUsuarios.Columns.Clear()
            dgvListadoUsuarios.DataSource = Nothing
            dgvListadoUsuarios.Columns.Add("txtNumeroList", "#")
            dgvListadoUsuarios.Columns.Add("txtNombresList", "Nombres")
            dgvListadoUsuarios.Columns.Add("txtUsuarioList", "Usuario")
            dgvListadoUsuarios.Columns.Add("txtContrasenaList", "Contraseña")
            dgvListadoUsuarios.Columns.Add("txtTelefonoList", "Telefono")
            dgvListadoUsuarios.Columns.Add("txtEmailList", "Email")
            dgvListadoUsuarios.Columns.Add("txtSexoList", "Sexo")
            dgvListadoUsuarios.Columns.Add("txtTipoList", "Tipo")
            dgvListadoUsuarios.Columns.Add("txtIdList", "ID")
            dgvListadoUsuarios.Columns("txtIdList").Visible = False
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    dgvListadoUsuarios.Rows.Add()
                    dgvListadoUsuarios.Item(0, i).Value = i + 1
                    dgvListadoUsuarios.Item(1, i).Value = rs.Item("nombres").ToString()
                    dgvListadoUsuarios.Item(2, i).Value = rs.Item("usuario").ToString()
                    dgvListadoUsuarios.Item(3, i).Value = rs.Item("contrasena").ToString()
                    dgvListadoUsuarios.Item(4, i).Value = rs.Item("telefono").ToString()
                    dgvListadoUsuarios.Item(5, i).Value = rs.Item("email").ToString()
                    If rs.Item("sexo").ToString() = "1" Then
                        sexo = "Masculino"
                    ElseIf rs.Item("sexo").ToString() = "2"
                        sexo = "Femenino"
                    End If
                    If rs.Item("tipo_use").ToString() = "5" Then
                        tipo = "Engine"
                    ElseIf rs.Item("tipo_use").ToString() = "6"
                        tipo = "Administrador"
                    ElseIf rs.Item("tipo_use").ToString() = "9"
                        tipo = "Employer"
                    ElseIf rs.Item("tipo_use").ToString() = "3"
                        tipo = "Cliente"
                    ElseIf rs.Item("tipo_use").ToString() = "10"
                        tipo = "SUPERUSE"
                    ElseIf rs.Item("tipo_use").ToString() = "4"
                        tipo = "Ventas"
                    End If
                    dgvListadoUsuarios.Item(6, i).Value = sexo
                    dgvListadoUsuarios.Item(7, i).Value = tipo
                    dgvListadoUsuarios.Item(8, i).Value = rs.Item("id").ToString()
                    i = i + 1
                End While
                dgvListadoUsuarios.Rows(i).Height = 1
                lblError.Text = "Usuarios cargados"
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = "No hay usuarios para mostrar"
            End If
            i = 0
            dgvListadoUsuarios.CurrentCell.Selected = False
            rs.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub
End Class