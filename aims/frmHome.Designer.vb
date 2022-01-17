<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.btnReconectar = New System.Windows.Forms.Button()
        Me.cbLenguaje = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblConexion = New System.Windows.Forms.Label()
        Me.pnlIzquierdo = New System.Windows.Forms.Panel()
        Me.pbListadoArticulos = New System.Windows.Forms.PictureBox()
        Me.btnListarArticulos = New System.Windows.Forms.Button()
        Me.colorRegistros = New System.Windows.Forms.Panel()
        Me.btnRegistros = New System.Windows.Forms.Button()
        Me.colorTestimonios = New System.Windows.Forms.Panel()
        Me.btnTestimonios = New System.Windows.Forms.Button()
        Me.pnlCerrarSesiion = New System.Windows.Forms.Panel()
        Me.lblCerrarSesion = New System.Windows.Forms.Label()
        Me.colorInicio = New System.Windows.Forms.Panel()
        Me.colorTienda = New System.Windows.Forms.Panel()
        Me.colorMachine = New System.Windows.Forms.Panel()
        Me.colorUsuarios = New System.Windows.Forms.Panel()
        Me.colorContactanos = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.pbContactanos = New System.Windows.Forms.PictureBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAyuda = New System.Windows.Forms.Button()
        Me.btnContactanos = New System.Windows.Forms.Button()
        Me.btnMachineStoreInventory = New System.Windows.Forms.Button()
        Me.btnTienda = New System.Windows.Forms.Button()
        Me.btnPaginaInicio = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.msgEstado = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.msgUser = New System.Windows.Forms.Panel()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.pnlHead.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlIzquierdo.SuspendLayout()
        CType(Me.pbListadoArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCerrarSesiion.SuspendLayout()
        CType(Me.pbContactanos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.msgEstado.SuspendLayout()
        Me.msgUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHead
        '
        Me.pnlHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlHead.Controls.Add(Me.btnReconectar)
        Me.pnlHead.Controls.Add(Me.cbLenguaje)
        Me.pnlHead.Controls.Add(Me.Panel1)
        Me.pnlHead.Controls.Add(Me.PictureBox1)
        Me.pnlHead.Controls.Add(Me.Button3)
        Me.pnlHead.Controls.Add(Me.Button2)
        Me.pnlHead.Controls.Add(Me.Button1)
        Me.pnlHead.Controls.Add(Me.lblConexion)
        Me.pnlHead.Location = New System.Drawing.Point(0, 0)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(1150, 30)
        Me.pnlHead.TabIndex = 0
        '
        'btnReconectar
        '
        Me.btnReconectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReconectar.FlatAppearance.BorderSize = 0
        Me.btnReconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReconectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReconectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReconectar.Location = New System.Drawing.Point(751, 0)
        Me.btnReconectar.Name = "btnReconectar"
        Me.btnReconectar.Size = New System.Drawing.Size(119, 31)
        Me.btnReconectar.TabIndex = 25
        Me.btnReconectar.Text = "Reconectar"
        Me.btnReconectar.UseVisualStyleBackColor = False
        Me.btnReconectar.Visible = False
        '
        'cbLenguaje
        '
        Me.cbLenguaje.FormattingEnabled = True
        Me.cbLenguaje.Items.AddRange(New Object() {"Español[ES]", "English[EN]"})
        Me.cbLenguaje.Location = New System.Drawing.Point(878, 6)
        Me.cbLenguaje.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLenguaje.Name = "cbLenguaje"
        Me.cbLenguaje.Size = New System.Drawing.Size(92, 21)
        Me.cbLenguaje.TabIndex = 20
        Me.cbLenguaje.Text = "Español[ES]"
        '
        'Panel1
        '
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel1.Location = New System.Drawing.Point(200, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 519)
        Me.Panel1.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.aims.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(65, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 31)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Aims Machine"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(1087, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "----"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(1116, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblConexion
        '
        Me.lblConexion.AutoSize = True
        Me.lblConexion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblConexion.Location = New System.Drawing.Point(978, 9)
        Me.lblConexion.Name = "lblConexion"
        Me.lblConexion.Size = New System.Drawing.Size(74, 13)
        Me.lblConexion.TabIndex = 0
        Me.lblConexion.Text = "CONECTADO"
        '
        'pnlIzquierdo
        '
        Me.pnlIzquierdo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pnlIzquierdo.Controls.Add(Me.pbListadoArticulos)
        Me.pnlIzquierdo.Controls.Add(Me.btnListarArticulos)
        Me.pnlIzquierdo.Controls.Add(Me.colorRegistros)
        Me.pnlIzquierdo.Controls.Add(Me.btnRegistros)
        Me.pnlIzquierdo.Controls.Add(Me.colorTestimonios)
        Me.pnlIzquierdo.Controls.Add(Me.btnTestimonios)
        Me.pnlIzquierdo.Controls.Add(Me.pnlCerrarSesiion)
        Me.pnlIzquierdo.Controls.Add(Me.colorInicio)
        Me.pnlIzquierdo.Controls.Add(Me.colorTienda)
        Me.pnlIzquierdo.Controls.Add(Me.colorMachine)
        Me.pnlIzquierdo.Controls.Add(Me.colorUsuarios)
        Me.pnlIzquierdo.Controls.Add(Me.colorContactanos)
        Me.pnlIzquierdo.Controls.Add(Me.btnUsuarios)
        Me.pnlIzquierdo.Controls.Add(Me.pbContactanos)
        Me.pnlIzquierdo.Controls.Add(Me.lblTipo)
        Me.pnlIzquierdo.Controls.Add(Me.lblUsuario)
        Me.pnlIzquierdo.Controls.Add(Me.PictureBox2)
        Me.pnlIzquierdo.Controls.Add(Me.btnAyuda)
        Me.pnlIzquierdo.Controls.Add(Me.btnContactanos)
        Me.pnlIzquierdo.Controls.Add(Me.btnMachineStoreInventory)
        Me.pnlIzquierdo.Controls.Add(Me.btnTienda)
        Me.pnlIzquierdo.Controls.Add(Me.btnPaginaInicio)
        Me.pnlIzquierdo.Location = New System.Drawing.Point(0, 30)
        Me.pnlIzquierdo.Name = "pnlIzquierdo"
        Me.pnlIzquierdo.Size = New System.Drawing.Size(200, 648)
        Me.pnlIzquierdo.TabIndex = 1
        '
        'pbListadoArticulos
        '
        Me.pbListadoArticulos.Image = Global.aims.My.Resources.Resources.icons8_right_128
        Me.pbListadoArticulos.Location = New System.Drawing.Point(148, 295)
        Me.pbListadoArticulos.Name = "pbListadoArticulos"
        Me.pbListadoArticulos.Size = New System.Drawing.Size(47, 45)
        Me.pbListadoArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbListadoArticulos.TabIndex = 19
        Me.pbListadoArticulos.TabStop = False
        '
        'btnListarArticulos
        '
        Me.btnListarArticulos.BackColor = System.Drawing.Color.DarkCyan
        Me.btnListarArticulos.FlatAppearance.BorderSize = 0
        Me.btnListarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListarArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarArticulos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnListarArticulos.Location = New System.Drawing.Point(3, 295)
        Me.btnListarArticulos.Name = "btnListarArticulos"
        Me.btnListarArticulos.Size = New System.Drawing.Size(191, 45)
        Me.btnListarArticulos.TabIndex = 20
        Me.btnListarArticulos.Text = "LISTADO DE ARTICULOS"
        Me.btnListarArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarArticulos.UseVisualStyleBackColor = False
        '
        'colorRegistros
        '
        Me.colorRegistros.BackColor = System.Drawing.Color.DarkCyan
        Me.colorRegistros.Location = New System.Drawing.Point(0, 193)
        Me.colorRegistros.Name = "colorRegistros"
        Me.colorRegistros.Size = New System.Drawing.Size(10, 31)
        Me.colorRegistros.TabIndex = 16
        Me.colorRegistros.Visible = False
        '
        'btnRegistros
        '
        Me.btnRegistros.FlatAppearance.BorderSize = 0
        Me.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistros.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegistros.Location = New System.Drawing.Point(12, 193)
        Me.btnRegistros.Name = "btnRegistros"
        Me.btnRegistros.Size = New System.Drawing.Size(188, 31)
        Me.btnRegistros.TabIndex = 17
        Me.btnRegistros.Text = "Registros"
        Me.btnRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistros.UseVisualStyleBackColor = True
        Me.btnRegistros.Visible = False
        '
        'colorTestimonios
        '
        Me.colorTestimonios.BackColor = System.Drawing.Color.DarkCyan
        Me.colorTestimonios.Location = New System.Drawing.Point(0, 82)
        Me.colorTestimonios.Name = "colorTestimonios"
        Me.colorTestimonios.Size = New System.Drawing.Size(10, 31)
        Me.colorTestimonios.TabIndex = 14
        Me.colorTestimonios.Visible = False
        '
        'btnTestimonios
        '
        Me.btnTestimonios.FlatAppearance.BorderSize = 0
        Me.btnTestimonios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestimonios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestimonios.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTestimonios.Location = New System.Drawing.Point(12, 82)
        Me.btnTestimonios.Name = "btnTestimonios"
        Me.btnTestimonios.Size = New System.Drawing.Size(188, 31)
        Me.btnTestimonios.TabIndex = 15
        Me.btnTestimonios.Text = "Testimonios"
        Me.btnTestimonios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTestimonios.UseVisualStyleBackColor = True
        '
        'pnlCerrarSesiion
        '
        Me.pnlCerrarSesiion.BackColor = System.Drawing.Color.DarkCyan
        Me.pnlCerrarSesiion.Controls.Add(Me.lblCerrarSesion)
        Me.pnlCerrarSesiion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlCerrarSesiion.Location = New System.Drawing.Point(3, 490)
        Me.pnlCerrarSesiion.Name = "pnlCerrarSesiion"
        Me.pnlCerrarSesiion.Size = New System.Drawing.Size(197, 40)
        Me.pnlCerrarSesiion.TabIndex = 2
        '
        'lblCerrarSesion
        '
        Me.lblCerrarSesion.AutoSize = True
        Me.lblCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblCerrarSesion.Location = New System.Drawing.Point(4, 7)
        Me.lblCerrarSesion.Name = "lblCerrarSesion"
        Me.lblCerrarSesion.Size = New System.Drawing.Size(197, 25)
        Me.lblCerrarSesion.TabIndex = 0
        Me.lblCerrarSesion.Text = "CERRAR SESION"
        '
        'colorInicio
        '
        Me.colorInicio.BackColor = System.Drawing.Color.DarkCyan
        Me.colorInicio.Location = New System.Drawing.Point(0, 8)
        Me.colorInicio.Name = "colorInicio"
        Me.colorInicio.Size = New System.Drawing.Size(10, 31)
        Me.colorInicio.TabIndex = 2
        '
        'colorTienda
        '
        Me.colorTienda.BackColor = System.Drawing.Color.DarkCyan
        Me.colorTienda.Location = New System.Drawing.Point(0, 45)
        Me.colorTienda.Name = "colorTienda"
        Me.colorTienda.Size = New System.Drawing.Size(10, 31)
        Me.colorTienda.TabIndex = 13
        Me.colorTienda.Visible = False
        '
        'colorMachine
        '
        Me.colorMachine.BackColor = System.Drawing.Color.DarkCyan
        Me.colorMachine.Location = New System.Drawing.Point(0, 156)
        Me.colorMachine.Name = "colorMachine"
        Me.colorMachine.Size = New System.Drawing.Size(10, 31)
        Me.colorMachine.TabIndex = 2
        Me.colorMachine.Visible = False
        '
        'colorUsuarios
        '
        Me.colorUsuarios.BackColor = System.Drawing.Color.DarkCyan
        Me.colorUsuarios.Location = New System.Drawing.Point(0, 119)
        Me.colorUsuarios.Name = "colorUsuarios"
        Me.colorUsuarios.Size = New System.Drawing.Size(10, 31)
        Me.colorUsuarios.TabIndex = 1
        Me.colorUsuarios.Visible = False
        '
        'colorContactanos
        '
        Me.colorContactanos.BackColor = System.Drawing.Color.DarkCyan
        Me.colorContactanos.Location = New System.Drawing.Point(0, 345)
        Me.colorContactanos.Name = "colorContactanos"
        Me.colorContactanos.Size = New System.Drawing.Size(10, 31)
        Me.colorContactanos.TabIndex = 0
        Me.colorContactanos.Visible = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsuarios.Location = New System.Drawing.Point(12, 119)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(188, 31)
        Me.btnUsuarios.TabIndex = 12
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'pbContactanos
        '
        Me.pbContactanos.Image = Global.aims.My.Resources.Resources.icons8_right_128
        Me.pbContactanos.Location = New System.Drawing.Point(161, 351)
        Me.pbContactanos.Name = "pbContactanos"
        Me.pbContactanos.Size = New System.Drawing.Size(22, 20)
        Me.pbContactanos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbContactanos.TabIndex = 3
        Me.pbContactanos.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(12, 468)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(126, 13)
        Me.lblTipo.TabIndex = 10
        Me.lblTipo.Text = "ADMIN - EMPLOYER"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(52, 433)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(109, 13)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "USUARIO - USER"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.aims.My.Resources.Resources.icons8_user_100
        Me.PictureBox2.Location = New System.Drawing.Point(0, 416)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnAyuda
        '
        Me.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAyuda.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAyuda.Location = New System.Drawing.Point(0, 379)
        Me.btnAyuda.Name = "btnAyuda"
        Me.btnAyuda.Size = New System.Drawing.Size(200, 31)
        Me.btnAyuda.TabIndex = 9
        Me.btnAyuda.Text = "Ayuda"
        Me.btnAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAyuda.UseVisualStyleBackColor = True
        '
        'btnContactanos
        '
        Me.btnContactanos.FlatAppearance.BorderSize = 0
        Me.btnContactanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContactanos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactanos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnContactanos.Location = New System.Drawing.Point(12, 345)
        Me.btnContactanos.Name = "btnContactanos"
        Me.btnContactanos.Size = New System.Drawing.Size(188, 31)
        Me.btnContactanos.TabIndex = 8
        Me.btnContactanos.Text = "Contactanos"
        Me.btnContactanos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContactanos.UseVisualStyleBackColor = True
        '
        'btnMachineStoreInventory
        '
        Me.btnMachineStoreInventory.FlatAppearance.BorderSize = 0
        Me.btnMachineStoreInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMachineStoreInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMachineStoreInventory.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMachineStoreInventory.Location = New System.Drawing.Point(12, 156)
        Me.btnMachineStoreInventory.Name = "btnMachineStoreInventory"
        Me.btnMachineStoreInventory.Size = New System.Drawing.Size(188, 31)
        Me.btnMachineStoreInventory.TabIndex = 7
        Me.btnMachineStoreInventory.Text = "Machine store inventory"
        Me.btnMachineStoreInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMachineStoreInventory.UseVisualStyleBackColor = True
        '
        'btnTienda
        '
        Me.btnTienda.FlatAppearance.BorderSize = 0
        Me.btnTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTienda.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTienda.Location = New System.Drawing.Point(12, 45)
        Me.btnTienda.Name = "btnTienda"
        Me.btnTienda.Size = New System.Drawing.Size(188, 31)
        Me.btnTienda.TabIndex = 6
        Me.btnTienda.Text = "Tienda"
        Me.btnTienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTienda.UseVisualStyleBackColor = True
        '
        'btnPaginaInicio
        '
        Me.btnPaginaInicio.FlatAppearance.BorderSize = 0
        Me.btnPaginaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaginaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaginaInicio.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPaginaInicio.Location = New System.Drawing.Point(12, 8)
        Me.btnPaginaInicio.Name = "btnPaginaInicio"
        Me.btnPaginaInicio.Size = New System.Drawing.Size(188, 31)
        Me.btnPaginaInicio.TabIndex = 5
        Me.btnPaginaInicio.Text = "Página de inicio"
        Me.btnPaginaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPaginaInicio.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(200, 30)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(949, 648)
        Me.pnlContenedor.TabIndex = 19
        '
        'msgEstado
        '
        Me.msgEstado.BackColor = System.Drawing.Color.DarkSlateGray
        Me.msgEstado.Controls.Add(Me.Label2)
        Me.msgEstado.Location = New System.Drawing.Point(876, 24)
        Me.msgEstado.Name = "msgEstado"
        Me.msgEstado.Size = New System.Drawing.Size(200, 51)
        Me.msgEstado.TabIndex = 2
        Me.msgEstado.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "El estado de su conexion a la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "base de datos"
        '
        'msgUser
        '
        Me.msgUser.BackColor = System.Drawing.Color.DarkSlateGray
        Me.msgUser.Controls.Add(Me.btnPerfil)
        Me.msgUser.Controls.Add(Me.btnCerrarSesion)
        Me.msgUser.Location = New System.Drawing.Point(200, 446)
        Me.msgUser.Name = "msgUser"
        Me.msgUser.Size = New System.Drawing.Size(200, 74)
        Me.msgUser.TabIndex = 17
        Me.msgUser.Visible = False
        '
        'btnPerfil
        '
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPerfil.Location = New System.Drawing.Point(0, 3)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(200, 31)
        Me.btnPerfil.TabIndex = 13
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 37)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(200, 31)
        Me.btnCerrarSesion.TabIndex = 12
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 675)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlIzquierdo)
        Me.Controls.Add(Me.pnlHead)
        Me.Controls.Add(Me.msgUser)
        Me.Controls.Add(Me.msgEstado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHome"
        Me.pnlHead.ResumeLayout(False)
        Me.pnlHead.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlIzquierdo.ResumeLayout(False)
        Me.pnlIzquierdo.PerformLayout()
        CType(Me.pbListadoArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCerrarSesiion.ResumeLayout(False)
        Me.pnlCerrarSesiion.PerformLayout()
        CType(Me.pbContactanos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.msgEstado.ResumeLayout(False)
        Me.msgEstado.PerformLayout()
        Me.msgUser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHead As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblConexion As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlIzquierdo As Panel
    Friend WithEvents btnPaginaInicio As Button
    Friend WithEvents btnContactanos As Button
    Friend WithEvents btnMachineStoreInventory As Button
    Friend WithEvents btnTienda As Button
    Friend WithEvents msgEstado As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAyuda As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents pbContactanos As PictureBox
    Friend WithEvents msgUser As Panel
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents colorInicio As Panel
    Friend WithEvents colorTienda As Panel
    Friend WithEvents colorMachine As Panel
    Friend WithEvents colorUsuarios As Panel
    Friend WithEvents colorContactanos As Panel
    Friend WithEvents pnlCerrarSesiion As Panel
    Friend WithEvents lblCerrarSesion As Label
    Friend WithEvents cbLenguaje As System.Windows.Forms.ComboBox
    Friend WithEvents colorTestimonios As System.Windows.Forms.Panel
    Friend WithEvents btnTestimonios As System.Windows.Forms.Button
    Friend WithEvents colorRegistros As Panel
    Friend WithEvents btnRegistros As Button
    Friend WithEvents btnReconectar As Button
    Friend WithEvents pbListadoArticulos As PictureBox
    Friend WithEvents btnListarArticulos As Button
End Class
