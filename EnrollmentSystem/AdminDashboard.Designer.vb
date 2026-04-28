<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
    Inherits Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblSidebarBrand = New System.Windows.Forms.Label()
        Me.pnlNavDivider = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnManageAccount = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.pnlCards = New System.Windows.Forms.Panel()
        Me.cardStudents = New System.Windows.Forms.Panel()
        Me.lblCardStudentsIcon = New System.Windows.Forms.Label()
        Me.lblCardStudentsVal = New System.Windows.Forms.Label()
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.cardUsers = New System.Windows.Forms.Panel()
        Me.lblCardUsersIcon = New System.Windows.Forms.Label()
        Me.lblCardUsersVal = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.cardEnrolled = New System.Windows.Forms.Panel()
        Me.lblCardEnrolledIcon = New System.Windows.Forms.Label()
        Me.lblCardEnrolledVal = New System.Windows.Forms.Label()
        Me.lblEnrolled = New System.Windows.Forms.Label()
        Me.cardRevenue = New System.Windows.Forms.Panel()
        Me.lblCardRevenueIcon = New System.Windows.Forms.Label()
        Me.lblCardRevenueVal = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()

        Me.pnlSidebar.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlCards.SuspendLayout()
        Me.cardStudents.SuspendLayout()
        Me.cardUsers.SuspendLayout()
        Me.cardEnrolled.SuspendLayout()
        Me.cardRevenue.SuspendLayout()
        Me.SuspendLayout()

        ' ===== FORM =====
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.MinimumSize = New System.Drawing.Size(1200, 700)

        ' ===== SIDEBAR =====
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Width = 240
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42)
        Me.pnlSidebar.Controls.Add(Me.lblSidebarBrand)
        Me.pnlSidebar.Controls.Add(Me.pnlNavDivider)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnUsers)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnManageAccount)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)

        Me.lblSidebarBrand.Text = "EduEnroll"
        Me.lblSidebarBrand.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblSidebarBrand.ForeColor = System.Drawing.Color.White
        Me.lblSidebarBrand.AutoSize = True
        Me.lblSidebarBrand.Location = New System.Drawing.Point(24, 28)

        Me.pnlNavDivider.Location = New System.Drawing.Point(20, 72)
        Me.pnlNavDivider.Size = New System.Drawing.Size(200, 1)
        Me.pnlNavDivider.BackColor = System.Drawing.Color.FromArgb(51, 65, 85)

        Dim sideButtons As System.Windows.Forms.Button() = {Me.btnDashboard, Me.btnUsers, Me.btnReports, Me.btnManageAccount}
        Dim sideTexts As String() = {"  Dashboard", "  User Verification", "  Reports", "  Manage Accounts"}
        Dim sideY As Integer = 90
        For i As Integer = 0 To sideButtons.Length - 1
            sideButtons(i).Text = sideTexts(i)
            sideButtons(i).Location = New System.Drawing.Point(12, sideY)
            sideButtons(i).Size = New System.Drawing.Size(216, 44)
            sideButtons(i).FlatStyle = System.Windows.Forms.FlatStyle.Flat
            sideButtons(i).FlatAppearance.BorderSize = 0
            sideButtons(i).BackColor = System.Drawing.Color.Transparent
            sideButtons(i).ForeColor = System.Drawing.Color.FromArgb(148, 163, 184)
            sideButtons(i).Font = New System.Drawing.Font("Segoe UI", 10)
            sideButtons(i).TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            sideButtons(i).Cursor = System.Windows.Forms.Cursors.Hand
            sideY += 50
        Next

        Me.btnLogout.Text = "  Logout"
        Me.btnLogout.Location = New System.Drawing.Point(12, 620)
        Me.btnLogout.Size = New System.Drawing.Size(216, 44)
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(127, 29, 29)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(254, 202, 202)
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand

        ' ===== TOP BAR =====
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Height = 64
        Me.pnlTopBar.BackColor = System.Drawing.Color.White
        Me.pnlTopBar.Controls.Add(Me.lblTitle)

        Me.lblTitle.Text = "Admin Dashboard"
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(24, 18)

        ' ===== CONTENT =====
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250)
        Me.pnlContent.Controls.Add(Me.pnlDashboard)

        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.BackColor = System.Drawing.Color.Transparent
        Me.pnlDashboard.Controls.Add(Me.lblWelcome)
        Me.pnlDashboard.Controls.Add(Me.pnlCards)

        Me.lblWelcome.Text = "Overview"
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(30, 30)

        Me.pnlCards.Location = New System.Drawing.Point(30, 70)
        Me.pnlCards.Size = New System.Drawing.Size(900, 160)
        Me.pnlCards.BackColor = System.Drawing.Color.Transparent
        Me.pnlCards.Controls.Add(Me.cardStudents)
        Me.pnlCards.Controls.Add(Me.cardUsers)
        Me.pnlCards.Controls.Add(Me.cardEnrolled)
        Me.pnlCards.Controls.Add(Me.cardRevenue)

        Dim cards As System.Windows.Forms.Panel() = {Me.cardStudents, Me.cardUsers, Me.cardEnrolled, Me.cardRevenue}
        Dim cardColors As System.Drawing.Color() = {
            System.Drawing.Color.FromArgb(37, 99, 235),
            System.Drawing.Color.FromArgb(5, 150, 105),
            System.Drawing.Color.FromArgb(124, 58, 237),
            System.Drawing.Color.FromArgb(217, 119, 6)
        }
        Dim cardX As Integer = 0
        For i As Integer = 0 To cards.Length - 1
            cards(i).Location = New System.Drawing.Point(cardX, 0)
            cards(i).Size = New System.Drawing.Size(200, 140)
            cards(i).BackColor = cardColors(i)
            cardX += 220
        Next

        Me.cardStudents.Controls.Add(Me.lblCardStudentsIcon)
        Me.cardStudents.Controls.Add(Me.lblCardStudentsVal)
        Me.cardStudents.Controls.Add(Me.lblStudents)

        Me.lblCardStudentsIcon.Text = "👥"
        Me.lblCardStudentsIcon.Font = New System.Drawing.Font("Segoe UI", 20)
        Me.lblCardStudentsIcon.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254)
        Me.lblCardStudentsIcon.AutoSize = True
        Me.lblCardStudentsIcon.Location = New System.Drawing.Point(16, 14)

        Me.lblCardStudentsVal.Text = "0"
        Me.lblCardStudentsVal.Font = New System.Drawing.Font("Segoe UI", 26, System.Drawing.FontStyle.Bold)
        Me.lblCardStudentsVal.ForeColor = System.Drawing.Color.White
        Me.lblCardStudentsVal.AutoSize = True
        Me.lblCardStudentsVal.Location = New System.Drawing.Point(16, 55)

        Me.lblStudents.Text = "Total Students"
        Me.lblStudents.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblStudents.ForeColor = System.Drawing.Color.FromArgb(191, 219, 254)
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Location = New System.Drawing.Point(16, 105)

        Me.cardUsers.Controls.Add(Me.lblCardUsersIcon)
        Me.cardUsers.Controls.Add(Me.lblCardUsersVal)
        Me.cardUsers.Controls.Add(Me.lblUsers)

        Me.lblCardUsersIcon.Text = "🔑"
        Me.lblCardUsersIcon.Font = New System.Drawing.Font("Segoe UI", 20)
        Me.lblCardUsersIcon.ForeColor = System.Drawing.Color.FromArgb(167, 243, 208)
        Me.lblCardUsersIcon.AutoSize = True
        Me.lblCardUsersIcon.Location = New System.Drawing.Point(16, 14)

        Me.lblCardUsersVal.Text = "0"
        Me.lblCardUsersVal.Font = New System.Drawing.Font("Segoe UI", 26, System.Drawing.FontStyle.Bold)
        Me.lblCardUsersVal.ForeColor = System.Drawing.Color.White
        Me.lblCardUsersVal.AutoSize = True
        Me.lblCardUsersVal.Location = New System.Drawing.Point(16, 55)

        Me.lblUsers.Text = "System Users"
        Me.lblUsers.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblUsers.ForeColor = System.Drawing.Color.FromArgb(167, 243, 208)
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Location = New System.Drawing.Point(16, 105)

        Me.cardEnrolled.Controls.Add(Me.lblCardEnrolledIcon)
        Me.cardEnrolled.Controls.Add(Me.lblCardEnrolledVal)
        Me.cardEnrolled.Controls.Add(Me.lblEnrolled)

        Me.lblCardEnrolledIcon.Text = "📋"
        Me.lblCardEnrolledIcon.Font = New System.Drawing.Font("Segoe UI", 20)
        Me.lblCardEnrolledIcon.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblCardEnrolledIcon.AutoSize = True
        Me.lblCardEnrolledIcon.Location = New System.Drawing.Point(16, 14)

        Me.lblCardEnrolledVal.Text = "0"
        Me.lblCardEnrolledVal.Font = New System.Drawing.Font("Segoe UI", 26, System.Drawing.FontStyle.Bold)
        Me.lblCardEnrolledVal.ForeColor = System.Drawing.Color.White
        Me.lblCardEnrolledVal.AutoSize = True
        Me.lblCardEnrolledVal.Location = New System.Drawing.Point(16, 55)

        Me.lblEnrolled.Text = "Enrolled"
        Me.lblEnrolled.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblEnrolled.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblEnrolled.AutoSize = True
        Me.lblEnrolled.Location = New System.Drawing.Point(16, 105)

        Me.cardRevenue.Controls.Add(Me.lblCardRevenueIcon)
        Me.cardRevenue.Controls.Add(Me.lblCardRevenueVal)
        Me.cardRevenue.Controls.Add(Me.lblRevenue)

        Me.lblCardRevenueIcon.Text = "💰"
        Me.lblCardRevenueIcon.Font = New System.Drawing.Font("Segoe UI", 20)
        Me.lblCardRevenueIcon.ForeColor = System.Drawing.Color.FromArgb(253, 230, 138)
        Me.lblCardRevenueIcon.AutoSize = True
        Me.lblCardRevenueIcon.Location = New System.Drawing.Point(16, 14)

        Me.lblCardRevenueVal.Text = "₱0"
        Me.lblCardRevenueVal.Font = New System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold)
        Me.lblCardRevenueVal.ForeColor = System.Drawing.Color.White
        Me.lblCardRevenueVal.AutoSize = True
        Me.lblCardRevenueVal.Location = New System.Drawing.Point(16, 55)

        Me.lblRevenue.Text = "Total Revenue"
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(253, 230, 138)
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Location = New System.Drawing.Point(16, 105)

        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlSidebar)

        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.pnlCards.ResumeLayout(False)
        Me.cardStudents.ResumeLayout(False)
        Me.cardStudents.PerformLayout()
        Me.cardUsers.ResumeLayout(False)
        Me.cardUsers.PerformLayout()
        Me.cardEnrolled.ResumeLayout(False)
        Me.cardEnrolled.PerformLayout()
        Me.cardRevenue.ResumeLayout(False)
        Me.cardRevenue.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblSidebarBrand As System.Windows.Forms.Label
    Friend WithEvents pnlNavDivider As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnManageAccount As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
    Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents pnlCards As System.Windows.Forms.Panel
    Friend WithEvents cardStudents As System.Windows.Forms.Panel
    Friend WithEvents lblCardStudentsIcon As System.Windows.Forms.Label
    Friend WithEvents lblCardStudentsVal As System.Windows.Forms.Label
    Friend WithEvents lblStudents As System.Windows.Forms.Label
    Friend WithEvents cardUsers As System.Windows.Forms.Panel
    Friend WithEvents lblCardUsersIcon As System.Windows.Forms.Label
    Friend WithEvents lblCardUsersVal As System.Windows.Forms.Label
    Friend WithEvents lblUsers As System.Windows.Forms.Label
    Friend WithEvents cardEnrolled As System.Windows.Forms.Panel
    Friend WithEvents lblCardEnrolledIcon As System.Windows.Forms.Label
    Friend WithEvents lblCardEnrolledVal As System.Windows.Forms.Label
    Friend WithEvents lblEnrolled As System.Windows.Forms.Label
    Friend WithEvents cardRevenue As System.Windows.Forms.Panel
    Friend WithEvents lblCardRevenueIcon As System.Windows.Forms.Label
    Friend WithEvents lblCardRevenueVal As System.Windows.Forms.Label
    Friend WithEvents lblRevenue As System.Windows.Forms.Label
End Class
