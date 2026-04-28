<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierStatistics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartEnrollment = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblTotalPayments = New System.Windows.Forms.Label()
        CType(Me.chartEnrollment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartEnrollment
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartEnrollment.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartEnrollment.Legends.Add(Legend1)
        Me.chartEnrollment.Location = New System.Drawing.Point(109, 180)
        Me.chartEnrollment.Name = "chartEnrollment"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartEnrollment.Series.Add(Series1)
        Me.chartEnrollment.Size = New System.Drawing.Size(435, 393)
        Me.chartEnrollment.TabIndex = 0
        Me.chartEnrollment.Text = "chartEnrollment"
        '
        'chartSales
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSales.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartSales.Legends.Add(Legend2)
        Me.chartSales.Location = New System.Drawing.Point(579, 180)
        Me.chartSales.Name = "chartSales"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartSales.Series.Add(Series2)
        Me.chartSales.Size = New System.Drawing.Size(370, 393)
        Me.chartSales.TabIndex = 1
        Me.chartSales.Text = "chartSales"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Location = New System.Drawing.Point(241, 83)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalRevenue.TabIndex = 2
        Me.lblTotalRevenue.Text = "Label1"
        '
        'lblTotalPayments
        '
        Me.lblTotalPayments.AutoSize = True
        Me.lblTotalPayments.Location = New System.Drawing.Point(638, 83)
        Me.lblTotalPayments.Name = "lblTotalPayments"
        Me.lblTotalPayments.Size = New System.Drawing.Size(48, 16)
        Me.lblTotalPayments.TabIndex = 4
        Me.lblTotalPayments.Text = "Label3"
        '
        'CashierStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 599)
        Me.Controls.Add(Me.lblTotalPayments)
        Me.Controls.Add(Me.lblTotalRevenue)
        Me.Controls.Add(Me.chartSales)
        Me.Controls.Add(Me.chartEnrollment)
        Me.Name = "CashierStatistics"
        Me.Text = "Form1"
        CType(Me.chartEnrollment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chartEnrollment As DataVisualization.Charting.Chart
    Friend WithEvents chartSales As DataVisualization.Charting.Chart
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblTotalPayments As Label
End Class
