Imports System.Data.Odbc
Public Class frmListadoArticulos
    Dim i As Integer
    Dim ruta As String
    Private Sub frmListadoArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarEnStock()
        listarTerminados()
    End Sub
    Sub listarEnStock()
        Dim query As New OdbcCommand("SELECT * FROM productos WHERE estado = 1", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            dgvListadoStock.Rows.Clear()
            dgvListadoStock.Columns.Clear()
            dgvListadoStock.DataSource = Nothing
            dgvListadoStock.Columns.Add("txtNumeroList", "#")
            dgvListadoStock.Columns.Add("txtNombreList", lang(34))
            dgvListadoStock.Columns.Add("txtPrecioList", lang(128))
            dgvListadoStock.Columns.Add("txtRutaList", lang(129))
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    dgvListadoStock.Rows.Add()
                    dgvListadoStock.Item(0, i).Value = i + 1
                    dgvListadoStock.Item(1, i).Value = rs.Item("nombre").ToString()
                    dgvListadoStock.Item(2, i).Value = rs.Item("ahora").ToString()
                    dgvListadoStock.Item(3, i).Value = rs.Item("foto").ToString()
                    i = i + 1
                End While
                dgvListadoStock.Columns(1).Width = 131
                dgvListadoStock.Columns(2).Width = 131
                dgvListadoStock.Columns(3).Width = 131
                lblStock.Text = lang(83) & i
                lblError.Text = lang(73)
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = lang(74)
            End If
            i = 0
            rs.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub
    Sub listarTerminados()
        Dim query As New OdbcCommand("SELECT * FROM productos WHERE estado = 2", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            dgvListadoTerminados.Rows.Clear()
            dgvListadoTerminados.Columns.Clear()
            dgvListadoTerminados.DataSource = Nothing
            dgvListadoTerminados.Columns.Add("txtNumeroList", "#")
            dgvListadoTerminados.Columns.Add("txtNombreList", lang(34))
            dgvListadoTerminados.Columns.Add("txtPrecioList", lang(128))
            dgvListadoTerminados.Columns.Add("txtRutaList", lang(129))
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    dgvListadoTerminados.Rows.Add()
                    dgvListadoTerminados.Item(0, i).Value = i + 1
                    dgvListadoTerminados.Item(1, i).Value = rs.Item("nombre").ToString()
                    dgvListadoTerminados.Item(2, i).Value = rs.Item("ahora").ToString()
                    dgvListadoTerminados.Item(3, i).Value = rs.Item("foto").ToString()
                    i = i + 1
                End While
                dgvListadoTerminados.Columns(1).Width = 131
                dgvListadoTerminados.Columns(2).Width = 131
                dgvListadoTerminados.Columns(3).Width = 131
                lblTerminados.Text = lang(83) & i
                lblError.Text = lang(73)
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = lang(74)
            End If
            i = 0
            rs.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub dgvListadoStock_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoStock.CellContentClick

    End Sub

    Private Sub dgvListadoStock_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoStock.RowEnter
        Try
            If dgvListadoStock.Rows(e.RowIndex).Cells(1).Value.ToString() <> "" Then
                ruta = dgvListadoStock.Rows(e.RowIndex).Cells(3).Value.ToString()
                pbStock.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\" + ruta)
            End If
        Catch ex As Exception
            lblError.Text = lang(59)
        End Try
    End Sub

    Private Sub dgvListadoTerminados_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoTerminados.RowEnter
        Try
            If dgvListadoTerminados.Rows(e.RowIndex).Cells(1).Value.ToString() <> "" Then
                ruta = dgvListadoTerminados.Rows(e.RowIndex).Cells(3).Value.ToString()
                pbTerminados.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\" + ruta)
            End If
        Catch ex As Exception
            lblError.Text = lang(59)
        End Try
    End Sub
End Class