<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.itemEliminar = New System.Windows.Forms.Panel()
        Me.lblEliminar = New System.Windows.Forms.Label()
        Me.itemAgregar = New System.Windows.Forms.Panel()
        Me.lblAgregar = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(12, 41)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(925, 596)
        Me.pnlContenedor.TabIndex = 38
        '
        'itemEliminar
        '
        Me.itemEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.itemEliminar.Location = New System.Drawing.Point(169, 30)
        Me.itemEliminar.Name = "itemEliminar"
        Me.itemEliminar.Size = New System.Drawing.Size(190, 4)
        Me.itemEliminar.TabIndex = 33
        Me.itemEliminar.Visible = False
        '
        'lblEliminar
        '
        Me.lblEliminar.AutoSize = True
        Me.lblEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblEliminar.Location = New System.Drawing.Point(167, 11)
        Me.lblEliminar.Name = "lblEliminar"
        Me.lblEliminar.Size = New System.Drawing.Size(196, 13)
        Me.lblEliminar.TabIndex = 36
        Me.lblEliminar.Text = "EDITAR Y ELIMINAR USUARIOS"
        '
        'itemAgregar
        '
        Me.itemAgregar.BackColor = System.Drawing.Color.DarkCyan
        Me.itemAgregar.Location = New System.Drawing.Point(23, 30)
        Me.itemAgregar.Name = "itemAgregar"
        Me.itemAgregar.Size = New System.Drawing.Size(134, 4)
        Me.itemAgregar.TabIndex = 32
        '
        'lblAgregar
        '
        Me.lblAgregar.AutoSize = True
        Me.lblAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblAgregar.Location = New System.Drawing.Point(20, 11)
        Me.lblAgregar.Name = "lblAgregar"
        Me.lblAgregar.Size = New System.Drawing.Size(127, 13)
        Me.lblAgregar.TabIndex = 35
        Me.lblAgregar.Text = "AGREGAR USUARIO"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.Location = New System.Drawing.Point(23, 33)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(910, 2)
        Me.Panel5.TabIndex = 31
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(820, 6)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(113, 24)
        Me.lblTitulo.TabIndex = 30
        Me.lblTitulo.Text = "USUARIOS"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.itemEliminar)
        Me.Controls.Add(Me.lblEliminar)
        Me.Controls.Add(Me.itemAgregar)
        Me.Controls.Add(Me.lblAgregar)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuarios"
        Me.Text = "frmHijo4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents itemEliminar As Panel
    Friend WithEvents lblEliminar As Label
    Friend WithEvents itemAgregar As Panel
    Friend WithEvents lblAgregar As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblTitulo As Label
End Class
