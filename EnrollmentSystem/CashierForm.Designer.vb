<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.pnlPayment = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.txtOR = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.pnlHistory = New System.Windows.Forms.Panel()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.txtSearchHistory = New System.Windows.Forms.TextBox()
        Me.btnSearchHistory = New System.Windows.Forms.Button()
        Me.pnlStudent.SuspendLayout()
        Me.pnlPayment.SuspendLayout()
        Me.pnlHistory.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(320, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(427, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "CASHIER PAYMENT MODULE"
        '
        'pnlStudent
        '
        Me.pnlStudent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlStudent.Controls.Add(Me.lblStudentID)
        Me.pnlStudent.Controls.Add(Me.txtStudentID)
        Me.pnlStudent.Controls.Add(Me.btnSearch)
        Me.pnlStudent.Controls.Add(Me.lblStudentName)
        Me.pnlStudent.Controls.Add(Me.txtStudentName)
        Me.pnlStudent.Controls.Add(Me.lblCourse)
        Me.pnlStudent.Controls.Add(Me.txtCourse)
        Me.pnlStudent.Location = New System.Drawing.Point(20, 80)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(300, 580)
        Me.pnlStudent.TabIndex = 1
        '
        'lblStudentID
        '
        Me.lblStudentID.Location = New System.Drawing.Point(20, 20)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'txtStudentID
        '
        Me.txtStudentID.Location = New System.Drawing.Point(20, 50)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(180, 22)
        Me.txtStudentID.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(20, 85)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        '
        'lblStudentName
        '
        Me.lblStudentName.Location = New System.Drawing.Point(20, 140)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(20, 170)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(250, 22)
        Me.txtStudentName.TabIndex = 4
        '
        'lblCourse
        '
        Me.lblCourse.Location = New System.Drawing.Point(20, 210)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse.TabIndex = 5
        Me.lblCourse.Text = "Course"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(20, 240)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(250, 22)
        Me.txtCourse.TabIndex = 6
        '
        'pnlPayment
        '
        Me.pnlPayment.Controls.Add(Me.lblTotal)
        Me.pnlPayment.Controls.Add(Me.txtTotal)
        Me.pnlPayment.Controls.Add(Me.lblPaid)
        Me.pnlPayment.Controls.Add(Me.txtPaid)
        Me.pnlPayment.Controls.Add(Me.lblBalance)
        Me.pnlPayment.Controls.Add(Me.txtBalance)
        Me.pnlPayment.Controls.Add(Me.lblAmount)
        Me.pnlPayment.Controls.Add(Me.txtAmount)
        Me.pnlPayment.Controls.Add(Me.lblType)
        Me.pnlPayment.Controls.Add(Me.cmbType)
        Me.pnlPayment.Controls.Add(Me.btnPay)
        Me.pnlPayment.Controls.Add(Me.btnClear)
        Me.pnlPayment.Controls.Add(Me.btnReceipt)
        Me.pnlPayment.Controls.Add(Me.lblOR)
        Me.pnlPayment.Controls.Add(Me.txtOR)
        Me.pnlPayment.Controls.Add(Me.lblDate)
        Me.pnlPayment.Controls.Add(Me.dtpDate)
        Me.pnlPayment.Controls.Add(Me.lblCashier)
        Me.pnlPayment.Controls.Add(Me.txtCashier)
        Me.pnlPayment.Controls.Add(Me.lblStatus)
        Me.pnlPayment.Controls.Add(Me.txtStatus)
        Me.pnlPayment.Location = New System.Drawing.Point(340, 80)
        Me.pnlPayment.Name = "pnlPayment"
        Me.pnlPayment.Size = New System.Drawing.Size(380, 580)
        Me.pnlPayment.TabIndex = 2
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(20, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total Tuition"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(20, 50)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(200, 22)
        Me.txtTotal.TabIndex = 1
        '
        'lblPaid
        '
        Me.lblPaid.Location = New System.Drawing.Point(20, 90)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(100, 23)
        Me.lblPaid.TabIndex = 2
        Me.lblPaid.Text = "Total Paid"
        '
        'txtPaid
        '
        Me.txtPaid.Location = New System.Drawing.Point(20, 120)
        Me.txtPaid.Name = "txtPaid"
        Me.txtPaid.Size = New System.Drawing.Size(200, 22)
        Me.txtPaid.TabIndex = 3
        '
        'lblBalance
        '
        Me.lblBalance.Location = New System.Drawing.Point(20, 160)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(100, 23)
        Me.lblBalance.TabIndex = 4
        Me.lblBalance.Text = "Remaining Balance"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(20, 190)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(200, 22)
        Me.txtBalance.TabIndex = 5
        '
        'lblAmount
        '
        Me.lblAmount.Location = New System.Drawing.Point(20, 230)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblAmount.TabIndex = 6
        Me.lblAmount.Text = "Payment Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(20, 260)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 22)
        Me.txtAmount.TabIndex = 7
        '
        'lblType
        '
        Me.lblType.Location = New System.Drawing.Point(20, 300)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(100, 23)
        Me.lblType.TabIndex = 8
        Me.lblType.Text = "Payment Type"
        '
        'cmbType
        '
        Me.cmbType.Items.AddRange(New Object() {"Cash", "Partial", "Full"})
        Me.cmbType.Location = New System.Drawing.Point(20, 330)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(200, 24)
        Me.cmbType.TabIndex = 9
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Green
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(20, 370)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 10
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(120, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "CLEAR"
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.Blue
        Me.btnReceipt.ForeColor = System.Drawing.Color.White
        Me.btnReceipt.Location = New System.Drawing.Point(20, 410)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnReceipt.TabIndex = 12
        Me.btnReceipt.Text = "RECEIPT"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'lblOR
        '
        Me.lblOR.Location = New System.Drawing.Point(20, 460)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(100, 23)
        Me.lblOR.TabIndex = 13
        Me.lblOR.Text = "OR Number"
        '
        'txtOR
        '
        Me.txtOR.Location = New System.Drawing.Point(20, 490)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(150, 22)
        Me.txtOR.TabIndex = 14
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(200, 460)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(200, 490)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpDate.TabIndex = 16
        '
        'lblCashier
        '
        Me.lblCashier.Location = New System.Drawing.Point(20, 530)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(100, 23)
        Me.lblCashier.TabIndex = 17
        Me.lblCashier.Text = "Cashier"
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(20, 560)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.Size = New System.Drawing.Size(150, 22)
        Me.txtCashier.TabIndex = 18
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(200, 530)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 23)
        Me.lblStatus.TabIndex = 19
        Me.lblStatus.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(200, 560)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(150, 22)
        Me.txtStatus.TabIndex = 20
        '
        'pnlHistory
        '
        Me.pnlHistory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlHistory.Controls.Add(Me.lblHistory)
        Me.pnlHistory.Controls.Add(Me.dgvHistory)
        Me.pnlHistory.Controls.Add(Me.txtSearchHistory)
        Me.pnlHistory.Controls.Add(Me.btnSearchHistory)
        Me.pnlHistory.Location = New System.Drawing.Point(740, 80)
        Me.pnlHistory.Name = "pnlHistory"
        Me.pnlHistory.Size = New System.Drawing.Size(330, 580)
        Me.pnlHistory.TabIndex = 3
        '
        'lblHistory
        '
        Me.lblHistory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHistory.Location = New System.Drawing.Point(20, 20)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(100, 23)
        Me.lblHistory.TabIndex = 0
        Me.lblHistory.Text = "Payment History"
        '
        'dgvHistory
        '
        Me.dgvHistory.ColumnHeadersHeight = 29
        Me.dgvHistory.Location = New System.Drawing.Point(20, 50)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowHeadersWidth = 51
        Me.dgvHistory.Size = New System.Drawing.Size(290, 450)
        Me.dgvHistory.TabIndex = 1
        '
        'txtSearchHistory
        '
        Me.txtSearchHistory.Location = New System.Drawing.Point(20, 510)
        Me.txtSearchHistory.Name = "txtSearchHistory"
        Me.txtSearchHistory.Size = New System.Drawing.Size(180, 22)
        Me.txtSearchHistory.TabIndex = 2
        '
        'btnSearchHistory
        '
        Me.btnSearchHistory.Location = New System.Drawing.Point(210, 510)
        Me.btnSearchHistory.Name = "btnSearchHistory"
        Me.btnSearchHistory.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchHistory.TabIndex = 3
        Me.btnSearchHistory.Text = "Search"
        '
        'CashierForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlStudent)
        Me.Controls.Add(Me.pnlPayment)
        Me.Controls.Add(Me.pnlHistory)
        Me.Name = "CashierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier Module"
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.pnlPayment.ResumeLayout(False)
        Me.pnlPayment.PerformLayout()
        Me.pnlHistory.ResumeLayout(False)
        Me.pnlHistory.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ================= DECLARATIONS =================
    Friend WithEvents lblTitle As Label

    Friend WithEvents pnlStudent As Panel
    Friend WithEvents pnlPayment As Panel
    Friend WithEvents pnlHistory As Panel

    Friend WithEvents lblStudentID As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents btnSearch As Button

    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtCourse As TextBox

    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblPaid As Label
    Friend WithEvents txtPaid As TextBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtBalance As TextBox

    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents cmbType As ComboBox

    Friend WithEvents btnPay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnReceipt As Button

    Friend WithEvents lblOR As Label
    Friend WithEvents txtOR As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblCashier As Label
    Friend WithEvents txtCashier As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtStatus As TextBox

    Friend WithEvents lblHistory As Label
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents txtSearchHistory As TextBox
    Friend WithEvents btnSearchHistory As Button

End Class