Public Class frmUsuarios
    Private Sub frmHijo4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAgregarUsuarios.TopLevel = False
        frmAgregarUsuarios.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmAgregarUsuarios)
        frmAgregarUsuarios.Show()
        lblAgregar.Enabled = False
    End Sub

    Private Sub lblEliminar_Click(sender As Object, e As EventArgs) Handles lblEliminar.Click
        lblEliminar.Enabled = False
        lblAgregar.Enabled = True
        pnlContenedor.Controls.Clear()
        frmEditarEliminarUsuarios.TopLevel = False
        frmEditarEliminarUsuarios.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmEditarEliminarUsuarios)
        frmEditarEliminarUsuarios.Show()
        itemEliminar.Visible = True
        itemAgregar.Visible = False
    End Sub

    Private Sub lblAgregar_Click(sender As Object, e As EventArgs) Handles lblAgregar.Click
        lblEliminar.Enabled = True
        lblAgregar.Enabled = False
        pnlContenedor.Controls.Clear()
        frmAgregarUsuarios.TopLevel = False
        frmAgregarUsuarios.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmAgregarUsuarios)
        frmAgregarUsuarios.Show()
        itemEliminar.Visible = False
        itemAgregar.Visible = True
    End Sub
End Class