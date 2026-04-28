
Imports MySql.Data.MySqlClient

Module Connection

    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    ' Open connection
    Public Sub openCon()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;user id=root;password=;database=enrollment_system_db"
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message)
        End Try
    End Sub

    ' Close connection
    Public Sub closeCon()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Closing Error: " & ex.Message)
        End Try
    End Sub

End Module