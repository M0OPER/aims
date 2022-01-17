<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuarios
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombres = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Location = New System.Drawing.Point(9, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 74)
        Me.Panel2.TabIndex = 4
        '
        'lblError
        '
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(7, 14)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(602, 47)
        Me.lblError.TabIndex = 0
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(621, 24)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(108, 32)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(762, 24)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(108, 32)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 488)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.txtTelefono)
        Me.GroupBox2.Controls.Add(Me.cbSexo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Panel7)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.lblTelefono)
        Me.GroupBox2.Controls.Add(Me.cbTipo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Panel5)
        Me.GroupBox2.Controls.Add(Me.lblContrasena)
        Me.GroupBox2.Controls.Add(Me.txtContrasena)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.lblUsuario)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.lblNombres)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(867, 459)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL USUARIO"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel6.Location = New System.Drawing.Point(10, 293)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(848, 2)
        Me.Panel6.TabIndex = 72
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
        Me.cbSexo.Items.AddRange(New Object() {"--Seleccionar--", "Masculino", "Femenino"})
        Me.cbSexo.Location = New System.Drawing.Point(79, 400)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(775, 32)
        Me.cbSexo.TabIndex = 70
        Me.cbSexo.Text = "--Seleccionar--"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Sexo: "
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel7.Location = New System.Drawing.Point(9, 359)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(848, 2)
        Me.Panel7.TabIndex = 64
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
        Me.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipo.ForeColor = System.Drawing.Color.Gray
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"--Seleccionar--", "Engine", "Administrador", "Employer", "Ventas", "Cliente"})
        Me.cbTipo.Location = New System.Drawing.Point(169, 213)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(687, 32)
        Me.cbTipo.TabIndex = 58
        Me.cbTipo.Text = "--Seleccionar--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(11, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 24)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Tipo de usuario: "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Location = New System.Drawing.Point(7, 183)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(848, 2)
        Me.Panel5.TabIndex = 56
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
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Location = New System.Drawing.Point(9, 130)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(848, 2)
        Me.Panel4.TabIndex = 53
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Location = New System.Drawing.Point(7, 79)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(848, 2)
        Me.Panel3.TabIndex = 50
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
        'frmAgregarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgregarUsuarios"
        Me.Text = "frmNieto4"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblError As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombres As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtTelefono As TextBox
End Class
