<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTienda
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(800, 6)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(137, 24)
        Me.lblTitulo.TabIndex = 32
        Me.lblTitulo.Text = "PRODUCTOS"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Location = New System.Drawing.Point(12, 1)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(138, 32)
        Me.btnRefrescar.TabIndex = 33
        Me.btnRefrescar.Text = "REFRESCAR"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(159, 1)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(638, 32)
        Me.lblError.TabIndex = 1
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.Location = New System.Drawing.Point(9, 33)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(928, 603)
        Me.panel.TabIndex = 0
        '
        'frmTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 640)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTienda"
        Me.Text = "frmHijo2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents lblError As Label
    Friend WithEvents panel As System.Windows.Forms.FlowLayoutPanel
End Class
