<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoArticulos
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.gbStock = New System.Windows.Forms.GroupBox()
        Me.pbStock = New System.Windows.Forms.PictureBox()
        Me.dgvListadoStock = New System.Windows.Forms.DataGridView()
        Me.gbTerminados = New System.Windows.Forms.GroupBox()
        Me.pbTerminados = New System.Windows.Forms.PictureBox()
        Me.dgvListadoTerminados = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblTerminados = New System.Windows.Forms.Label()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.gbStock.SuspendLayout()
        CType(Me.pbStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTerminados.SuspendLayout()
        CType(Me.pbTerminados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoTerminados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(810, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(124, 24)
        Me.lblTitulo.TabIndex = 37
        Me.lblTitulo.Text = "ARTICULOS"
        '
        'gbStock
        '
        Me.gbStock.BackColor = System.Drawing.Color.White
        Me.gbStock.Controls.Add(Me.pbStock)
        Me.gbStock.Controls.Add(Me.dgvListadoStock)
        Me.gbStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbStock.ForeColor = System.Drawing.Color.Black
        Me.gbStock.Location = New System.Drawing.Point(12, 63)
        Me.gbStock.Name = "gbStock"
        Me.gbStock.Size = New System.Drawing.Size(924, 261)
        Me.gbStock.TabIndex = 56
        Me.gbStock.TabStop = False
        Me.gbStock.Text = "ARTICULOS EN STOCK:"
        '
        'pbStock
        '
        Me.pbStock.Location = New System.Drawing.Point(565, 28)
        Me.pbStock.Name = "pbStock"
        Me.pbStock.Size = New System.Drawing.Size(337, 226)
        Me.pbStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStock.TabIndex = 1
        Me.pbStock.TabStop = False
        '
        'dgvListadoStock
        '
        Me.dgvListadoStock.AllowUserToDeleteRows = False
        Me.dgvListadoStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvListadoStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoStock.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListadoStock.Location = New System.Drawing.Point(7, 28)
        Me.dgvListadoStock.Name = "dgvListadoStock"
        Me.dgvListadoStock.ReadOnly = True
        Me.dgvListadoStock.Size = New System.Drawing.Size(537, 226)
        Me.dgvListadoStock.TabIndex = 0
        '
        'gbTerminados
        '
        Me.gbTerminados.BackColor = System.Drawing.Color.White
        Me.gbTerminados.Controls.Add(Me.pbTerminados)
        Me.gbTerminados.Controls.Add(Me.dgvListadoTerminados)
        Me.gbTerminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbTerminados.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTerminados.ForeColor = System.Drawing.Color.Black
        Me.gbTerminados.Location = New System.Drawing.Point(13, 344)
        Me.gbTerminados.Name = "gbTerminados"
        Me.gbTerminados.Size = New System.Drawing.Size(924, 271)
        Me.gbTerminados.TabIndex = 57
        Me.gbTerminados.TabStop = False
        Me.gbTerminados.Text = "ARTICULOS TERMINADOS:"
        '
        'pbTerminados
        '
        Me.pbTerminados.Location = New System.Drawing.Point(564, 28)
        Me.pbTerminados.Name = "pbTerminados"
        Me.pbTerminados.Size = New System.Drawing.Size(337, 226)
        Me.pbTerminados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTerminados.TabIndex = 2
        Me.pbTerminados.TabStop = False
        '
        'dgvListadoTerminados
        '
        Me.dgvListadoTerminados.AllowUserToDeleteRows = False
        Me.dgvListadoTerminados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoTerminados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvListadoTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoTerminados.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListadoTerminados.Location = New System.Drawing.Point(6, 29)
        Me.dgvListadoTerminados.Name = "dgvListadoTerminados"
        Me.dgvListadoTerminados.ReadOnly = True
        Me.dgvListadoTerminados.Size = New System.Drawing.Size(537, 236)
        Me.dgvListadoTerminados.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.Location = New System.Drawing.Point(24, 36)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(910, 2)
        Me.Panel5.TabIndex = 58
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(14, 618)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(920, 22)
        Me.lblError.TabIndex = 1
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(511, 44)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(45, 13)
        Me.lblStock.TabIndex = 59
        Me.lblStock.Text = "TOTAL:"
        '
        'lblTerminados
        '
        Me.lblTerminados.AutoSize = True
        Me.lblTerminados.Location = New System.Drawing.Point(511, 328)
        Me.lblTerminados.Name = "lblTerminados"
        Me.lblTerminados.Size = New System.Drawing.Size(45, 13)
        Me.lblTerminados.TabIndex = 60
        Me.lblTerminados.Text = "TOTAL:"
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(24, 9)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(278, 20)
        Me.lblTexto.TabIndex = 61
        Me.lblTexto.Text = "Seleccione un articulo para ver su foto"
        '
        'frmListadoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.lblTerminados)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.gbTerminados)
        Me.Controls.Add(Me.gbStock)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListadoArticulos"
        Me.Text = "frmListadoArticulos"
        Me.gbStock.ResumeLayout(False)
        CType(Me.pbStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTerminados.ResumeLayout(False)
        CType(Me.pbTerminados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoTerminados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbStock As GroupBox
    Friend WithEvents dgvListadoStock As DataGridView
    Friend WithEvents gbTerminados As GroupBox
    Friend WithEvents dgvListadoTerminados As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblError As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblTerminados As Label
    Friend WithEvents pbStock As PictureBox
    Friend WithEvents pbTerminados As PictureBox
    Friend WithEvents lblTexto As Label
End Class
