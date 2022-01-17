<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAhora = New System.Windows.Forms.Label()
        Me.txtAhora = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAntes = New System.Windows.Forms.Label()
        Me.txtAntes = New System.Windows.Forms.TextBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnSubir = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblTitulo)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 30)
        Me.Panel1.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTitulo.Location = New System.Drawing.Point(104, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(167, 18)
        Me.lblTitulo.TabIndex = 65
        Me.lblTitulo.Text = "EDITAR PRODUCTO"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(362, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(791, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONECTADO"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(243, 490)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "GUARDAR"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.Location = New System.Drawing.Point(82, 490)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(137, 32)
        Me.btnAtras.TabIndex = 4
        Me.btnAtras.Text = "ATRAS"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Location = New System.Drawing.Point(14, 76)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(361, 2)
        Me.Panel3.TabIndex = 53
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblNombre.Location = New System.Drawing.Point(14, 42)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 52
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Gray
        Me.txtNombre.Location = New System.Drawing.Point(13, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(364, 22)
        Me.txtNombre.TabIndex = 51
        Me.txtNombre.Text = "Nombre"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Location = New System.Drawing.Point(13, 441)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 2)
        Me.Panel2.TabIndex = 56
        '
        'lblAhora
        '
        Me.lblAhora.AutoSize = True
        Me.lblAhora.BackColor = System.Drawing.Color.Transparent
        Me.lblAhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAhora.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblAhora.Location = New System.Drawing.Point(13, 407)
        Me.lblAhora.Name = "lblAhora"
        Me.lblAhora.Size = New System.Drawing.Size(44, 16)
        Me.lblAhora.TabIndex = 55
        Me.lblAhora.Text = "Ahora"
        Me.lblAhora.Visible = False
        '
        'txtAhora
        '
        Me.txtAhora.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtAhora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAhora.ForeColor = System.Drawing.Color.Gray
        Me.txtAhora.Location = New System.Drawing.Point(12, 421)
        Me.txtAhora.Name = "txtAhora"
        Me.txtAhora.Size = New System.Drawing.Size(364, 22)
        Me.txtAhora.TabIndex = 54
        Me.txtAhora.Text = "Ahora"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Location = New System.Drawing.Point(12, 388)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(361, 2)
        Me.Panel4.TabIndex = 56
        '
        'lblAntes
        '
        Me.lblAntes.AutoSize = True
        Me.lblAntes.BackColor = System.Drawing.Color.Transparent
        Me.lblAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntes.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblAntes.Location = New System.Drawing.Point(12, 354)
        Me.lblAntes.Name = "lblAntes"
        Me.lblAntes.Size = New System.Drawing.Size(42, 16)
        Me.lblAntes.TabIndex = 55
        Me.lblAntes.Text = "Antes"
        Me.lblAntes.Visible = False
        '
        'txtAntes
        '
        Me.txtAntes.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtAntes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAntes.ForeColor = System.Drawing.Color.Gray
        Me.txtAntes.Location = New System.Drawing.Point(11, 368)
        Me.txtAntes.Name = "txtAntes"
        Me.txtAntes.Size = New System.Drawing.Size(364, 22)
        Me.txtAntes.TabIndex = 54
        Me.txtAntes.Text = "Antes"
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagen.ForeColor = System.Drawing.Color.Black
        Me.lblImagen.Location = New System.Drawing.Point(13, 90)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(73, 24)
        Me.lblImagen.TabIndex = 57
        Me.lblImagen.Text = "Imagen"
        '
        'pbImagen
        '
        Me.pbImagen.Image = Global.aims.My.Resources.Resources.pro
        Me.pbImagen.Location = New System.Drawing.Point(82, 117)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(235, 192)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 58
        Me.pbImagen.TabStop = False
        '
        'btnSubir
        '
        Me.btnSubir.BackColor = System.Drawing.Color.DarkCyan
        Me.btnSubir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubir.FlatAppearance.BorderSize = 0
        Me.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubir.Image = Global.aims.My.Resources.Resources.icons8_upload_to_cloud_30
        Me.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubir.Location = New System.Drawing.Point(233, 315)
        Me.btnSubir.Name = "btnSubir"
        Me.btnSubir.Size = New System.Drawing.Size(147, 36)
        Me.btnSubir.TabIndex = 61
        Me.btnSubir.Text = "Subir Imagen"
        Me.btnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubir.UseVisualStyleBackColor = False
        '
        'txtRuta
        '
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(11, 317)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(216, 29)
        Me.txtRuta.TabIndex = 60
        Me.txtRuta.Text = "ruta://"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Red
        Me.lblId.Location = New System.Drawing.Point(359, 90)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 20)
        Me.lblId.TabIndex = 63
        Me.lblId.Text = "0"
        Me.lblId.Visible = False
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(12, 446)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(368, 41)
        Me.lblError.TabIndex = 64
        '
        'frmEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 534)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSubir)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.lblImagen)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lblAntes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtAntes)
        Me.Controls.Add(Me.lblAhora)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtAhora)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditar"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAhora As Label
    Friend WithEvents txtAhora As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAntes As Label
    Friend WithEvents txtAntes As TextBox
    Friend WithEvents lblImagen As Label
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnSubir As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblError As Label
    Friend WithEvents lblTitulo As Label
End Class
