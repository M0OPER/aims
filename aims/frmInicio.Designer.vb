<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblTItulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.aims.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(108, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(720, 367)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagina.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPagina.Location = New System.Drawing.Point(608, 606)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(150, 24)
        Me.lblPagina.TabIndex = 33
        Me.lblPagina.Text = "PAGINA WEB: "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(764, 610)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(173, 20)
        Me.LinkLabel1.TabIndex = 34
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "www.aimsmachine.com"
        '
        'lblTItulo
        '
        Me.lblTItulo.AutoSize = True
        Me.lblTItulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTItulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTItulo.Location = New System.Drawing.Point(751, 9)
        Me.lblTItulo.Name = "lblTItulo"
        Me.lblTItulo.Size = New System.Drawing.Size(186, 24)
        Me.lblTItulo.TabIndex = 35
        Me.lblTItulo.Text = "PAGINA DE INICIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(74, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 42)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "AIMS MACHINE"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 648)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTItulo)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblPagina)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicio"
        Me.Text = "frmHijo1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPagina As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblTItulo As Label
    Friend WithEvents Label2 As Label
End Class
