Imports MySql.Data.MySqlClient

Public Class CashierDashboard

    Private Sub CashierDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically load statistics on startup
        LoadFormIntoPanel(New CashierStatistics())
    End Sub
    ' ================= PANEL LOADER =================
    Private Sub LoadFormIntoPanel(frm As Form)
        pnlMain.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pnlMain.Controls.Add(frm)
        frm.Show()
    End Sub


    ' ================= NAVIGATION =================
    Private Sub btnBilling_Click(sender As Object, e As EventArgs) Handles btnBilling.Click
        LoadFormIntoPanel(New BillingForm())
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        LoadFormIntoPanel(New CashierForm())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        LoadFormIntoPanel(New CashierReportsForm())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        LoadFormIntoPanel(New CashierStatistics())
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
