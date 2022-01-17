Imports System.Data.Odbc
Public Class frmTestimonios
    Public id_usuario, id, tipo_usuario As Integer
    Public nombre As String
    Dim nombres, titulo, texto, fecha As String

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        listarTestimonios()
    End Sub

    Sub listarTestimonios()
        Try
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Dim query1 As New OdbcCommand("SELECT * FROM testimonios, usuarios u WHERE u.id = id_cod_usuario AND id_cod_usuario = " & id_usuario, conexion)
            Dim rs1 As OdbcDataReader
            rs1 = query1.ExecuteReader()
            If rs1.Read Then
                Dim str As String
                Dim strArr() As String
                id = rs1.Item("id")
                txtTitulo.Text = rs1.Item("titulo").ToString()
                txtTexto.Text = rs1.Item("texto").ToString()
                str = Replace(rs1.Item("fecha").ToString(), "/", "-").Substring(0, 10)
                strArr = str.Split("-")
                lblFecha.Text = strArr(2) + "-" + strArr(1) + "-" + strArr(0)
                Me.btnTestimonio.Text = lang(104)
                Me.btnEstado.Enabled = True
                If rs1.Item("estado").ToString() = "1" Then
                    btnEstado.Text = lang(106)
                Else
                    btnEstado.Text = lang(105)
                End If
            End If
        Catch ex As Exception
            If ex.Message = "ERROR [HY000] [MySQL][ODBC 5.1 Driver]Can't connect to MySQL server on 'localhost' (10061)" Then
                frmHome.btnReconectar.Visible = True
            End If
            lblError.Text = ex.Message
        End Try
        Try
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Dim query2 As New OdbcCommand("SELECT * FROM testimonios, usuarios u WHERE u.id = id_cod_usuario", conexion)
            Dim rs2 As OdbcDataReader
            panel2.Controls.Clear()
            rs2 = query2.ExecuteReader()
            If rs2.HasRows Then
                While (rs2.Read)
                    If rs2.Item("estado").ToString() = "1" Then
                        Dim pnl2 As New FlowLayoutPanel
                        Dim txtNombre2 As New TextBox
                        Dim txtTitulo2 As New TextBox
                        Dim lblFecha2 As New Label
                        Dim txtTexto2 As New TextBox
                        Dim linea As New Panel
                        txtNombre2.Height = 20
                        txtNombre2.Width = 791
                        txtTitulo2.Height = 20
                        txtTitulo2.Width = 920
                        txtTexto2.Height = 65
                        txtTexto2.Width = 921
                        linea.Width = 920
                        linea.Height = 2
                        linea.BackColor = Color.Lime
                        txtTexto2.Multiline = True
                        txtNombre2.Text = rs2.Item("nombres").ToString()
                        txtTitulo2.Text = rs2.Item("titulo").ToString()
                        lblFecha2.Text = Replace(rs2.Item("fecha").ToString(), "/", "-")
                        txtTexto2.Text = rs2.Item("texto").ToString()
                        txtNombre2.ReadOnly = True
                        txtTexto2.ReadOnly = True
                        txtTitulo2.ReadOnly = True
                        pnl2.Controls.Add(txtNombre2)
                        pnl2.Controls.Add(lblFecha2)
                        pnl2.Controls.Add(txtTitulo2)
                        pnl2.Controls.Add(txtTexto2)
                        pnl2.Height = 158
                        pnl2.Width = 924
                        panel2.Controls.Add(pnl2)
                        panel2.Controls.Add(linea)
                    End If
                End While
                lblError.Text = lang(107)
                lblError.ForeColor = Color.MediumSeaGreen
            Else
                lblError.ForeColor = Color.Green
                lblError.Text = lang(108)
            End If
            rs2.Close()
        Catch ex As Exception
            If ex.Message = "ERROR [HY000] [MySQL][ODBC 5.1 Driver]Can't connect to MySQL server on 'localhost' (10061)" Then
                frmHome.btnReconectar.Visible = True
            End If
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub btnEstado_Click(sender As Object, e As EventArgs) Handles btnEstado.Click
        If btnEstado.Text = lang(105) Then
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Try
                Dim query As New OdbcCommand("UPDATE testimonios SET estado = 1 WHERE id = " & id, conexion)
                query.ExecuteNonQuery()
                listarTestimonios()
                lblError.Text = lang(109)
                lblError.ForeColor = Color.MediumSeaGreen
                listarTestimonios()
            Catch ex As Exception
                lblError.ForeColor = Color.Red
                lblError.Text = ex.Message
            End Try
        ElseIf btnEstado.Text = lang(106) Then
            If conexion.State = 0 Then
                conexion.Open()
            End If
            Try
                Dim query As New OdbcCommand("UPDATE testimonios SET estado = 2 WHERE id = " & id, conexion)
                query.ExecuteNonQuery()
                listarTestimonios()
                lblError.Text = lang(110)
                lblError.ForeColor = Color.MediumSeaGreen
                listarTestimonios()
            Catch ex As Exception
                If ex.Message = "ERROR [HY000] [MySQL][ODBC 5.1 Driver]Can't connect to MySQL server on 'localhost' (10061)" Then
                    frmHome.btnReconectar.Visible = True
                End If
                lblError.ForeColor = Color.Red
                lblError.Text = ex.Message
            End Try
        End If
    End Sub

    Private Sub frmHijo5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Height = 20
        txtNombre.Width = 791
        btnTestimonio.Height = 22
        btnTestimonio.Width = 113
        txtTitulo.Height = 20
        lblTitulo.Width = 100
        txtTitulo.Width = 670
        txtTexto.Height = 65
        txtTexto.Width = 921
        btnEstado.Width = 100
        lblMensaje.Width = 920
        txtTexto.Multiline = True
        txtNombre.Text = nombre
        lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd")
        If tipo_usuario <> 3 Then
            lblError.Text = "Solo los clientes pueden agregar testimonios"
            btnEstado.Enabled = False
            btnTestimonio.Enabled = False
            txtTexto.Enabled = False
            txtTitulo.Enabled = False
        End If
        listarTestimonios()
    End Sub

    Private Sub btnTestimonio_Click(sender As Object, e As EventArgs) Handles btnTestimonio.Click
        frmHome.Enabled = False
        If btnTestimonio.Text = lang(99) Then
            Try
                nombres = txtNombre.Text
                texto = txtTexto.Text
                titulo = txtTitulo.Text
                fecha = lblFecha.Text
                If texto = "" Or texto = "" Or titulo = "" Then
                    lblError.Text = lang(13)
                Else
                    If conexion.State = 0 Then
                        conexion.Open()
                    End If
                    Dim query As New OdbcCommand("INSERT INTO testimonios VALUES ('', " & id_usuario & ", '" & texto & "', '" & titulo & "', '" & fecha & "', 1)", conexion)
                    Try
                        query.ExecuteNonQuery()
                        btnTestimonio.Text = lang(104)
                        btnEstado.Text = lang(106)
                        listarTestimonios()
                    Catch ex As Exception
                        lblError.Text = ex.Message
                    End Try
                End If
            Catch ex As Exception
                If ex.Message = "ERROR [HY000] [MySQL][ODBC 5.1 Driver]Can't connect to MySQL server on 'localhost' (10061)" Then
                    frmHome.btnReconectar.Visible = True
                End If
                lblError.Text = ex.Message
            End Try
        ElseIf btnTestimonio.Text = lang(104)
            Try
                nombres = txtNombre.Text
                texto = txtTexto.Text
                titulo = txtTitulo.Text
                fecha = lblFecha.Text
                If texto = "" Or texto = "" Or titulo = "" Then
                    lblError.Text = lang(13)
                Else
                    If conexion.State = 0 Then
                        conexion.Open()
                    End If
                    Dim query As New OdbcCommand("UPDATE testimonios SET texto = '" & texto & "', titulo = '" & titulo & "', fecha = '" & fecha & "' WHERE id = " & id, conexion)
                    Try
                        query.ExecuteNonQuery()
                        btnTestimonio.Text = lang(104)
                        btnEstado.Text = lang(106)
                        listarTestimonios()
                    Catch ex As Exception
                        lblError.Text = ex.Message
                    End Try
                End If
            Catch ex As Exception
                If ex.Message = "ERROR [HY000] [MySQL][ODBC 5.1 Driver]Can't connect to MySQL server on 'localhost' (10061)" Then
                    frmHome.btnReconectar.Visible = True
                End If
                lblError.Text = ex.Message
            End Try
        End If
        frmHome.Enabled = True
    End Sub
End Class