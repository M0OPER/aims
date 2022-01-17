Imports System.Data.Odbc
Module mdlConexion
    Public conexion As New OdbcConnection("DSN=conexion")
    Public Sub conectar()
        Try
            conexion.Open()
            frmInicioSesion.lblEstado.Text = "CONECTADO"
            frmInicioSesion.btnReconectar.Visible = False
            frmHome.btnReconectar.Visible = False
            frmInicioSesion.btnInicioSesion.Enabled = True
            frmInicioSesion.lblError.Text = ""
        Catch ex As Exception
            frmInicioSesion.lblEstado.Text = "NO CONECTADO"
            frmInicioSesion.btnReconectar.Visible = True
            frmHome.btnReconectar.Visible = True
            frmInicioSesion.btnInicioSesion.Enabled = False
            frmInicioSesion.lblError.Text = "ERROR CON EL SERVIDOR, INTENTE RECONECTAR"
        End Try
    End Sub
End Module
