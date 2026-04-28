Imports MySql.Data.MySqlClient

Public Class UserCreationForm

    Private Sub UserCreationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserList()
    End Sub

    ' ================= LOAD USERS =================
    Private Sub LoadUserList()
        Try
            openCon()

            Dim query As String =
            "SELECT id, username, role, status FROM users WHERE role != 'STUDENT'"

            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
                dgvUsers.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    ' ================= CREATE USER =================
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
            MsgBox("Fill all required fields")
            Exit Sub
        End If

        Try
            openCon()

            ' CHECK USERNAME
            Dim check As New MySqlCommand(
            "SELECT COUNT(*) FROM users WHERE username=@u", conn)

            check.Parameters.AddWithValue("@u", txtUsername.Text)

            If Convert.ToInt32(check.ExecuteScalar()) > 0 Then
                MsgBox("Username already exists")
                Exit Sub
            End If

            ' INSERT USER (FIXED)
            Dim query As String =
            "INSERT INTO users(username, password_hash, role, status)
             VALUES(@u,@p,@r,'PENDING')"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                cmd.Parameters.AddWithValue("@p", txtPassword.Text)
                cmd.Parameters.AddWithValue("@r", cmbRole.Text.ToUpper())

                cmd.ExecuteNonQuery()
            End Using

            MsgBox("User created successfully")

            ClearFields()
            LoadUserList()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeCon()
        End Try

    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
    End Sub

End Class