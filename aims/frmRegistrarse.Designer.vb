<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarse
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlBarra = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cbLenguaje = New System.Windows.Forms.ComboBox()
        Me.pbEstado = New System.Windows.Forms.PictureBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnMInimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnReconectar = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.pblMensaje = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.gbContenedor = New System.Windows.Forms.GroupBox()
        Me.lineaTelefono = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.lineaEmail = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lineaPassword = New System.Windows.Forms.Panel()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lineaUser = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lineaNombres = New System.Windows.Forms.Panel()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.pnlBarra.SuspendLayout()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        Me.pblMensaje.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.gbContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBarra
        '
        Me.pnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlBarra.Controls.Add(Me.lblTitulo)
        Me.pnlBarra.Controls.Add(Me.cbLenguaje)
        Me.pnlBarra.Controls.Add(Me.pbEstado)
        Me.pnlBarra.Controls.Add(Me.lblEstado)
        Me.pnlBarra.Controls.Add(Me.btnMInimizar)
        Me.pnlBarra.Controls.Add(Me.btnCerrar)
        Me.pnlBarra.Controls.Add(Me.pbLogo)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(951, 30)
        Me.pnlBarra.TabIndex = 25
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(311, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(314, 24)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "REGISTRARSE COMO CLIENTE"
        '
        'cbLenguaje
        '
        Me.cbLenguaje.FormattingEnabled = True
        Me.cbLenguaje.Items.AddRange(New Object() {"Español[ES]", "English[EN]"})
        Me.cbLenguaje.Location = New System.Drawing.Point(698, 4)
        Me.cbLenguaje.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLenguaje.Name = "cbLenguaje"
        Me.cbLenguaje.Size = New System.Drawing.Size(92, 21)
        Me.cbLenguaje.TabIndex = 35
        Me.cbLenguaje.Text = "Español[ES]"
        '
        'pbEstado
        '
        Me.pbEstado.Image = Global.aims.My.Resources.Resources.icons8_down_arrow_200
        Me.pbEstado.Location = New System.Drawing.Point(869, 4)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(22, 16)
        Me.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEstado.TabIndex = 15
        Me.pbEstado.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(794, 7)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(74, 13)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "CONECTADO"
        '
        'btnMInimizar
        '
        Me.btnMInimizar.FlatAppearance.BorderSize = 0
        Me.btnMInimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMInimizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMInimizar.Location = New System.Drawing.Point(887, -2)
        Me.btnMInimizar.Name = "btnMInimizar"
        Me.btnMInimizar.Size = New System.Drawing.Size(32, 31)
        Me.btnMInimizar.TabIndex = 4
        Me.btnMInimizar.Text = "----"
        Me.btnMInimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Location = New System.Drawing.Point(916, -2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(32, 31)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.aims.My.Resources.Resources.logo
        Me.pbLogo.Location = New System.Drawing.Point(3, 1)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(53, 28)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'btnReconectar
        '
        Me.btnReconectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnReconectar.FlatAppearance.BorderSize = 0
        Me.btnReconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReconectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReconectar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReconectar.Location = New System.Drawing.Point(818, 35)
        Me.btnReconectar.Name = "btnReconectar"
        Me.btnReconectar.Size = New System.Drawing.Size(119, 31)
        Me.btnReconectar.TabIndex = 27
        Me.btnReconectar.Text = "Reconectar"
        Me.btnReconectar.UseVisualStyleBackColor = False
        Me.btnReconectar.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(10, 7)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(183, 32)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "El estado de su conexion a la" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "base de datos"
        '
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlInfo.Controls.Add(Me.lblMensaje)
        Me.pnlInfo.Location = New System.Drawing.Point(691, 30)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(200, 51)
        Me.pnlInfo.TabIndex = 26
        Me.pnlInfo.Visible = False
        '
        'pblMensaje
        '
        Me.pblMensaje.BackColor = System.Drawing.Color.White
        Me.pblMensaje.Controls.Add(Me.lblError)
        Me.pblMensaje.Controls.Add(Me.btnLimpiar)
        Me.pblMensaje.Controls.Add(Me.btnRegistrarse)
        Me.pblMensaje.Location = New System.Drawing.Point(21, 541)
        Me.pblMensaje.Name = "pblMensaje"
        Me.pblMensaje.Size = New System.Drawing.Size(906, 74)
        Me.pblMensaje.TabIndex = 29
        '
        'lblError
        '
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(7, 14)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(575, 47)
        Me.lblError.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(588, 24)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(108, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarse.FlatAppearance.BorderSize = 0
        Me.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarse.Location = New System.Drawing.Point(713, 24)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(157, 32)
        Me.btnRegistrarse.TabIndex = 0
        Me.btnRegistrarse.Text = "REGISTRARSE"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.White
        Me.pnlContenedor.Controls.Add(Me.gbContenedor)
        Me.pnlContenedor.Location = New System.Drawing.Point(21, 34)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(906, 488)
        Me.pnlContenedor.TabIndex = 28
        '
        'gbContenedor
        '
        Me.gbContenedor.BackColor = System.Drawing.Color.White
        Me.gbContenedor.Controls.Add(Me.lineaTelefono)
        Me.gbContenedor.Controls.Add(Me.txtTelefono)
        Me.gbContenedor.Controls.Add(Me.cbSexo)
        Me.gbContenedor.Controls.Add(Me.lblSexo)
        Me.gbContenedor.Controls.Add(Me.lineaEmail)
        Me.gbContenedor.Controls.Add(Me.lblEmail)
        Me.gbContenedor.Controls.Add(Me.txtEmail)
        Me.gbContenedor.Controls.Add(Me.lblTelefono)
        Me.gbContenedor.Controls.Add(Me.cbTipo)
        Me.gbContenedor.Controls.Add(Me.lblTipo)
        Me.gbContenedor.Controls.Add(Me.lineaPassword)
        Me.gbContenedor.Controls.Add(Me.lblContrasena)
        Me.gbContenedor.Controls.Add(Me.txtContrasena)
        Me.gbContenedor.Controls.Add(Me.lineaUser)
        Me.gbContenedor.Controls.Add(Me.lblUsuario)
        Me.gbContenedor.Controls.Add(Me.txtUsuario)
        Me.gbContenedor.Controls.Add(Me.lineaNombres)
        Me.gbContenedor.Controls.Add(Me.lblNombres)
        Me.gbContenedor.Controls.Add(Me.txtNombres)
        Me.gbContenedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbContenedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContenedor.ForeColor = System.Drawing.Color.Black
        Me.gbContenedor.Location = New System.Drawing.Point(17, 16)
        Me.gbContenedor.Name = "gbContenedor"
        Me.gbContenedor.Size = New System.Drawing.Size(867, 459)
        Me.gbContenedor.TabIndex = 60
        Me.gbContenedor.TabStop = False
        Me.gbContenedor.Text = "DATOS DEL USUARIO"
        '
        'lineaTelefono
        '
        Me.lineaTelefono.BackColor = System.Drawing.Color.DarkCyan
        Me.lineaTelefono.Location = New System.Drawing.Point(10, 293)
        Me.lineaTelefono.Margin = New System.Windows.Forms.Padding(1)
        Me.lineaTelefono.Name = "lineaTelefono"
        Me.lineaTelefono.Size = New System.Drawing.Size(848, 2)
        Me.lineaTelefono.TabIndex = 72
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.Gray
        Me.txtTelefono.Location = New System.Drawing.Point(10, 273)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(845, 22)
        Me.txtTelefono.TabIndex = 71
        Me.txtTelefono.Text = "000000"
        '
        'cbSexo
        '
        Me.cbSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSexo.ForeColor = System.Drawing.Color.Gray
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Location = New System.Drawing.Point(79, 400)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(775, 32)
        Me.cbSexo.TabIndex = 70
        Me.cbSexo.Text = "--Seleccionar--"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.Color.Black
        Me.lblSexo.Location = New System.Drawing.Point(9, 405)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(64, 24)
        Me.lblSexo.TabIndex = 69
        Me.lblSexo.Text = "Sexo: "
        '
        'lineaEmail
        '
        Me.lineaEmail.BackColor = System.Drawing.Color.DarkCyan
        Me.lineaEmail.Location = New System.Drawing.Point(9, 359)
        Me.lineaEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.lineaEmail.Name = "lineaEmail"
        Me.lineaEmail.Size = New System.Drawing.Size(848, 2)
        Me.lineaEmail.TabIndex = 64
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblEmail.Location = New System.Drawing.Point(10, 325)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 16)
        Me.lblEmail.TabIndex = 63
        Me.lblEmail.Text = "Email"
        Me.lblEmail.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(9, 339)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(845, 22)
        Me.txtEmail.TabIndex = 62
        Me.txtEmail.Text = "Email"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblTelefono.Location = New System.Drawing.Point(9, 259)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(62, 16)
        Me.lblTelefono.TabIndex = 60
        Me.lblTelefono.Text = "Telefono"
        Me.lblTelefono.Visible = False
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cbTipo.Enabled = False
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.ForeColor = System.Drawing.Color.Gray
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(169, 213)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(687, 32)
        Me.cbTipo.TabIndex = 58
        Me.cbTipo.Text = "Cliente"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(11, 218)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(152, 24)
        Me.lblTipo.TabIndex = 57
        Me.lblTipo.Text = "Tipo de usuario: "
        '
        'lineaPassword
        '
        Me.lineaPassword.BackColor = System.Drawing.Color.DarkCyan
        Me.lineaPassword.Location = New System.Drawing.Point(7, 183)
        Me.lineaPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.lineaPassword.Name = "lineaPassword"
        Me.lineaPassword.Size = New System.Drawing.Size(848, 2)
        Me.lineaPassword.TabIndex = 56
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblContrasena.Location = New System.Drawing.Point(8, 149)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(77, 16)
        Me.lblContrasena.TabIndex = 55
        Me.lblContrasena.Text = "Contraseña"
        Me.lblContrasena.Visible = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.Gray
        Me.txtContrasena.Location = New System.Drawing.Point(7, 163)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(845, 22)
        Me.txtContrasena.TabIndex = 54
        Me.txtContrasena.Text = "Contraseña"
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'lineaUser
        '
        Me.lineaUser.BackColor = System.Drawing.Color.DarkCyan
        Me.lineaUser.Location = New System.Drawing.Point(9, 130)
        Me.lineaUser.Margin = New System.Windows.Forms.Padding(1)
        Me.lineaUser.Name = "lineaUser"
        Me.lineaUser.Size = New System.Drawing.Size(848, 2)
        Me.lineaUser.TabIndex = 53
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblUsuario.Location = New System.Drawing.Point(10, 96)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 16)
        Me.lblUsuario.TabIndex = 52
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Visible = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Gray
        Me.txtUsuario.Location = New System.Drawing.Point(9, 110)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(845, 22)
        Me.txtUsuario.TabIndex = 51
        Me.txtUsuario.Text = "Usuario"
        '
        'lineaNombres
        '
        Me.lineaNombres.BackColor = System.Drawing.Color.DarkCyan
        Me.lineaNombres.Location = New System.Drawing.Point(7, 79)
        Me.lineaNombres.Margin = New System.Windows.Forms.Padding(1)
        Me.lineaNombres.Name = "lineaNombres"
        Me.lineaNombres.Size = New System.Drawing.Size(848, 2)
        Me.lineaNombres.TabIndex = 50
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.BackColor = System.Drawing.Color.Transparent
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblNombres.Location = New System.Drawing.Point(8, 45)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(64, 16)
        Me.lblNombres.TabIndex = 49
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.Visible = False
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.Gray
        Me.txtNombres.Location = New System.Drawing.Point(7, 59)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(845, 22)
        Me.txtNombres.TabIndex = 48
        Me.txtNombres.Text = "Nombres"
        '
        'frmRegistrarse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pblMensaje)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlBarra)
        Me.Controls.Add(Me.btnReconectar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistrarse"
        Me.pnlBarra.ResumeLayout(False)
        Me.pnlBarra.PerformLayout()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.pblMensaje.ResumeLayout(False)
        Me.pnlContenedor.ResumeLayout(False)
        Me.gbContenedor.ResumeLayout(False)
        Me.gbContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBarra As Panel
    Friend WithEvents cbLenguaje As ComboBox
    Friend WithEvents pbEstado As PictureBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnMInimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnReconectar As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents pblMensaje As Panel
    Friend WithEvents lblError As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegistrarse As Button
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents gbContenedor As GroupBox
    Friend WithEvents lineaTelefono As Panel
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents lineaEmail As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lineaPassword As Panel
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lineaUser As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lineaNombres As Panel
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblTitulo As Label
End Class
