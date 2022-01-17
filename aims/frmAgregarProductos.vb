Imports System.Data.Odbc
Public Class frmAgregarProductos
    Public nam, Dir, Dir2, rut, msg, gdir, tempcombo, ant, aho As String
    Dim ret, ret2, ret3, ult As Integer


    Private Sub onlyAntes(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAntes.KeyPress
        If txtAntes.TextLength = 9 Then
            e.Handled = True
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub onlyAhora(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAhora.KeyPress
        If txtAhora.TextLength = 9 Then
            e.Handled = True
        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            txtNombre.Text = "Nombre"
            txtRuta.Text = "ruta://"
            txtAntes.Text = "Antes"
            txtAhora.Text = "Ahora"
            pbImagen.Image = System.Drawing.Image.FromFile("E:\buzzers\godred\aims\aims\media\pro.png")
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmHome.Enabled = False
        nam = txtNombre.Text
        ant = txtAntes.Text
        aho = txtAhora.Text
        ret = txtRuta.Text.Length()
        Dir = txtRuta.Text.Substring(ret - 4, 4)
        rut = My.Computer.FileSystem.CurrentDirectory
        ret2 = rut.Length()
        ret3 = ret2 - 9
        msg = mdlFunciones.f001(conexion, 234)
        Dim ruta As String = rut.Substring(0, 27)
        If Dir = ".jpg" Or Dir = ".JPG" Or Dir = ".png" Or Dir = ".PNG" Then
            Dir = txtRuta.Text.Substring(ret - 4, 4)
        Else
            Dir = txtRuta.Text.Substring(ret - 5, 5)
            If Dir = ".jpeg" Or Dir = ".JPEG" Then
                Dir = txtRuta.Text.Substring(ret - 5, 5)
            Else
                lblError.Text = "Archivo no permitido"
                Dir = ""
            End If
        End If
        If Dir <> "" Then
            gdir = rut.Substring(0, ret3) + "media\pro_" & msg & Dir
            Dir2 = "pro_" & msg & Dir
            Try
                If nam = "" Or nam = "Nombre" Or ant = "" Or ant = "Antes" Or aho = "" Or aho = "Ahora" Or txtRuta.Text = "ruta://" Then
                    lblError.Text = "E001 ::: Hay campos vacios"
                Else
                    My.Computer.FileSystem.CopyFile(txtRuta.Text, gdir, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                    If conexion.State = 0 Then
                        conexion.Open()
                    End If
                    Dim query As New OdbcCommand("INSERT INTO productos VALUES (" & msg & ", '" & nam & "', " & ant & ", " & aho & ", '" & Dir2 & "', 1)", conexion)
                    Try
                        query.ExecuteNonQuery()
                        mdlFunciones.f002(conexion, 555, msg)
                        mdlFunciones.f002(conexion, 234, msg)
                        txtNombre.Text = "Nombre"
                        txtRuta.Text = "ruta://"
                        txtAntes.Text = "Antes"
                        txtAhora.Text = "Ahora"
                    Catch exx As Exception
                        lblError.Text = exx.Message
                    End Try
                End If
            Catch ex As Exception
                lblError.Text = ex.Message
            End Try
        End If
        frmHome.Enabled = True
    End Sub

    Private Sub b002_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        frmHome.Enabled = False
        Try
            Dim file As String
            Dim filtro As New OpenFileDialog
            filtro.Filter = "Imagenes (*.jpg,*.gif,*.png,*.jpeg)|*.jpg;*.gif;*.png;*.jpeg"
            filtro.RestoreDirectory = True
            If filtro.ShowDialog() = Windows.Forms.DialogResult.OK Then
                file = filtro.FileName
                txtRuta.Text = file
                pbImagen.Image = System.Drawing.Image.FromFile(file)
            End If
            lblError.Text = "Imagen subida"
            lblError.ForeColor = Color.Aquamarine
        Catch ex As Exception
            lblError.Text = ex.Message
            lblError.ForeColor = Color.Red
        End Try

        frmHome.Enabled = True
    End Sub
    Private Sub txtNombre_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.GotFocus
        lblNombre.Visible = True
        If txtNombre.Text = "Nombre" Then
            txtNombre.Text = ""
        End If
    End Sub
    Private Sub txtNombre_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        lblNombre.Visible = False
        If txtNombre.Text = "" Then
            txtNombre.Text = "Nombre"
        End If
    End Sub
    Private Sub txtAntes_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAntes.GotFocus
        lblAntes.Visible = True
        If txtAntes.Text = "Antes" Then
            txtAntes.Text = ""
        End If
    End Sub
    Private Sub txtAntes_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAntes.LostFocus
        lblAntes.Visible = False
        If txtAntes.Text = "" Then
            txtAntes.Text = "Antes"
        End If
    End Sub
    Private Sub txtAhora_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAhora.GotFocus
        lblAhora.Visible = True
        If txtAhora.Text = "Ahora" Then
            txtAhora.Text = ""
        End If
    End Sub
    Private Sub txtAhora_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAhora.LostFocus
        lblAhora.Visible = False
        If txtAhora.Text = "" Then
            txtAhora.Text = "Ahora"
        End If
    End Sub
End Class