Imports System.Data.Odbc
Public Class frmTienda
    Dim antes, ahora As String
    Private Sub frmHijo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProductos()
        btnRefrescar.Enabled = False
    End Sub
    Sub listarProductos()
        Dim query As New OdbcCommand("SELECT * FROM productos", conexion)
        Dim rs As OdbcDataReader
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Try
            panel.Controls.Clear()
            rs = query.ExecuteReader()
            If rs.HasRows Then
                While (rs.Read)
                    If rs.Item("estado").ToString() = "1" Then
                        Dim pnl As New FlowLayoutPanel
                        Dim lblNombre As New Label
                        Dim pbImagen As New PictureBox
                        Dim lblAntes As New Label
                        Dim lblAhora As New Label
                        lblNombre.Font = New Font("Sans Serif", 12, FontStyle.Bold)
                        lblAntes.Font = New Font("Sans Serif", 10, FontStyle.Bold)
                        lblAhora.Font = New Font("Sans Serif", 10, FontStyle.Bold)
                        lblAntes.BackColor = Color.Orange
                        lblAhora.BackColor = Color.DarkCyan
                        pbImagen.Height = 221
                        pbImagen.Width = 222
                        lblAntes.Width = 221
                        lblAhora.Width = 221
                        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage
                        lblNombre.Text = rs.Item("nombre").ToString()
                        pbImagen.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\" + rs.Item("foto").ToString())
                        antes = rs.Item("antes").ToString()
                        ahora = rs.Item("ahora").ToString()
                        lblAntes.Text = lang(39) + ": " + antes
                        lblAhora.Text = lang(41) + ": " + ahora
                        pnl.Controls.Add(lblNombre)
                        pnl.Controls.Add(pbImagen)
                        pnl.Controls.Add(lblAntes)
                        pnl.Controls.Add(lblAhora)
                        pnl.Height = 296
                        pnl.Width = 225
                        panel.Controls.Add(pnl)
                    End If
                End While
                lblError.Text = lang(73)
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = lang(74)
            End If
            rs.Close()

        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub
    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        listarProductos()
    End Sub
End Class