<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarProductos
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
        Me.gbDatos2 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblAhora = New System.Windows.Forms.Label()
        Me.txtAhora = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblAntes = New System.Windows.Forms.Label()
        Me.txtAntes = New System.Windows.Forms.TextBox()
        Me.gbDatos1 = New System.Windows.Forms.GroupBox()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.gbDatos2.SuspendLayout()
        Me.gbDatos1.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Location = New System.Drawing.Point(7, 514)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 74)
        Me.Panel2.TabIndex = 2
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
        'gbDatos2
        '
        Me.gbDatos2.BackColor = System.Drawing.Color.White
        Me.gbDatos2.Controls.Add(Me.Panel5)
        Me.gbDatos2.Controls.Add(Me.lblAhora)
        Me.gbDatos2.Controls.Add(Me.txtAhora)
        Me.gbDatos2.Controls.Add(Me.Panel4)
        Me.gbDatos2.Controls.Add(Me.lblAntes)
        Me.gbDatos2.Controls.Add(Me.txtAntes)
        Me.gbDatos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDatos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos2.ForeColor = System.Drawing.Color.Black
        Me.gbDatos2.Location = New System.Drawing.Point(17, 266)
        Me.gbDatos2.Name = "gbDatos2"
        Me.gbDatos2.Size = New System.Drawing.Size(867, 204)
        Me.gbDatos2.TabIndex = 54
        Me.gbDatos2.TabStop = False
        Me.gbDatos2.Text = "PRECIOS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.ForeColor = System.Drawing.Color.Lime
        Me.Panel5.Location = New System.Drawing.Point(7, 167)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(848, 2)
        Me.Panel5.TabIndex = 59
        '
        'lblAhora
        '
        Me.lblAhora.AutoSize = True
        Me.lblAhora.BackColor = System.Drawing.Color.Transparent
        Me.lblAhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAhora.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblAhora.Location = New System.Drawing.Point(8, 133)
        Me.lblAhora.Name = "lblAhora"
        Me.lblAhora.Size = New System.Drawing.Size(44, 16)
        Me.lblAhora.TabIndex = 58
        Me.lblAhora.Text = "Ahora"
        Me.lblAhora.Visible = False
        '
        'txtAhora
        '
        Me.txtAhora.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtAhora.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAhora.ForeColor = System.Drawing.Color.Gray
        Me.txtAhora.Location = New System.Drawing.Point(7, 147)
        Me.txtAhora.Name = "txtAhora"
        Me.txtAhora.Size = New System.Drawing.Size(845, 22)
        Me.txtAhora.TabIndex = 57
        Me.txtAhora.Text = "Ahora"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel4.Location = New System.Drawing.Point(6, 78)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(848, 2)
        Me.Panel4.TabIndex = 56
        '
        'lblAntes
        '
        Me.lblAntes.AutoSize = True
        Me.lblAntes.BackColor = System.Drawing.Color.Transparent
        Me.lblAntes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAntes.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblAntes.Location = New System.Drawing.Point(7, 44)
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
        Me.txtAntes.Location = New System.Drawing.Point(6, 58)
        Me.txtAntes.Name = "txtAntes"
        Me.txtAntes.Size = New System.Drawing.Size(847, 22)
        Me.txtAntes.TabIndex = 54
        Me.txtAntes.Text = "Antes"
        '
        'gbDatos1
        '
        Me.gbDatos1.BackColor = System.Drawing.Color.White
        Me.gbDatos1.Controls.Add(Me.pbImagen)
        Me.gbDatos1.Controls.Add(Me.btnImagen)
        Me.gbDatos1.Controls.Add(Me.txtRuta)
        Me.gbDatos1.Controls.Add(Me.lblImagen)
        Me.gbDatos1.Controls.Add(Me.Panel3)
        Me.gbDatos1.Controls.Add(Me.lblNombre)
        Me.gbDatos1.Controls.Add(Me.txtNombre)
        Me.gbDatos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbDatos1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos1.ForeColor = System.Drawing.Color.Black
        Me.gbDatos1.Location = New System.Drawing.Point(17, 16)
        Me.gbDatos1.Name = "gbDatos1"
        Me.gbDatos1.Size = New System.Drawing.Size(867, 228)
        Me.gbDatos1.TabIndex = 60
        Me.gbDatos1.TabStop = False
        Me.gbDatos1.Text = "NOMBRE E IMAGEN"
        '
        'pbImagen
        '
        Me.pbImagen.Image = Global.aims.My.Resources.Resources.pro
        Me.pbImagen.Location = New System.Drawing.Point(689, 87)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(172, 135)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 54
        Me.pbImagen.TabStop = False
        '
        'btnImagen
        '
        Me.btnImagen.BackColor = System.Drawing.Color.DarkCyan
        Me.btnImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImagen.FlatAppearance.BorderSize = 0
        Me.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImagen.Image = Global.aims.My.Resources.Resources.icons8_upload_to_cloud_30
        Me.btnImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImagen.Location = New System.Drawing.Point(536, 179)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(147, 36)
        Me.btnImagen.TabIndex = 53
        Me.btnImagen.Text = "Subir Imagen"
        Me.btnImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImagen.UseVisualStyleBackColor = False
        '
        'txtRuta
        '
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(100, 137)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(583, 29)
        Me.txtRuta.TabIndex = 52
        Me.txtRuta.Text = "ruta://"
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagen.ForeColor = System.Drawing.Color.Black
        Me.lblImagen.Location = New System.Drawing.Point(7, 137)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(73, 24)
        Me.lblImagen.TabIndex = 51
        Me.lblImagen.Text = "Imagen"
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
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblNombre.Location = New System.Drawing.Point(8, 45)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 16)
        Me.lblNombre.TabIndex = 49
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Gray
        Me.txtNombre.Location = New System.Drawing.Point(7, 59)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(845, 22)
        Me.txtNombre.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.gbDatos1)
        Me.Panel1.Controls.Add(Me.gbDatos2)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 488)
        Me.Panel1.TabIndex = 1
        '
        'frmAgregarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(925, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAgregarProductos"
        Me.Text = "frmNieto1"
        Me.Panel2.ResumeLayout(False)
        Me.gbDatos2.ResumeLayout(False)
        Me.gbDatos2.PerformLayout()
        Me.gbDatos1.ResumeLayout(False)
        Me.gbDatos1.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblError As Label
    Friend WithEvents gbDatos2 As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblAhora As Label
    Friend WithEvents txtAhora As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAntes As Label
    Friend WithEvents txtAntes As TextBox
    Friend WithEvents gbDatos1 As GroupBox
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnImagen As Button
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents lblImagen As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel1 As Panel
End Class
