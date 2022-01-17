<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditarProductos
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
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbBusquedad = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblActivos = New System.Windows.Forms.Label()
        Me.lblInactivos = New System.Windows.Forms.Label()
        Me.lblTodos = New System.Windows.Forms.Label()
        Me.lblActivos2 = New System.Windows.Forms.Label()
        Me.lblInactivos2 = New System.Windows.Forms.Label()
        Me.lblTodos2 = New System.Windows.Forms.Label()
        Me.cbListar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.gbListado = New System.Windows.Forms.GroupBox()
        Me.dgvListadoEditar = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbBusquedad.SuspendLayout()
        Me.gbListado.SuspendLayout()
        CType(Me.dgvListadoEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnEstado)
        Me.Panel2.Controls.Add(Me.lblError)
        Me.Panel2.Controls.Add(Me.btnActualizar)
        Me.Panel2.Location = New System.Drawing.Point(9, 515)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(906, 74)
        Me.Panel2.TabIndex = 6
        '
        'btnEstado
        '
        Me.btnEstado.BackColor = System.Drawing.Color.DarkCyan
        Me.btnEstado.FlatAppearance.BorderSize = 0
        Me.btnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstado.Location = New System.Drawing.Point(628, 24)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.Size = New System.Drawing.Size(108, 32)
        Me.btnEstado.TabIndex = 4
        Me.btnEstado.Text = "ESTADO"
        Me.btnEstado.UseVisualStyleBackColor = False
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(3, 14)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(619, 47)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.DarkCyan
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(747, 24)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(137, 32)
        Me.btnActualizar.TabIndex = 0
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.gbBusquedad)
        Me.Panel1.Controls.Add(Me.gbListado)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 488)
        Me.Panel1.TabIndex = 5
        '
        'gbBusquedad
        '
        Me.gbBusquedad.BackColor = System.Drawing.Color.White
        Me.gbBusquedad.Controls.Add(Me.btnBuscar)
        Me.gbBusquedad.Controls.Add(Me.lblActivos)
        Me.gbBusquedad.Controls.Add(Me.lblInactivos)
        Me.gbBusquedad.Controls.Add(Me.lblTodos)
        Me.gbBusquedad.Controls.Add(Me.lblActivos2)
        Me.gbBusquedad.Controls.Add(Me.lblInactivos2)
        Me.gbBusquedad.Controls.Add(Me.lblTodos2)
        Me.gbBusquedad.Controls.Add(Me.cbListar)
        Me.gbBusquedad.Controls.Add(Me.Label2)
        Me.gbBusquedad.Controls.Add(Me.Panel3)
        Me.gbBusquedad.Controls.Add(Me.lblNombre)
        Me.gbBusquedad.Controls.Add(Me.txtNombre)
        Me.gbBusquedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbBusquedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbBusquedad.ForeColor = System.Drawing.Color.Black
        Me.gbBusquedad.Location = New System.Drawing.Point(17, 16)
        Me.gbBusquedad.Name = "gbBusquedad"
        Me.gbBusquedad.Size = New System.Drawing.Size(867, 180)
        Me.gbBusquedad.TabIndex = 60
        Me.gbBusquedad.TabStop = False
        Me.gbBusquedad.Text = "BUSQUEDAD"
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
        'lblActivos2
        '
        Me.lblActivos2.AutoSize = True
        Me.lblActivos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivos2.ForeColor = System.Drawing.Color.Black
        Me.lblActivos2.Location = New System.Drawing.Point(687, 140)
        Me.lblActivos2.Name = "lblActivos2"
        Me.lblActivos2.Size = New System.Drawing.Size(80, 24)
        Me.lblActivos2.TabIndex = 55
        Me.lblActivos2.Text = "Activos: "
        '
        'lblInactivos2
        '
        Me.lblInactivos2.AutoSize = True
        Me.lblInactivos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactivos2.ForeColor = System.Drawing.Color.Black
        Me.lblInactivos2.Location = New System.Drawing.Point(524, 140)
        Me.lblInactivos2.Name = "lblInactivos2"
        Me.lblInactivos2.Size = New System.Drawing.Size(92, 24)
        Me.lblInactivos2.TabIndex = 54
        Me.lblInactivos2.Text = "Inactivos: "
        '
        'lblTodos2
        '
        Me.lblTodos2.AutoSize = True
        Me.lblTodos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodos2.ForeColor = System.Drawing.Color.Black
        Me.lblTodos2.Location = New System.Drawing.Point(371, 140)
        Me.lblTodos2.Name = "lblTodos2"
        Me.lblTodos2.Size = New System.Drawing.Size(74, 24)
        Me.lblTodos2.TabIndex = 53
        Me.lblTodos2.Text = "Todos: "
        '
        'cbListar
        '
        Me.cbListar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.cbListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbListar.ForeColor = System.Drawing.Color.Gray
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
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        'gbListado
        '
        Me.gbListado.BackColor = System.Drawing.Color.White
        Me.gbListado.Controls.Add(Me.dgvListadoEditar)
        Me.gbListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbListado.ForeColor = System.Drawing.Color.Black
        Me.gbListado.Location = New System.Drawing.Point(17, 202)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(867, 268)
        Me.gbListado.TabIndex = 54
        Me.gbListado.TabStop = False
        Me.gbListado.Text = "LISTADO DE PRODUCTOS"
        '
        'dgvListadoEditar
        '
        Me.dgvListadoEditar.AllowUserToDeleteRows = False
        Me.dgvListadoEditar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvListadoEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoEditar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.dgvListadoEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoEditar.GridColor = System.Drawing.Color.DarkCyan
        Me.dgvListadoEditar.Location = New System.Drawing.Point(11, 29)
        Me.dgvListadoEditar.Name = "dgvListadoEditar"
        Me.dgvListadoEditar.ReadOnly = True
        Me.dgvListadoEditar.Size = New System.Drawing.Size(841, 233)
        Me.dgvListadoEditar.TabIndex = 0
        '
        'frmEditarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditarProductos"
        Me.Text = "frmNieto3"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.gbBusquedad.ResumeLayout(False)
        Me.gbBusquedad.PerformLayout()
        Me.gbListado.ResumeLayout(False)
        CType(Me.dgvListadoEditar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblError As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gbBusquedad As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblActivos As Label
    Friend WithEvents lblInactivos As Label
    Friend WithEvents lblTodos As Label
    Friend WithEvents lblActivos2 As Label
    Friend WithEvents lblInactivos2 As Label
    Friend WithEvents lblTodos2 As Label
    Friend WithEvents cbListar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents gbListado As GroupBox
    Friend WithEvents dgvListadoEditar As DataGridView
    Friend WithEvents btnEstado As Button
End Class
