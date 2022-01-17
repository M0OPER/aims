Imports System.Data.Odbc
Public Class frmRegistros
    Dim i As Integer
    Private Sub frmRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblError.Text = lang(95)
        lblError.ForeColor = Color.Lime
    End Sub
    Sub listarRegistros(tabla)
        Dim query As New OdbcCommand("SELECT * FROM registros, usuarios u WHERE id_cod_usuario = u.id AND tabla = '" & tabla & "'", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            dgvListadoRegistros.Rows.Clear()
            dgvListadoRegistros.Columns.Clear()
            dgvListadoRegistros.DataSource = Nothing
            dgvListadoRegistros.Columns.Add("txtNumeroList", "#")
            dgvListadoRegistros.Columns.Add("txtNombresList", lang(18))
            dgvListadoRegistros.Columns.Add("txtQueHizo", lang(127))
            dgvListadoRegistros.Columns.Add("txtFecha", lang(126))
            dgvListadoRegistros.Columns.Add("txtIp", "IP")
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    dgvListadoRegistros.Rows.Add()
                    dgvListadoRegistros.Item(0, i).Value = i + 1
                    dgvListadoRegistros.Item(1, i).Value = rs.Item("nombres").ToString()
                    dgvListadoRegistros.Item(2, i).Value = rs.Item("que_hizo").ToString()
                    dgvListadoRegistros.Item(3, i).Value = rs.Item("fecha").ToString()
                    dgvListadoRegistros.Item(4, i).Value = rs.Item("ip").ToString()
                    i = i + 1
                End While
                dgvListadoRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                lblError.Text = lang(96)
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = lang(97)
            End If
            i = 0
            rs.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub cbOrdenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrdenar.SelectedIndexChanged
        If cbOrdenar.Text = lang(117) Then
            listarRegistros("USUARIOS")
        ElseIf cbOrdenar.Text = lang(116)
            listarRegistros("TESTIMONIOS")
        ElseIf cbOrdenar.Text = lang(125)
            listarRegistros("PRODUCTOS")
        End If
    End Sub
End Class