<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentMasterlistForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalRecords = New System.Windows.Forms.Label()
        Me.lblPendingGrades = New System.Windows.Forms.Label()
        Me.pnlFilters = New System.Windows.Forms.Panel()
        Me.lblSubjectFilter = New System.Windows.Forms.Label()
        Me.cmbSubjectFilter = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvGrades = New System.Windows.Forms.DataGridView()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlTop.SuspendLayout()
        Me.pnlFilters.SuspendLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 60)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblTotalRecords)
        Me.pnlTop.Controls.Add(Me.lblPendingGrades)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Size = New System.Drawing.Size(1300, 65)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 15, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 12)
        Me.lblTitle.Text = "GRADES MASTERLIST"

        Me.lblTotalRecords.AutoSize = True
        Me.lblTotalRecords.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(180, 190, 220)
        Me.lblTotalRecords.Location = New System.Drawing.Point(22, 43)
        Me.lblTotalRecords.Text = "Total Records: 0"

        Me.lblPendingGrades.AutoSize = True
        Me.lblPendingGrades.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblPendingGrades.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60)
        Me.lblPendingGrades.Location = New System.Drawing.Point(180, 43)
        Me.lblPendingGrades.Text = "Pending Grades: 0"

        ' pnlFilters
        Me.pnlFilters.BackColor = System.Drawing.Color.White
        Me.pnlFilters.Controls.Add(Me.lblSubjectFilter)
        Me.pnlFilters.Controls.Add(Me.cmbSubjectFilter)
        Me.pnlFilters.Controls.Add(Me.btnRefresh)
        Me.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilters.Height = 50
        Me.pnlFilters.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)

        Me.lblSubjectFilter.AutoSize = True
        Me.lblSubjectFilter.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblSubjectFilter.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
        Me.lblSubjectFilter.Location = New System.Drawing.Point(20, 16)
        Me.lblSubjectFilter.Text = "FILTER SUBJECT:"

        Me.cmbSubjectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubjectFilter.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbSubjectFilter.Location = New System.Drawing.Point(145, 13)
        Me.cmbSubjectFilter.Size = New System.Drawing.Size(350, 24)

        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(520, 11)
        Me.btnRefresh.Size = New System.Drawing.Size(120, 28)
        Me.btnRefresh.Text = "Refresh Data"

        ' dgvGrades
        Me.dgvGrades.AllowUserToAddRows = False
        Me.dgvGrades.AllowUserToDeleteRows = False
        Me.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrades.BackgroundColor = System.Drawing.Color.White
        Me.dgvGrades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGrades.ColumnHeadersHeight = 38
        Me.dgvGrades.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)
        Me.dgvGrades.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.dgvGrades.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.dgvGrades.EnableHeadersVisualStyles = False
        Me.dgvGrades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGrades.ReadOnly = True
        Me.dgvGrades.RowHeadersVisible = False
        Me.dgvGrades.RowTemplate.Height = 32
        Me.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrades.GridColor = System.Drawing.Color.FromArgb(230, 230, 230)
        Me.dgvGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        ' pnlBottom
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.pnlBottom.Controls.Add(Me.btnExport)
        Me.pnlBottom.Controls.Add(Me.btnClose)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Height = 55

        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(20, 12)
        Me.btnExport.Size = New System.Drawing.Size(130, 32)
        Me.btnExport.Text = "Export to CSV"

        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(149, 165, 166)
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1150, 12)
        Me.btnClose.Size = New System.Drawing.Size(130, 32)
        Me.btnClose.Text = "Close"

        ' Form
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.dgvGrades)
        Me.Controls.Add(Me.pnlFilters)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.Name = "StudentMasterlistForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades Masterlist"

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlFilters.ResumeLayout(False)
        Me.pnlFilters.PerformLayout()
        CType(Me.dgvGrades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalRecords As System.Windows.Forms.Label
    Friend WithEvents lblPendingGrades As System.Windows.Forms.Label
    Friend WithEvents pnlFilters As System.Windows.Forms.Panel
    Friend WithEvents lblSubjectFilter As System.Windows.Forms.Label
    Friend WithEvents cmbSubjectFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvGrades As System.Windows.Forms.DataGridView
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
