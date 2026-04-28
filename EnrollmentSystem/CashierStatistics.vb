Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CashierStatistics

    Private Sub CashierStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Always Load Stats first, then Charts
        LoadStats()
        SetupCharts()
    End Sub

    Public Sub LoadStats()
        Try
            openCon()


            ' 2. Total Revenue (Sum from payments table)
            Using cmd As New MySqlCommand("SELECT COALESCE(SUM(amount_paid), 0) FROM payments", conn)
                Dim total As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                lblTotalRevenue.Text = "₱" & total.ToString("N2")
            End Using




            ' 4. Total Payments count
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM payments", conn)
                lblTotalPayments.Text = cmd.ExecuteScalar().ToString()
            End Using

        Catch ex As Exception
            MsgBox("Label Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

    Public Sub SetupCharts()
        Try
            openCon()

            ' --- 1. PIE CHART: User Role Distribution ---
            ' Changed from 'enrollments' to 'users' based on your screenshot
            Dim queryPie As String = "SELECT role, COUNT(*) as total FROM users GROUP BY role"
            Dim dtPie As New DataTable
            Using da As New MySqlDataAdapter(queryPie, conn)
                da.Fill(dtPie)
            End Using

            chartEnrollment.Series.Clear()
            chartEnrollment.Titles.Clear() ' Clear titles to prevent duplicates on refresh
            chartEnrollment.Titles.Add("User Role Distribution")

            Dim series1 As New Series("Roles")
            series1.ChartType = SeriesChartType.Pie

            For Each row As DataRow In dtPie.Rows
                series1.Points.AddXY(row("role").ToString(), row("total"))
            Next
            chartEnrollment.Series.Add(series1)

            ' --- 2. LINE GRAPH: Sales Trend (Last 7 Days) ---
            Dim queryLine As String = "SELECT DATE(payment_date) as pDate, SUM(amount_paid) as dailyTotal " &
                                     "FROM payments WHERE payment_date >= DATE_SUB(CURDATE(), INTERVAL 7 DAY) " &
                                     "GROUP BY DATE(payment_date) ORDER BY pDate ASC"
            Dim dtLine As New DataTable
            Using da As New MySqlDataAdapter(queryLine, conn)
                da.Fill(dtLine)
            End Using

            chartSales.Series.Clear()
            chartSales.Titles.Clear()
            chartSales.Titles.Add("Weekly Sales Trend")

            Dim series2 As New Series("Revenue")
            series2.ChartType = SeriesChartType.Spline ' Curvy line looks better for dashboards
            series2.BorderWidth = 3
            series2.MarkerStyle = MarkerStyle.Circle

            For Each row As DataRow In dtLine.Rows
                series2.Points.AddXY(Convert.ToDateTime(row("pDate")).ToString("MM/dd"), row("dailyTotal"))
            Next
            chartSales.Series.Add(series2)

        Catch ex As Exception
            MsgBox("Chart Error: " & ex.Message)
        Finally
            closeCon()
        End Try
    End Sub

End Class