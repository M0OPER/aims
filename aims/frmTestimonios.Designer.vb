<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTestimonios
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
        Me.lblTitulo2 = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnTestimonio = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnEstado = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.lblTitulo3 = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo2
        '
        Me.lblTitulo2.AutoSize = True
        Me.lblTitulo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo2.Location = New System.Drawing.Point(787, 9)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Size = New System.Drawing.Size(150, 24)
        Me.lblTitulo2.TabIndex = 31
        Me.lblTitulo2.Text = "TESTIMONIOS"
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
        Me.btnRefrescar.TabIndex = 35
        Me.btnRefrescar.Text = "REFRESCAR"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.AutoScroll = True
        Me.panel2.BackColor = System.Drawing.Color.LightGray
        Me.panel2.Location = New System.Drawing.Point(9, 219)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(928, 423)
        Me.panel2.TabIndex = 34
        '
        'lblError
        '
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.Control
        Me.lblError.Location = New System.Drawing.Point(154, 4)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(638, 32)
        Me.lblError.TabIndex = 36
        Me.lblError.Text = "ERROR ::: ERRNO"
        '
        'panel1
        '
        Me.panel1.AutoScroll = True
        Me.panel1.Controls.Add(Me.txtNombre)
        Me.panel1.Controls.Add(Me.btnTestimonio)
        Me.panel1.Controls.Add(Me.lblTitulo)
        Me.panel1.Controls.Add(Me.txtTitulo)
        Me.panel1.Controls.Add(Me.lblFecha)
        Me.panel1.Controls.Add(Me.btnEstado)
        Me.panel1.Controls.Add(Me.lblMensaje)
        Me.panel1.Controls.Add(Me.txtTexto)
        Me.panel1.Controls.Add(Me.lblTitulo3)
        Me.panel1.Location = New System.Drawing.Point(9, 45)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(928, 168)
        Me.panel1.TabIndex = 37
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(3, 3)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(810, 20)
        Me.txtNombre.TabIndex = 0
        '
        'btnTestimonio
        '
        Me.btnTestimonio.Location = New System.Drawing.Point(819, 3)
        Me.btnTestimonio.Name = "btnTestimonio"
        Me.btnTestimonio.Size = New System.Drawing.Size(75, 23)
        Me.btnTestimonio.TabIndex = 1
        Me.btnTestimonio.Text = "Agregar"
        Me.btnTestimonio.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(3, 29)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(58, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "TITULO :  "
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(67, 32)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(100, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(173, 29)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(39, 13)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Label2"
        '
        'btnEstado
        '
        Me.btnEstado.Enabled = False
        Me.btnEstado.Location = New System.Drawing.Point(218, 32)
        Me.btnEstado.Name = "btnEstado"
        Me.btnEstado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnEstado.Size = New System.Drawing.Size(105, 23)
        Me.btnEstado.TabIndex = 5
        Me.btnEstado.Text = "No agregado"
        Me.btnEstado.UseVisualStyleBackColor = True
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(329, 29)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(57, 13)
        Me.lblMensaje.TabIndex = 6
        Me.lblMensaje.Text = "MENSAJE"
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(3, 61)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(915, 48)
        Me.txtTexto.TabIndex = 7
        '
        'lblTitulo3
        '
        Me.lblTitulo3.AutoSize = True
        Me.lblTitulo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitulo3.Location = New System.Drawing.Point(3, 112)
        Me.lblTitulo3.Name = "lblTitulo3"
        Me.lblTitulo3.Size = New System.Drawing.Size(291, 24)
        Me.lblTitulo3.TabIndex = 38
        Me.lblTitulo3.Text = "TESTIMONIO POR CLIENTES"
        '
        'frmTestimonios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.lblTitulo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTestimonios"
        Me.Text = "frmHijo5"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo2 As Label
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents panel2 As FlowLayoutPanel
    Friend WithEvents lblError As Label
    Friend WithEvents panel1 As FlowLayoutPanel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnTestimonio As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents btnEstado As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents txtTexto As TextBox
    Friend WithEvents lblTitulo3 As Label
End Class
