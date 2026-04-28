Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            closeCon()
            openCon()

            Dim query As String =
                "SELECT role FROM users
                 WHERE username = @username
                 AND password_hash = @password
                 AND status = 'VERIFIED'
                 LIMIT 1"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        Dim role As String = dr("role").ToString()

                        MsgBox("Login Successful!", MsgBoxStyle.Information)
                        Me.Hide()

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

        Catch ex As MySqlException
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
        Catch ex As Exception
            MsgBox("System Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            closeCon()
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click
    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click
    End Sub

End Class
