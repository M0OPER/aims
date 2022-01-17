<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
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
        Me.itemEditar = New System.Windows.Forms.Panel()
        Me.itemEliminar = New System.Windows.Forms.Panel()
        Me.lblEditar = New System.Windows.Forms.Label()
        Me.lblEliminar = New System.Windows.Forms.Label()
        Me.itemAgregar = New System.Windows.Forms.Panel()
        Me.lblAgregar = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'itemEditar
        '
        Me.itemEditar.BackColor = System.Drawing.Color.DarkCyan
        Me.itemEditar.Location = New System.Drawing.Point(323, 29)
        Me.itemEditar.Name = "itemEditar"
        Me.itemEditar.Size = New System.Drawing.Size(133, 4)
        Me.itemEditar.TabIndex = 26
        Me.itemEditar.Visible = False
        '
        'itemEliminar
        '
        Me.itemEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.itemEliminar.Location = New System.Drawing.Point(169, 29)
        Me.itemEliminar.Name = "itemEliminar"
        Me.itemEliminar.Size = New System.Drawing.Size(142, 4)
        Me.itemEliminar.TabIndex = 25
        Me.itemEliminar.Visible = False
        '
        'lblEditar
        '
        Me.lblEditar.AutoSize = True
        Me.lblEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblEditar.Location = New System.Drawing.Point(322, 10)
        Me.lblEditar.Name = "lblEditar"
        Me.lblEditar.Size = New System.Drawing.Size(134, 13)
        Me.lblEditar.TabIndex = 29
        Me.lblEditar.Text = "EDITAR PRODUCTOS"
        '
        'lblEliminar
        '
        Me.lblEliminar.AutoSize = True
        Me.lblEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEliminar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblEliminar.Location = New System.Drawing.Point(167, 10)
        Me.lblEliminar.Name = "lblEliminar"
        Me.lblEliminar.Size = New System.Drawing.Size(147, 13)
        Me.lblEliminar.TabIndex = 28
        Me.lblEliminar.Text = "ELIMINAR PRODUCTOS"
        '
        'itemAgregar
        '
        Me.itemAgregar.BackColor = System.Drawing.Color.DarkCyan
        Me.itemAgregar.Location = New System.Drawing.Point(23, 29)
        Me.itemAgregar.Name = "itemAgregar"
        Me.itemAgregar.Size = New System.Drawing.Size(134, 4)
        Me.itemAgregar.TabIndex = 24
        '
        'lblAgregar
        '
        Me.lblAgregar.AutoSize = True
        Me.lblAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregar.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblAgregar.Location = New System.Drawing.Point(20, 10)
        Me.lblAgregar.Name = "lblAgregar"
        Me.lblAgregar.Size = New System.Drawing.Size(140, 13)
        Me.lblAgregar.TabIndex = 27
        Me.lblAgregar.Text = "AGREGAR PRODUCTO"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.Location = New System.Drawing.Point(23, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(910, 2)
        Me.Panel5.TabIndex = 23
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Location = New System.Drawing.Point(12, 40)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(925, 596)
        Me.pnlContenedor.TabIndex = 30
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(796, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(137, 24)
        Me.lblTitulo.TabIndex = 31
        Me.lblTitulo.Text = "PRODUCTOS"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.itemEditar)
        Me.Controls.Add(Me.itemEliminar)
        Me.Controls.Add(Me.lblEditar)
        Me.Controls.Add(Me.lblEliminar)
        Me.Controls.Add(Me.itemAgregar)
        Me.Controls.Add(Me.lblAgregar)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmProductos"
        Me.Text = "frmHijo3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents itemEditar As System.Windows.Forms.Panel
    Friend WithEvents itemEliminar As System.Windows.Forms.Panel
    Friend WithEvents lblEditar As System.Windows.Forms.Label
    Friend WithEvents lblEliminar As System.Windows.Forms.Label
    Friend WithEvents itemAgregar As System.Windows.Forms.Panel
    Friend WithEvents lblAgregar As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblTitulo As Label
End Class
