Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Basic validation
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            closeCon()
            openCon()

            Dim query As String =
                "SELECT id, username, role FROM users 
                 WHERE username = @username 
                 AND password_hash = @password 
                 AND status = 'VERIFIED' 
                 LIMIT 1"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        ' Save to Session Module
                        UserSession.CurrentUsername = dr("username").ToString()
                        UserSession.CurrentCashierID = Convert.ToInt32(dr("id"))
                        UserSession.CurrentRole = dr("role").ToString()

                        Dim role As String = dr("role").ToString()

                        MsgBox("Login Successful!", MsgBoxStyle.Information)
                        Me.Hide()

                        ' Navigate based on role
                        Select Case role.Trim().ToLower()
                            Case "admin"
                                Dim f As New AdminDashboard()
                                f.Show()
                            Case "registrar"
                                Dim f As New RegistrarDashboard()
                                f.Show()
                            Case "cashier"
                                Dim f As New CashierDashboard()
                                f.Show()
                            Case "faculty"
                                Dim f As New FacultyDashboard()
                                f.Show()
                            Case Else
                                MsgBox("Role '" & role & "' is not recognized.", MsgBoxStyle.Exclamation)
                                Me.Show()
                        End Select
                    Else
                        MsgBox("Invalid username/password or account is not verified.", MsgBoxStyle.Critical)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeCon()
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class
