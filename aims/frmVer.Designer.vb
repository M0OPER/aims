<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVer
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
        Me.btnVer = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.DarkCyan
        Me.btnVer.FlatAppearance.BorderSize = 0
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.Location = New System.Drawing.Point(85, 507)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(477, 22)
        Me.btnVer.TabIndex = 2
        Me.btnVer.Text = "REGRESAR"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'pbImagen
        '
        Me.pbImagen.Image = Global.aims.My.Resources.Resources.pro
        Me.pbImagen.Location = New System.Drawing.Point(2, 2)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(652, 502)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 0
        Me.pbImagen.TabStop = False
        '
        'frmVer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 531)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.pbImagen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVer"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnVer As Button
End Class
