<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistros
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
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.gbListado = New System.Windows.Forms.GroupBox()
        Me.dgvListadoRegistros = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cbOrdenar = New System.Windows.Forms.ComboBox()
        Me.lblOrdenar = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.panel.SuspendLayout()
        Me.gbListado.SuspendLayout()
        CType(Me.dgvListadoRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Location = New System.Drawing.Point(13, 7)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(138, 32)
        Me.btnRefrescar.TabIndex = 38
        Me.btnRefrescar.Text = "REFRESCAR"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.Controls.Add(Me.gbListado)
        Me.panel.Location = New System.Drawing.Point(9, 91)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(928, 545)
        Me.panel.TabIndex = 37
        '
        'gbListado
        '
        Me.gbListado.BackColor = System.Drawing.Color.White
        Me.gbListado.Controls.Add(Me.dgvListadoRegistros)
        Me.gbListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbListado.ForeColor = System.Drawing.Color.Black
        Me.gbListado.Location = New System.Drawing.Point(3, 3)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(924, 522)
        Me.gbListado.TabIndex = 55
        Me.gbListado.TabStop = False
        Me.gbListado.Text = "LISTADO DE REGISTROS"
        '
        'dgvListadoRegistros
        '
        Me.dgvListadoRegistros.AllowUserToDeleteRows = False
        Me.dgvListadoRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvListadoRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRegistros.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListadoRegistros.Location = New System.Drawing.Point(6, 29)
        Me.dgvListadoRegistros.Name = "dgvListadoRegistros"
        Me.dgvListadoRegistros.ReadOnly = True
        Me.dgvListadoRegistros.Size = New System.Drawing.Size(912, 487)
        Me.dgvListadoRegistros.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo.Location = New System.Drawing.Point(787, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(127, 24)
        Me.lblTitulo.TabIndex = 36
        Me.lblTitulo.Text = "REGISTROS"
        '
        'cbOrdenar
        '
        Me.cbOrdenar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cbOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrdenar.ForeColor = System.Drawing.Color.Gray
        Me.cbOrdenar.FormattingEnabled = True
        Me.cbOrdenar.Items.AddRange(New Object() {"--Seleccionar--", "Productos", "Testimonios", "Usuarios"})
        Me.cbOrdenar.Location = New System.Drawing.Point(170, 49)
        Me.cbOrdenar.Name = "cbOrdenar"
        Me.cbOrdenar.Size = New System.Drawing.Size(687, 28)
        Me.cbOrdenar.TabIndex = 60
        Me.cbOrdenar.Text = "--Seleccionar--"
        '
        'lblOrdenar
        '
        Me.lblOrdenar.AutoSize = True
        Me.lblOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenar.ForeColor = System.Drawing.Color.Black
        Me.lblOrdenar.Location = New System.Drawing.Point(12, 53)
        Me.lblOrdenar.Name = "lblOrdenar"
        Me.lblOrdenar.Size = New System.Drawing.Size(118, 24)
        Me.lblOrdenar.TabIndex = 59
        Me.lblOrdenar.Text = "Ordenar por:"
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(166, 7)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(619, 32)
        Me.lblError.TabIndex = 61
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'frmRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.cbOrdenar)
        Me.Controls.Add(Me.lblOrdenar)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistros"
        Me.Text = "frmHijo6"
        Me.panel.ResumeLayout(False)
        Me.gbListado.ResumeLayout(False)
        CType(Me.dgvListadoRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRefrescar As Button
    Friend WithEvents panel As FlowLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents gbListado As GroupBox
    Friend WithEvents dgvListadoRegistros As DataGridView
    Friend WithEvents cbOrdenar As ComboBox
    Friend WithEvents lblOrdenar As Label
    Friend WithEvents lblError As Label
End Class
