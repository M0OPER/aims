Imports System.Data.Odbc
Module mdlFunciones
    Dim msg As String
    Function f001(conn, cod)
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Dim query As New OdbcCommand("SELECT ultimo FROM consecutivo WHERE id = " & cod, conn)
        Dim rs As OdbcDataReader
        Try
            rs = query.ExecuteReader()
            If rs.Read Then
                msg = (rs.Item("ultimo").ToString() + 1)
            Else
                msg = "No se encontraron registros"
            End If
            rs.Close()
        Catch ex As Exception
            msg = "Error del servidor" + ex.Message
        End Try
        Return msg
    End Function
    Function f002(conn, cod, ult)
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Dim query As New OdbcCommand("UPDATE consecutivo SET ultimo = " & ult & " WHERE id = " & cod, conexion)
        Try
            query.ExecuteNonQuery()
        Catch ex As Exception
            msg = "Error del servidor" + ex.Message
        End Try
        Return msg
    End Function
    Function f003(conn, cod, tabla, ip, fecha, que_hizo)
        If conexion.State = 0 Then
            conexion.Open()
        End If
        Dim query As New OdbcCommand("INSERT INTO registros VALUES ('', " & cod & ", '" & tabla & "', '" & ip & "', '" & fecha & "', '" & que_hizo & "')", conexion)
        Try
            query.ExecuteNonQuery()
        Catch ex As Exception
            msg = "Error del servidor" + ex.Message
        End Try
        Return msg
    End Function
End Module
