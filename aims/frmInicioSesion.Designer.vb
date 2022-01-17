<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioSesion))
        Me.pnlBarra = New System.Windows.Forms.Panel()
        Me.cbLenguaje = New System.Windows.Forms.ComboBox()
        Me.pbEstado = New System.Windows.Forms.PictureBox()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnMInimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.pnlInfo = New System.Windows.Forms.Panel()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.txtuno = New System.Windows.Forms.Button()
        Me.btnContrasena = New System.Windows.Forms.Button()
        Me.lblMostrar = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.btnReconectar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.pnlBarra.SuspendLayout()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBarra
        '
        Me.pnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.pnlBarra.Controls.Add(Me.cbLenguaje)
        Me.pnlBarra.Controls.Add(Me.pbEstado)
        Me.pnlBarra.Controls.Add(Me.lblEstado)
        Me.pnlBarra.Controls.Add(Me.btnMInimizar)
        Me.pnlBarra.Controls.Add(Me.btnCerrar)
        Me.pnlBarra.Controls.Add(Me.pbLogo)
        Me.pnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarra.Name = "pnlBarra"
        Me.pnlBarra.Size = New System.Drawing.Size(394, 30)
        Me.pnlBarra.TabIndex = 1
        '
        'cbLenguaje
        '
        Me.cbLenguaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbLenguaje.FormattingEnabled = True
        Me.cbLenguaje.Items.AddRange(New Object() {"Español[ES]", "English[EN]"})
        Me.cbLenguaje.Location = New System.Drawing.Point(144, 6)
        Me.cbLenguaje.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLenguaje.Name = "cbLenguaje"
        Me.cbLenguaje.Size = New System.Drawing.Size(92, 21)
        Me.cbLenguaje.TabIndex = 35
        Me.cbLenguaje.Text = "Español[ES]"
        '
        'pbEstado
        '
        Me.pbEstado.Cursor = System.Windows.Forms.Cursors.Help
        Me.pbEstado.Image = Global.aims.My.Resources.Resources.icons8_down_arrow_200
        Me.pbEstado.Location = New System.Drawing.Point(315, 6)
        Me.pbEstado.Name = "pbEstado"
        Me.pbEstado.Size = New System.Drawing.Size(22, 16)
        Me.pbEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEstado.TabIndex = 15
        Me.pbEstado.TabStop = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblEstado.Location = New System.Drawing.Point(240, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(74, 13)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.Text = "CONECTADO"
        '
        'btnMInimizar
        '
        Me.btnMInimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMInimizar.FlatAppearance.BorderSize = 0
        Me.btnMInimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMInimizar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMInimizar.Location = New System.Drawing.Point(333, 0)
        Me.btnMInimizar.Name = "btnMInimizar"
        Me.btnMInimizar.Size = New System.Drawing.Size(32, 31)
        Me.btnMInimizar.TabIndex = 4
        Me.btnMInimizar.Text = "----"
        Me.btnMInimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Location = New System.Drawing.Point(362, 0)
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
        'pnlInfo
        '
        Me.pnlInfo.BackColor = System.Drawing.Color.DarkSlateGray
        Me.pnlInfo.Controls.Add(Me.lblMensaje)
        Me.pnlInfo.Location = New System.Drawing.Point(137, 25)
        Me.pnlInfo.Name = "pnlInfo"
        Me.pnlInfo.Size = New System.Drawing.Size(200, 51)
        Me.pnlInfo.TabIndex = 14
        Me.pnlInfo.Visible = False
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
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(60, 151)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(277, 25)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Inicia sesión con tu Cuenta "
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Gray
        Me.txtUsuario.Location = New System.Drawing.Point(30, 194)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(335, 22)
        Me.txtUsuario.TabIndex = 16
        Me.txtUsuario.Text = "Usuario"
        '
        'txtContrasena
        '
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.Gray
        Me.txtContrasena.Location = New System.Drawing.Point(30, 256)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(273, 22)
        Me.txtContrasena.TabIndex = 17
        Me.txtContrasena.Text = "Contraseña"
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnInicioSesion.FlatAppearance.BorderSize = 0
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.SystemColors.Control
        Me.btnInicioSesion.Location = New System.Drawing.Point(65, 405)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(265, 31)
        Me.btnInicioSesion.TabIndex = 19
        Me.btnInicioSesion.Text = "Iniciar Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        '
        'txtuno
        '
        Me.txtuno.BackColor = System.Drawing.Color.Transparent
        Me.txtuno.Location = New System.Drawing.Point(22, 190)
        Me.txtuno.Name = "txtuno"
        Me.txtuno.Size = New System.Drawing.Size(350, 32)
        Me.txtuno.TabIndex = 20
        Me.txtuno.UseVisualStyleBackColor = False
        '
        'btnContrasena
        '
        Me.btnContrasena.BackColor = System.Drawing.Color.Transparent
        Me.btnContrasena.Location = New System.Drawing.Point(22, 251)
        Me.btnContrasena.Name = "btnContrasena"
        Me.btnContrasena.Size = New System.Drawing.Size(353, 32)
        Me.btnContrasena.TabIndex = 21
        Me.btnContrasena.UseVisualStyleBackColor = False
        '
        'lblMostrar
        '
        Me.lblMostrar.AutoSize = True
        Me.lblMostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMostrar.Location = New System.Drawing.Point(309, 261)
        Me.lblMostrar.Name = "lblMostrar"
        Me.lblMostrar.Size = New System.Drawing.Size(61, 13)
        Me.lblMostrar.TabIndex = 22
        Me.lblMostrar.Text = "MOSTRAR"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(2, 340)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(391, 48)
        Me.lblBienvenida.TabIndex = 23
        Me.lblBienvenida.Text = "   Bienvenido al sistema de informacion, si olvidó su contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "deberá contacta" &
    "r con un empleado desde el numero de telefono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                 " &
    "             775.359.8866"
        '
        'btnReconectar
        '
        Me.btnReconectar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnReconectar.FlatAppearance.BorderSize = 0
        Me.btnReconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReconectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReconectar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReconectar.Location = New System.Drawing.Point(270, 35)
        Me.btnReconectar.Name = "btnReconectar"
        Me.btnReconectar.Size = New System.Drawing.Size(119, 31)
        Me.btnReconectar.TabIndex = 24
        Me.btnReconectar.Text = "Reconectar"
        Me.btnReconectar.UseVisualStyleBackColor = False
        Me.btnReconectar.Visible = False
        '
        'lblError
        '
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(20, 293)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(350, 47)
        Me.lblError.TabIndex = 25
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.BackColor = System.Drawing.Color.Transparent
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblContrasena.Location = New System.Drawing.Point(27, 235)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(77, 16)
        Me.lblContrasena.TabIndex = 34
        Me.lblContrasena.Text = "Contraseña"
        Me.lblContrasena.Visible = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.lblUsuario.Location = New System.Drawing.Point(27, 175)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(55, 16)
        Me.lblUsuario.TabIndex = 33
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.Visible = False
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarse.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegistrarse.Location = New System.Drawing.Point(43, 443)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(313, 31)
        Me.btnRegistrarse.TabIndex = 35
        Me.btnRegistrarse.Text = "Registrarse Como Cliente"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        '
        'frmInicioSesion
        '
        Me.AcceptButton = Me.btnInicioSesion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 528)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnReconectar)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.lblMostrar)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.btnInicioSesion)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pnlInfo)
        Me.Controls.Add(Me.pnlBarra)
        Me.Controls.Add(Me.btnContrasena)
        Me.Controls.Add(Me.txtuno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInicioSesion"
        Me.pnlBarra.ResumeLayout(False)
        Me.pnlBarra.PerformLayout()
        CType(Me.pbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInfo.ResumeLayout(False)
        Me.pnlInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBarra As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnMInimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents pbEstado As PictureBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents lblMensaje As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents txtuno As Button
    Friend WithEvents btnContrasena As Button
    Friend WithEvents lblMostrar As Label
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents btnReconectar As Button
    Friend WithEvents lblError As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents cbLenguaje As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegistrarse As Button
End Class
