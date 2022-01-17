Imports System.Data.Odbc
Imports System.Net
Public Class frmInicioSesion
    Dim user, pass, msg As String
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    Private Sub PnlBarra_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlBarra.MouseMove
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
    Private Sub txtContrasena_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.GotFocus
        lblContrasena.Visible = True
        If txtContrasena.Text = lang(7) Then
            txtContrasena.Text = ""
        End If
    End Sub
    Private Sub txtContrasena_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContrasena.LostFocus
        lblContrasena.Visible = True
        If txtContrasena.Text = "" Then
            txtContrasena.Text = lang(7)
        End If
    End Sub

    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            user = txtUsuario.Text : pass = txtContrasena.Text
            If user.Length = 0 Or pass.Length = 0 Then
                lblError.ForeColor = Color.Red
                lblError.Text = lang(13)
                If user = lang(5) Or user.Length = 0 Then
                    txtUsuario.Focus()
                Else
                    txtUsuario.Focus()
                End If
                If pass = lang(7) Or pass.Length = 0 Then
                Else
                    txtUsuario.Focus()
                End If
            ElseIf user = lang(5) Then
                lblError.ForeColor = Color.Red
                lblError.Text = lang(13)
            Else
                lblError.Text = ""
                If conexion.State = 0 Then
                    conexion.Open()
                End If
                Dim query As New OdbcCommand("select u.id, u.tipo_use, u.usuario, u.contrasena, u.nombres, a.nombre from usuarios u inner join auxiliar a on u.tipo_use = a.id_aux where u.usuario = '" & user & "' and u.contrasena = '" & pass & "' and a.codigo = 'TDU'", conexion)
                Dim rs As OdbcDataReader
                Try
                    rs = query.ExecuteReader()
                    If rs.Read Then
                        Me.Hide()
                        frmHome.id_usuario = rs.Item("id")
                        frmTestimonios.id_usuario = rs.Item("id")
                        frmEditar.id_usuario = rs.Item("id")
                        frmTestimonios.nombre = rs.Item("nombres")
                        frmHome.lblUsuario.Text = rs.Item("nombres").ToString.ToUpper()
                        frmHome.lblTipo.Text = rs.Item("nombre").ToString.ToUpper()
                        If rs.Item("tipo_use").ToString() = "3" Then
                            frmHome.btnMachineStoreInventory.Visible = False
                            frmHome.btnUsuarios.Visible = False
                            frmHome.btnRegistros.Visible = False
                            frmHome.btnListarArticulos.Visible = False
                            frmHome.pbListadoArticulos.Visible = False
                            frmTestimonios.tipo_usuario = 3
                        End If
                        If rs.Item("tipo_use").ToString() = "10" Then
                            frmHome.btnRegistros.Visible = True
                        End If
                        frmHome.Show()
                    Else
                        lblError.ForeColor = Color.Red
                        lblError.Text = lang(14)
                    End If
                    rs.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    lblError.Text = lang(15) + ex.Message
                End Try
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        End
    End Sub

    Private Sub btnReconectar_Click(sender As Object, e As EventArgs) Handles btnReconectar.Click
        conectar()
    End Sub

    Private Sub txtuno_Click(sender As Object, e As EventArgs) Handles txtuno.Click
        txtUsuario.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnContrasena.Click
        txtContrasena.Focus()
    End Sub

    Private Sub lblEstado_MouseEnter(sender As Object, e As EventArgs) Handles pbEstado.MouseEnter, lblEstado.MouseEnter
        pnlInfo.Visible = True
    End Sub

    Private Sub lblEstado_MouseLeave(sender As Object, e As EventArgs) Handles pbEstado.MouseLeave, lblEstado.MouseLeave
        pnlInfo.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMInimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        If (cbLenguaje.Items.Count > 0) Then
            cbLenguaje.SelectedIndex = 0
        End If
        txtUsuario.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Me.Enabled = False
        frmRegistrarse.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblMostrar.Click
        If txtContrasena.UseSystemPasswordChar = True Then
            lblMostrar.Text = lang(9)
            txtContrasena.UseSystemPasswordChar = False
        Else
            txtContrasena.UseSystemPasswordChar = True
            lblMostrar.Text = lang(8)
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
        lblTitulo.Text = lang(3)
        lblUsuario.Text = lang(4)
        txtUsuario.Text = lang(5)
        lblContrasena.Text = lang(6)
        txtContrasena.Text = lang(7)
        lblMostrar.Text = lang(8)
        lblBienvenida.Text = lang(10)
        btnInicioSesion.Text = lang(11)
        btnRegistrarse.Text = lang(12)
    End Sub
End Class