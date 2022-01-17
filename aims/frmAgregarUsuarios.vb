Imports System.Data.Odbc
Public Class frmAgregarUsuarios
    Dim nombres, contrasena, usuario, tipo, sexo, email As String
    Private Sub getTelefono(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.GotFocus
        lblTelefono.Visible = True
        If txtTelefono.Text = "000000" Then
            txtTelefono.Text = ""
        End If
    End Sub
    Private Sub lostTelefono(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.LostFocus
        lblTelefono.Visible = False
        If txtTelefono.Text = "" Then
            txtTelefono.Text = "000000"
        End If
    End Sub
    Private Sub onlyTelefono(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNombres_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombres.GotFocus
        lblNombres.Visible = True
        If txtNombres.Text = "Nombres" Then
            txtNombres.Text = ""
        End If
    End Sub
    Private Sub txtNombres_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombres.LostFocus
        lblNombres.Visible = False
        If txtNombres.Text = "" Then
            txtNombres.Text = "Nombres"
        End If
    End Sub
    Private Sub txtUsuario_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        lblUsuario.Visible = True
        If txtUsuario.Text = "Usuario" Then
            txtUsuario.Text = ""
        End If
    End Sub
    Private Sub txtUsuario_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.LostFocus
        lblUsuario.Visible = False
        If txtUsuario.Text = "" Then
            txtUsuario.Text = "Usuario"
        End If
    End Sub
    Private Sub txtContrasena_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.GotFocus
        lblContrasena.Visible = True
        If txtContrasena.Text = "Contraseña" Then
            txtContrasena.Text = ""
        End If
    End Sub
    Private Sub txtContrasena_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.LostFocus
        lblContrasena.Visible = False
        If txtContrasena.Text = "" Then
            txtContrasena.Text = "Contraseña"
        End If
    End Sub
    Private Sub txtEmail_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
        lblEmail.Visible = True
        If txtEmail.Text = "Email" Then
            txtEmail.Text = ""
        End If
    End Sub
    Private Sub txtEmail_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
        lblEmail.Visible = False
        If txtEmail.Text = "" Then
            txtEmail.Text = "Email"
        End If
    End Sub
    Private Sub txtTelefono_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.GotFocus
        lblTelefono.Visible = True
        If txtTelefono.Text = "000000" Then
            txtTelefono.Text = ""
        End If
    End Sub
    Private Sub txtTelefono_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelefono.LostFocus
        lblTelefono.Visible = False
        If txtTelefono.Text = "" Then
            txtTelefono.Text = "000000"
        End If
    End Sub
    Private Sub textbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Dim telefono As Integer
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombres.Text = "Nombres"
        txtUsuario.Text = "Usuario"
        txtContrasena.Text = "Contraseña"
        txtTelefono.Text = "000000"
        txtEmail.Text = "Email"
        cbTipo.Text = "--Seleccionar--"
        cbSexo.Text = "--Seleccionar--"
        lblError.Text = "Cajas de texto limpiadas"
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmHome.Enabled = False
        Try
            nombres = txtNombres.Text
            usuario = txtUsuario.Text
            contrasena = txtContrasena.Text
            tipo = cbTipo.Text
            sexo = cbSexo.Text
            telefono = CInt(txtTelefono.Text)
            email = txtEmail.Text
            If nombres = "Nombres" Or usuario = "Usuario" Or contrasena = "" Or tipo = "--Seleccionar--" Or sexo = "--Seleccionar--" Or email = "Email" Then
                lblError.Text = "Error - Campos vacios"
            Else
                If conexion.State = 0 Then
                    conexion.Open()
                End If
                Dim query1 As New OdbcCommand("SELECT usuario FROM usuarios WHERE usuario = '" & usuario & "'", conexion)
                Dim rs1 As OdbcDataReader
                If conexion.State = 0 Then
                    conexion.Open()
                End If
                rs1 = query1.ExecuteReader()
                If rs1.Read Then
                    lblError.Text = "Ya existe un usuario con ese nombre"
                    rs1.Close()
                Else
                    If conexion.State = 0 Then
                        conexion.Open()
                    End If
                    If cbSexo.Text = "Masculino" Then
                        sexo = 1
                    ElseIf cbSexo.Text = "Femenino" Then
                        sexo = 2
                    End If
                    If cbTipo.Text = "Engine" Then
                        tipo = 5
                    ElseIf cbTipo.Text = "Administrador"
                        tipo = 6
                    ElseIf cbTipo.Text = "Employer"
                        tipo = 9
                    ElseIf cbTipo.Text = "Ventas"
                        tipo = 4
                    ElseIf cbTipo.Text = "Cliente"
                        tipo = 3
                    End If
                    Dim query2 As New OdbcCommand("INSERT INTO usuarios VALUES ('', " & tipo & ", '" & usuario & "', '" & contrasena & "', '" & nombres & "', " & telefono & ", '" & email & "', " & sexo & ")", conexion)
                    Try
                        query2.ExecuteNonQuery()
                        txtNombres.Text = "Nombres"
                        txtUsuario.Text = "Usuario"
                        txtContrasena.Text = "Contraseña"
                        txtTelefono.Text = "000000"
                        txtEmail.Text = "Email"
                        cbTipo.Text = "--Seleccionar--"
                        cbSexo.Text = "--Seleccionar--"
                    Catch exx As Exception
                        lblError.Text = exx.Message
                    End Try
                End If
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
        frmHome.Enabled = True
    End Sub

End Class