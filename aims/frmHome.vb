Imports System.Net
Public Class frmHome
    Private Const WM_SYSCOMMAND As Integer = &H112&
    Private Const MOUSE_MOVE As Integer = &HF012&
    Dim f1 As New frmInicio
    Dim f2 As New frmTienda
    Public LocalHostName As String = Dns.GetHostName
    Public LocalIP As IPHostEntry = Dns.GetHostEntry(LocalHostName)
    Public id_usuario As Integer
    'MessageBox.Show(LocalIP.AddressList(0).ToString)

    <System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
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

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHead.MouseMove
        If e.Button = MouseButtons.Left Then
            moverForm()
        End If
    End Sub


    Private Sub Button6_MouseMove(sender As Object, e As MouseEventArgs) Handles btnTienda.MouseMove
        btnTienda.BackColor = Color.DarkGray
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles btnTienda.MouseLeave
        btnTienda.BackColor = Color.FromArgb(30, 38, 44)
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles lblConexion.MouseEnter
        lblConexion.Font = New Font(lblConexion.Font, FontStyle.Underline)
        msgEstado.Visible = True
        lblConexion.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles lblConexion.MouseLeave
        lblConexion.Font = New Font(lblConexion.Font, FontStyle.Regular)
        msgEstado.Visible = False
        lblConexion.BackColor = Color.FromArgb(20, 27, 32)
    End Sub

    Private Sub Button5_MouseMove(sender As Object, e As MouseEventArgs) Handles btnPaginaInicio.MouseMove
        btnPaginaInicio.BackColor = Color.DarkGray
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles btnPaginaInicio.MouseLeave
        btnPaginaInicio.BackColor = Color.FromArgb(30, 38, 44)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        btnMachineStoreInventory.BackColor = Color.DarkGray
    End Sub

    Private Sub Panel11_Enter(sender As Object, e As EventArgs)
        msgUser.Visible = True
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        End
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmInicio.TopLevel = False
        frmInicio.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmInicio)
        frmInicio.Show()
        btnPaginaInicio.Enabled = False
        If (cbLenguaje.Items.Count > 0) Then
            cbLenguaje.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnTienda.Click
        btnTienda.Enabled = False
        btnPaginaInicio.Enabled = True
        btnTestimonios.Enabled = True
        btnMachineStoreInventory.Enabled = True
        btnUsuarios.Enabled = True
        pnlContenedor.Controls.Clear()
        frmTienda.TopLevel = False
        frmTienda.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmTienda)
        frmTienda.Show()
        colorInicio.Visible = False
        colorTienda.Visible = True
        colorMachine.Visible = False
        colorUsuarios.Visible = False
        colorContactanos.Visible = False

    End Sub
    Private Sub btnMachineStoreInventory_Click(sender As Object, e As EventArgs) Handles btnMachineStoreInventory.Click
        btnMachineStoreInventory.Enabled = False
        btnPaginaInicio.Enabled = True
        btnTestimonios.Enabled = True
        btnTienda.Enabled = True
        btnUsuarios.Enabled = True
        pnlContenedor.Controls.Clear()
        frmProductos.TopLevel = False
        frmProductos.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmProductos)
        frmProductos.Show()
        colorInicio.Visible = False
        colorTienda.Visible = False
        colorMachine.Visible = True
        colorUsuarios.Visible = False
        colorContactanos.Visible = False
        frmTienda.btnRefrescar.Enabled = True

    End Sub

    Private Sub btnPaginaInicio_Click_1(sender As Object, e As EventArgs) Handles btnPaginaInicio.Click
        btnPaginaInicio.Enabled = False
        btnTienda.Enabled = True
        btnTestimonios.Enabled = True
        btnMachineStoreInventory.Enabled = True
        btnUsuarios.Enabled = True
        pnlContenedor.Controls.Clear()
        frmInicio.TopLevel = False
        frmInicio.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmInicio)
        frmInicio.Show()
        colorInicio.Visible = True
        colorTienda.Visible = False
        colorMachine.Visible = False
        colorUsuarios.Visible = False
        colorContactanos.Visible = False
    End Sub

    Private Sub btnMachineStoreInventory_MouseLeave(sender As Object, e As EventArgs) Handles btnMachineStoreInventory.MouseLeave
        btnMachineStoreInventory.BackColor = Color.FromArgb(30, 38, 44)
    End Sub

    Private Sub btnMachineStoreInventory_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMachineStoreInventory.MouseMove
        btnMachineStoreInventory.BackColor = Color.DarkGray
    End Sub

    Private Sub btnUsuarios_MouseLeave(sender As Object, e As EventArgs) Handles btnUsuarios.MouseLeave
        btnUsuarios.BackColor = Color.FromArgb(30, 38, 44)
    End Sub

    Private Sub btnUsuarios_MouseMove(sender As Object, e As MouseEventArgs) Handles btnUsuarios.MouseMove
        btnUsuarios.BackColor = Color.DarkGray
    End Sub

    Private Sub btnContactanos_MouseLeave(sender As Object, e As EventArgs) Handles btnContactanos.MouseLeave
        btnContactanos.BackColor = Color.FromArgb(30, 38, 44)
    End Sub

    Private Sub btnContactanos_MouseMove(sender As Object, e As MouseEventArgs) Handles btnContactanos.MouseMove
        btnContactanos.BackColor = Color.DarkGray
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        btnUsuarios.Enabled = False
        btnPaginaInicio.Enabled = True
        btnTestimonios.Enabled = True
        btnTienda.Enabled = True
        btnMachineStoreInventory.Enabled = True
        pnlContenedor.Controls.Clear()
        frmUsuarios.TopLevel = False
        frmUsuarios.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmUsuarios)
        frmUsuarios.Show()
        colorInicio.Visible = False
        colorTienda.Visible = False
        colorMachine.Visible = False
        colorUsuarios.Visible = True
        colorContactanos.Visible = False
    End Sub

    Private Sub btnContactanos_Click(sender As Object, e As EventArgs) Handles pbContactanos.Click, btnContactanos.Click
        frmContactanos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles pnlCerrarSesiion.Click, lblCerrarSesion.Click
        Me.Close()
        frmInicioSesion.Show()
        frmInicioSesion.txtUsuario.Text = lang(5)
        frmInicioSesion.txtContrasena.Text = lang(7)
    End Sub

    Private Sub btnTestimonios_Click(sender As Object, e As EventArgs) Handles btnTestimonios.Click
        btnTestimonios.Enabled = False
        btnUsuarios.Enabled = True
        btnPaginaInicio.Enabled = True
        btnTienda.Enabled = True
        btnMachineStoreInventory.Enabled = True
        pnlContenedor.Controls.Clear()
        frmTestimonios.TopLevel = False
        frmTestimonios.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmTestimonios)
        frmTestimonios.Show()
        colorInicio.Visible = False
        colorTienda.Visible = False
        colorMachine.Visible = False
        colorUsuarios.Visible = False
        colorTestimonios.Visible = False
        colorContactanos.Visible = False
    End Sub

    Private Sub btnReconectar_Click(sender As Object, e As EventArgs) Handles btnReconectar.Click
        conectar()
    End Sub


    Private Sub btnRegistros_Click(sender As Object, e As EventArgs) Handles btnRegistros.Click
        btnMachineStoreInventory.Enabled = True
        btnPaginaInicio.Enabled = True
        btnTestimonios.Enabled = True
        btnTienda.Enabled = True
        btnUsuarios.Enabled = True
        btnListarArticulos.Enabled = True
        btnRegistros.Enabled = False
        pnlContenedor.Controls.Clear()
        frmRegistros.TopLevel = False
        frmRegistros.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmRegistros)
        frmRegistros.Show()
        colorInicio.Visible = False
        colorTienda.Visible = False
        colorMachine.Visible = False
        colorUsuarios.Visible = False
        colorContactanos.Visible = False
        frmTienda.btnRefrescar.Enabled = True
    End Sub

    Private Sub btnListarArticulos_Click(sender As Object, e As EventArgs) Handles btnListarArticulos.Click
        btnMachineStoreInventory.Enabled = True
        btnPaginaInicio.Enabled = True
        btnTestimonios.Enabled = True
        btnTienda.Enabled = True
        btnUsuarios.Enabled = True
        btnListarArticulos.Enabled = False
        pnlContenedor.Controls.Clear()
        frmListadoArticulos.TopLevel = False
        frmListadoArticulos.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmListadoArticulos)
        frmListadoArticulos.Show()
        colorInicio.Visible = False
        colorTienda.Visible = False
        colorMachine.Visible = False
        colorUsuarios.Visible = False
        colorContactanos.Visible = False
        frmTienda.btnRefrescar.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLenguaje.SelectedIndexChanged
        If cbLenguaje.Text = "Español[ES]" Then
            lenguaje("es")
        ElseIf cbLenguaje.Text = "English[EN]" Then
            lenguaje("en")
        End If
        'Lang frmHome
        lblConexion.Text = lang(0)
        btnPaginaInicio.Text = lang(114)
        btnTienda.Text = lang(115)
        btnTestimonios.Text = lang(116)
        btnUsuarios.Text = lang(117)
        btnMachineStoreInventory.Text = lang(118)
        btnRegistros.Text = lang(119)
        btnListarArticulos.Text = lang(120)
        btnContactanos.Text = lang(121)
        lblCerrarSesion.Text = lang(122)
        btnAyuda.Text = lang(123)
        'Lang frmInicio
        frmInicio.lblTItulo.Text = lang(79)
        frmInicio.lblPagina.Text = lang(80)
        'Lang frmTienda
        frmTienda.btnRefrescar.Text = lang(91)
        frmTienda.lblTitulo.Text = lang(90)
        'Lang frmTestimonios
        frmTestimonios.btnRefrescar.Text = lang(91)
        frmTestimonios.lblTitulo2.Text = lang(98)
        frmTestimonios.btnTestimonio.Text = lang(99)
        frmTestimonios.lblTitulo.Text = lang(100)
        frmTestimonios.btnEstado.Text = lang(101)
        frmTestimonios.lblMensaje.Text = lang(102)
        frmTestimonios.lblTitulo3.Text = lang(103)
        'Lang frmUsuarios
        frmUsuarios.lblAgregar.Text = lang(111)
        frmUsuarios.lblEliminar.Text = lang(112)
        frmUsuarios.lblTitulo.Text = lang(113)
        'Lang frmProductos
        frmProductos.lblAgregar.Text = lang(87)
        frmProductos.lblEliminar.Text = lang(88)
        frmProductos.lblEditar.Text = lang(89)
        frmProductos.lblTitulo.Text = lang(90)
        'Lang frmRegistros
        frmRegistros.btnRefrescar.Text = lang(91)
        frmRegistros.lblTitulo.Text = lang(124)
        If lang(93) = "es" Then
            frmRegistros.cbOrdenar.Text = "--Seleccionar--"
            frmRegistros.cbOrdenar.Items.Clear()
            frmRegistros.cbOrdenar.Items.Add("--Seleccionar--")
            frmRegistros.cbOrdenar.Items.Add(lang(125))
            frmRegistros.cbOrdenar.Items.Add(lang(116))
            frmRegistros.cbOrdenar.Items.Add(lang(117))
        ElseIf lang(93) = "en"
            frmRegistros.cbOrdenar.Text = "--Select--"
            frmRegistros.cbOrdenar.Items.Clear()
            frmRegistros.cbOrdenar.Items.Add("--Select--")
            frmRegistros.cbOrdenar.Items.Add(lang(125))
            frmRegistros.cbOrdenar.Items.Add(lang(116))
            frmRegistros.cbOrdenar.Items.Add(lang(117))
        End If
        frmRegistros.lblOrdenar.Text = lang(92)
        frmRegistros.gbListado.Text = lang(94)
        'Lang frmListadoArticulos
        frmListadoArticulos.lblTexto.Text = lang(81)
        frmListadoArticulos.lblTitulo.Text = lang(82)
        frmListadoArticulos.gbStock.Text = lang(84)
        frmListadoArticulos.lblStock.Text = lang(83)
        frmListadoArticulos.lblTerminados.Text = lang(83)
        frmListadoArticulos.gbTerminados.Text = lang(85)
        'Lang frmContactanos
        frmContactanos.btnCerrar.Text = lang(49)
        'Lang frm
    End Sub

End Class