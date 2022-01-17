Imports System.Data.Odbc
Imports System.Net
Public Class frmRegistrarse
    Dim nombres, contrasena, usuario, tipo, sexo, email As String
    Public tabla, ip, fecha, que_hizo As String
    Public id_usuario As Integer
    Public LocalHostName As String = Dns.GetHostName
    Public LocalIP As IPHostEntry = Dns.GetHostEntry(LocalHostName)
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlBarra.MouseMove
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(
            ByVal hWnd As System.IntPtr, ByVal wMsg As Integer,
            ByVal wParam As Integer, ByVal lParam As Integer
            )
    End Sub
    Private Sub moverForm()
        ReleaseCapture()
        SendMessage(Me.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        frmInicioSesion.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        frmHome.Enabled = False
        Try
            nombres = txtNombres.Text
            usuario = txtUsuario.Text
            contrasena = txtContrasena.Text
            sexo = cbSexo.Text
            email = txtEmail.Text
            If nombres = "Names" Or nombres = "Nombres" Or usuario = "User" Or usuario = "Usuario" Or contrasena = "Contraseña" Or contrasena = "Password" Or sexo = "--Seleccionar--" Or email = "Email" Then
                lblError.Text = lang(13)
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
                    lblError.Text = lang(29)
                    rs1.Close()
                Else
                    If cbSexo.Text = "Masculino" Or cbSexo.Text = "Male" Then
                        sexo = 1
                    ElseIf cbSexo.Text = "Femenino" Or cbSexo.Text = "Female" Then
                        sexo = 2
                    End If
                    rs1.Close()
                    If conexion.State = 0 Then
                        conexion.Open()
                    End If
                    Dim query2 As New OdbcCommand("INSERT INTO usuarios VALUES ('', " & 3 & ", '" & usuario & "', '" & contrasena & "', '" & nombres & "', " & CInt(txtTelefono.Text) & ", '" & email & "', " & sexo & ")", conexion)
                    Try
                        query2.ExecuteNonQuery()
                        txtNombres.Text = lang(19)
                        txtUsuario.Text = lang(5)
                        txtContrasena.Text = lang(6)
                        txtTelefono.Text = "000000"
                        txtEmail.Text = "Email"
                        lblError.Text = lang(30)
                        fecha = DateTime.Now.ToString("yyyy-MM-dd")
                        mdlFunciones.f003(conexion, 4, "USUARIOS", LocalIP.AddressList(0).ToString, fecha.ToString(), """INSERT INTO usuarios VALUES ('', " & 3 & ", " & usuario & ", " & contrasena & ", " & nombres & ", " & CInt(txtTelefono.Text) & ", " & email & ", " & sexo & ")""")
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
    Private Sub txtNombres_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombres.GotFocus
        lblNombres.Visible = True
        If txtNombres.Text = lang(18) Then
            txtNombres.Text = ""
        End If
    End Sub
    Private Sub txtNombres_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombres.LostFocus
        lblNombres.Visible = False
        If txtNombres.Text = "" Then
            txtNombres.Text = lang(18)
        End If
    End Sub
    Private Sub txtUsuario_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        lblUsuario.Visible = True
        If txtUsuario.Text = lang(5) Then
            txtUsuario.Text = ""
        End If
    End Sub
    Private Sub txtUsuario_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.LostFocus
        lblUsuario.Visible = False
        If txtUsuario.Text = "" Then
            txtUsuario.Text = lang(5)
        End If
    End Sub

    Private Sub frmRegistrarse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (cbLenguaje.Items.Count > 0) Then
            cbLenguaje.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbLenguaje_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLenguaje.SelectedIndexChanged
        If cbLenguaje.Text = "Español[ES]" Then
            lenguaje("es")
        ElseIf cbLenguaje.Text = "English[EN]" Then
            lenguaje("en")
        End If
        lblEstado.Text = lang(0)
        lblMensaje.Text = lang(1)
        btnReconectar.Text = lang(2)
        lblTitulo.Text = lang(16)
        lblUsuario.Text = lang(4)
        txtUsuario.Text = lang(5)
        lblContrasena.Text = lang(6)
        txtContrasena.Text = lang(7)
        gbContenedor.Text = lang(17)
        lblNombres.Text = lang(18)
        txtNombres.Text = lang(19)
        lblTipo.Text = lang(20)
        lblTelefono.Text = lang(22)
        lblEmail.Text = lang(23)
        txtEmail.Text = lang(24)
        lblSexo.Text = lang(25)
        If lang(26) = "es" Then
            cbSexo.Text = "--Seleccionar--"
            cbSexo.Items.Clear()
            cbSexo.Items.Add("--Seleccionar--")
            cbSexo.Items.Add("Masculino")
            cbSexo.Items.Add("Femenino")
        ElseIf lang(26) = "en"
            cbSexo.Text = "--Select--"
            cbSexo.Items.Clear()
            cbSexo.Items.Add("--Select--")
            cbSexo.Items.Add("Male")
            cbSexo.Items.Add("Female")
        End If
        btnLimpiar.Text = lang(27)
        btnRegistrarse.Text = lang(28)
    End Sub

    Private Sub txtContrasena_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.GotFocus
        lblContrasena.Visible = True
        If txtContrasena.Text = lang(6) Then
            txtContrasena.Text = ""
        End If
    End Sub
    Private Sub txtContrasena_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.LostFocus
        lblContrasena.Visible = False
        If txtContrasena.Text = "" Then
            txtContrasena.Text = lang(6)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombres.Text = lang(18)
        txtUsuario.Text = lang(5)
        txtContrasena.Text = lang(6)
        txtTelefono.Text = "000000"
        txtEmail.Text = "Email"
        lblError.Text = lang(31)
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
    Private Sub onlyTelefono(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If txtTelefono.TextLength = 9 Then
            e.Handled = True
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class