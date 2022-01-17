Imports System.Data.Odbc
Public Class frmEditar
    Public nam, Dir, Dir2, rut, msg, gdir, tempcombo, ant, aho As String
    Dim ret, ret2, ret3, ult As Integer
    Public temp1, temp2, temp3, temp4, nombre, ruta, antes, ahora, tabla, ip, fecha, que_hizo As String
    Public id_usuario As Integer
    Dim id As Integer
    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        frmHome.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmHome.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = temp1 And txtRuta.Text = temp2 And txtAntes.Text = temp3 And txtAhora.Text = temp4 Then
            lblError.Text = "Debe hacer un cambio para poder guardarlo"
        ElseIf txtNombre.Text <> "" And txtRuta.Text <> "" And txtAntes.Text <> "" And txtAhora.Text <> ""
            nam = txtNombre.Text
            ant = txtAntes.Text
            aho = txtAhora.Text
            id = lblId.Text
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
                        My.Computer.FileSystem.CopyFile(txtRuta.Text, gdir,
                        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                        If conexion.State = 0 Then
                            conexion.Open()
                        End If
                        Dim query As New OdbcCommand("UPDATE productos SET nombre = '" & nam & "', antes = " & ant & ", ahora = " & aho & ", foto = '" & Dir2 & "' WHERE id = " & id, conexion)
                        mdlFunciones.f003(conexion, id_usuario, "PRODUCTOS", ip, fecha, "UPDATE productos SET nombre = '" & nam & "', antes = " & ant & ", ahora = " & aho & ", foto = '" & Dir2 & "' WHERE id = " & id)
                        Try
                            query.ExecuteNonQuery()
                            mdlFunciones.f002(conexion, 555, msg)
                            mdlFunciones.f002(conexion, 234, msg)
                            frmEditarProductos.cbListar.Text = "LIMPIAR"
                            frmEliminarOnOffProductos.listarEliminar("Todos")
                            frmEditarProductos.listarEliminar("Activos")
                            lblError.Text = "Producto actualizado"
                        Catch exx As Exception
                            lblError.Text = exx.Message
                        End Try
                    End If
                Catch ex As Exception
                    lblError.Text = ex.Message
                End Try
            End If
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

    Private Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        Try
            Dim file As String
            Dim filtro As New OpenFileDialog
            filtro.Filter = "Imagenes (*.jpg,*.png,*.jpeg)|*.jpg;*.png;*.jpeg"
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
    End Sub
End Class