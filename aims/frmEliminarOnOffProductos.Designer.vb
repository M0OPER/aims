<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEliminarOnOffProductos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEstado = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblActivos = New System.Windows.Forms.Label()
        Me.lblInactivos = New System.Windows.Forms.Label()
        Me.lblTodos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbListar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListadoEliminar = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListadoEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnEstado)
        Me.Panel2.Controls.Add(Me.btnVer)
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Location = New System.Drawing.Point(9, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 74)
        Me.Panel2.TabIndex = 4
        '
        'btnEstado
        '
        Me.btnEstado.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEstado.FlatAppearance.BorderSize = 0
        Me.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstado.Location = New System.Drawing.Point(514, 24)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Size = New System.Drawing.Size(108, 32)
        Me.btnEstado.TabIndex = 2
        Me.btnEstado.Text = "ESTADO"
        Me.btnEstado.UseVisualStyleBackColor = False
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.DarkCyan
        Me.btnVer.FlatAppearance.BorderSize = 0
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.Location = New System.Drawing.Point(648, 24)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(108, 32)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "VER"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(3, 14)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(482, 47)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(774, 24)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 32)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 488)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.lblActivos)
        Me.GroupBox2.Controls.Add(Me.lblInactivos)
        Me.GroupBox2.Controls.Add(Me.lblTodos)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbListar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(867, 180)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSQUEDAD"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(730, 41)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(108, 32)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblActivos
        '
        Me.lblActivos.AutoSize = True
        Me.lblActivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivos.ForeColor = System.Drawing.Color.Black
        Me.lblActivos.Location = New System.Drawing.Point(764, 140)
        Me.lblActivos.Name = "lblActivos"
        Me.lblActivos.Size = New System.Drawing.Size(74, 24)
        Me.lblActivos.TabIndex = 58
        Me.lblActivos.Text = "Todos: "
        '
        'lblInactivos
        '
        Me.lblInactivos.AutoSize = True
        Me.lblInactivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactivos.ForeColor = System.Drawing.Color.Black
        Me.lblInactivos.Location = New System.Drawing.Point(607, 140)
        Me.lblInactivos.Name = "lblInactivos"
        Me.lblInactivos.Size = New System.Drawing.Size(74, 24)
        Me.lblInactivos.TabIndex = 57
        Me.lblInactivos.Text = "Todos: "
        '
        'lblTodos
        '
        Me.lblTodos.AutoSize = True
        Me.lblTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodos.ForeColor = System.Drawing.Color.Black
        Me.lblTodos.Location = New System.Drawing.Point(444, 140)
        Me.lblTodos.Name = "lblTodos"
        Me.lblTodos.Size = New System.Drawing.Size(74, 24)
        Me.lblTodos.TabIndex = 56
        Me.lblTodos.Text = "Todos: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(687, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 24)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Activos: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(524, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 24)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Inactivos: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(371, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 24)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Todos: "
        '
        'cbListar
        '
        Me.cbListar.FormattingEnabled = True
        Me.cbListar.Items.AddRange(New Object() {"Todos", "Activos", "Inactivos"})
        Me.cbListar.Location = New System.Drawing.Point(68, 86)
        Me.cbListar.Name = "cbListar"
        Me.cbListar.Size = New System.Drawing.Size(784, 32)
        Me.cbListar.TabIndex = 52
        Me.cbListar.Text = "Todos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 24)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Por: "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel3.Location = New System.Drawing.Point(8, 64)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(678, 2)
        Me.Panel3.TabIndex = 50
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.DarkCyan
        Me.lblNombre.Location = New System.Drawing.Point(8, 30)
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
        Me.txtNombre.Location = New System.Drawing.Point(7, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(681, 22)
        Me.txtNombre.TabIndex = 48
        Me.txtNombre.Text = "Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dgvListadoEliminar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(17, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 268)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LISTADO DE PRODUCTOS"
        '
        'dgvListadoEliminar
        '
        Me.dgvListadoEliminar.AllowUserToDeleteRows = False
        Me.dgvListadoEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoEliminar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvListadoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoEliminar.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListadoEliminar.Location = New System.Drawing.Point(11, 29)
        Me.dgvListadoEliminar.Name = "dgvListadoEliminar"
        Me.dgvListadoEliminar.ReadOnly = True
        Me.dgvListadoEliminar.Size = New System.Drawing.Size(841, 233)
        Me.dgvListadoEliminar.TabIndex = 0
        '
        'frmEliminarOnOffProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEliminarOnOffProductos"
        Me.Text = "frmNieto2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListadoEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblActivos As System.Windows.Forms.Label
    Friend WithEvents lblInactivos As System.Windows.Forms.Label
    Friend WithEvents lblTodos As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbListar As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvListadoEliminar As DataGridView
    Friend WithEvents btnEstado As Button
    Friend WithEvents btnVer As Button
End Class
