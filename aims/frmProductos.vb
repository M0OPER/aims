Public Class frmProductos
    Private Sub frmHijo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmAgregarProductos.TopLevel = False
        frmAgregarProductos.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmAgregarProductos)
        frmAgregarProductos.Show()
        lblAgregar.Enabled = False
    End Sub

    Private Sub lblAgregar_Click(sender As Object, e As EventArgs) Handles lblAgregar.Click
        lblAgregar.Enabled = False
        lblEditar.Enabled = True
        lblEliminar.Enabled = True
        pnlContenedor.Controls.Clear()
        frmAgregarProductos.TopLevel = False
        frmAgregarProductos.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmAgregarProductos)
        frmAgregarProductos.Show()
        itemAgregar.Visible = True
        itemEditar.Visible = False
        itemEliminar.Visible = False
    End Sub

    Private Sub lblEliminar_Click(sender As Object, e As EventArgs) Handles lblEliminar.Click
        lblAgregar.Enabled = True
        lblEditar.Enabled = True
        lblEliminar.Enabled = False
        pnlContenedor.Controls.Clear()
        frmEliminarOnOffProductos.TopLevel = False
        frmEliminarOnOffProductos.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmEliminarOnOffProductos)
        frmEliminarOnOffProductos.Show()
        itemEliminar.Visible = True
        itemEditar.Visible = False
        itemAgregar.Visible = False
        frmEliminarOnOffProductos.listarEliminar("Todos")
    End Sub

    Private Sub lblEditar_Click(sender As Object, e As EventArgs) Handles lblEditar.Click
        lblAgregar.Enabled = True
        lblEditar.Enabled = False
        lblEliminar.Enabled = True
        pnlContenedor.Controls.Clear()
        frmEditarProductos.TopLevel = False
        frmEditarProductos.Dock = DockStyle.Fill
        pnlContenedor.Controls.Add(frmEditarProductos)
        frmEditarProductos.Show()
        itemEditar.Visible = True
        itemAgregar.Visible = False
        itemEliminar.Visible = False
    End Sub
End Class