<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarEliminarUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.gbListado = New System.Windows.Forms.GroupBox()
        Me.dgvListadoUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbListado.SuspendLayout()
        CType(Me.dgvListadoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnEditar)
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Location = New System.Drawing.Point(9, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 74)
        Me.Panel2.TabIndex = 6
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(648, 24)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(108, 32)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(3, 14)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(639, 47)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(774, 24)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 32)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.cbSexo)
        Me.Panel1.Controls.Add(Me.lblSexo)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.cbTipo)
        Me.Panel1.Controls.Add(Me.lblTipo)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.lblContrasena)
        Me.Panel1.Controls.Add(Me.txtContrasena)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.lblUsuario)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lblNombres)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.gbListado)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 488)
        Me.Panel1.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.Gray
        Me.txtTelefono.Location = New System.Drawing.Point(26, 395)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(421, 22)
        Me.txtTelefono.TabIndex = 90
        Me.txtTelefono.Text = "0"
        '
        'cbSexo
        '
        Me.cbSexo.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSexo.ForeColor = System.Drawing.Color.Gray
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"--Seleccionar--", "Masculino", "Femenino"})
        Me.cbSexo.Location = New System.Drawing.Point(94, 437)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(354, 28)
        Me.cbSexo.TabIndex = 89
        Me.cbSexo.Text = "Todos"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.ForeColor = System.Drawing.Color.Black
        Me.lblSexo.Location = New System.Drawing.Point(24, 442)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(64, 24)
        Me.lblSexo.TabIndex = 88
        Me.lblSexo.Text = "Sexo: "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Location = New System.Drawing.Point(490, 457)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(400, 2)
        Me.Panel7.TabIndex = 86
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblEmail.Location = New System.Drawing.Point(491, 423)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 16)
        Me.lblEmail.TabIndex = 85
        Me.lblEmail.Text = "Email"
        Me.lblEmail.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Gray
        Me.txtEmail.Location = New System.Drawing.Point(490, 437)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(397, 22)
        Me.txtEmail.TabIndex = 84
        Me.txtEmail.Text = "Email"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Location = New System.Drawing.Point(25, 418)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(418, 2)
        Me.Panel6.TabIndex = 83
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblTelefono.Location = New System.Drawing.Point(24, 379)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(62, 16)
        Me.lblTelefono.TabIndex = 82
        Me.lblTelefono.Text = "Telefono"
        Me.lblTelefono.Visible = False
        '
        'cbTipo
        '
        Me.cbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.ForeColor = System.Drawing.Color.Gray
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"--Seleccionar--", "Engine", "Administrador", "Employer", "Ventas", "Cliente"})
        Me.cbTipo.Location = New System.Drawing.Point(638, 379)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(252, 28)
        Me.cbTipo.TabIndex = 81
        Me.cbTipo.Text = "Todos"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(489, 383)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(152, 24)
        Me.lblTipo.TabIndex = 80
        Me.lblTipo.Text = "Tipo de usuario: "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Location = New System.Drawing.Point(489, 348)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(400, 2)
        Me.Panel5.TabIndex = 79
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblContrasena.Location = New System.Drawing.Point(490, 314)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(77, 16)
        Me.lblContrasena.TabIndex = 78
        Me.lblContrasena.Text = "Contraseña"
        Me.lblContrasena.Visible = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.Gray
        Me.txtContrasena.Location = New System.Drawing.Point(489, 328)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(397, 22)
        Me.txtContrasena.TabIndex = 77
        Me.txtContrasena.Text = "Contraseña"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Location = New System.Drawing.Point(27, 348)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(424, 2)
        Me.Panel4.TabIndex = 76
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblUsuario.Location = New System.Drawing.Point(28, 314)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 16)
        Me.lblUsuario.TabIndex = 75
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Visible = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Gray
        Me.txtUsuario.Location = New System.Drawing.Point(27, 328)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(421, 22)
        Me.txtUsuario.TabIndex = 74
        Me.txtUsuario.Text = "Usuario"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Location = New System.Drawing.Point(24, 293)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(868, 2)
        Me.Panel3.TabIndex = 73
        '
        'lblNombres
        '
        Me.lblNombres.AutoSize = True
        Me.lblNombres.BackColor = System.Drawing.Color.Transparent
        Me.lblNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombres.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblNombres.Location = New System.Drawing.Point(25, 259)
        Me.lblNombres.Name = "lblNombres"
        Me.lblNombres.Size = New System.Drawing.Size(64, 16)
        Me.lblNombres.TabIndex = 72
        Me.lblNombres.Text = "Nombres"
        Me.lblNombres.Visible = False
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.Color.Gray
        Me.txtNombres.Location = New System.Drawing.Point(24, 273)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(865, 22)
        Me.txtNombres.TabIndex = 71
        Me.txtNombres.Text = "Nombres"
        '
        'gbListado
        '
        Me.gbListado.BackColor = System.Drawing.Color.White
        Me.gbListado.Controls.Add(Me.dgvListadoUsuarios)
        Me.gbListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbListado.ForeColor = System.Drawing.Color.Black
        Me.gbListado.Location = New System.Drawing.Point(17, 15)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(867, 226)
        Me.gbListado.TabIndex = 54
        Me.gbListado.TabStop = False
        Me.gbListado.Text = "LISTADO  DE USUARIOS"
        '
        'dgvListadoUsuarios
        '
        Me.dgvListadoUsuarios.AllowUserToDeleteRows = False
        Me.dgvListadoUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvListadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsuarios.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListadoUsuarios.Location = New System.Drawing.Point(11, 29)
        Me.dgvListadoUsuarios.Name = "dgvListadoUsuarios"
        Me.dgvListadoUsuarios.ReadOnly = True
        DataGridViewCellStyle1.NullValue = "Vacío"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoUsuarios.Size = New System.Drawing.Size(841, 188)
        Me.dgvListadoUsuarios.TabIndex = 0
        '
        'frmEditarEliminarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditarEliminarUsuarios"
        Me.Text = "frmNieto5"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbListado.ResumeLayout(False)
        CType(Me.dgvListadoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblError As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbListado As GroupBox
    Friend WithEvents dgvListadoUsuarios As DataGridView
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblTelefono As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtTelefono As TextBox
End Class
