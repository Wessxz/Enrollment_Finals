<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHiddenBillingID = New System.Windows.Forms.TextBox()
        Me.cmbStudentID = New System.Windows.Forms.ComboBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.pnlTuitionSection = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.txtPaid = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.txtTransactionDate = New System.Windows.Forms.TextBox()
        Me.lblOR = New System.Windows.Forms.Label()
        Me.txtOR = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblCashier = New System.Windows.Forms.Label()
        Me.txtCashier = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.pnlHistory = New System.Windows.Forms.Panel()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.txtSearchHistory = New System.Windows.Forms.TextBox()
        Me.btnSearchHistory = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDownPayment = New System.Windows.Forms.Button()
        Me.txtDownpayment = New System.Windows.Forms.TextBox()
        Me.grpDownPayment = New System.Windows.Forms.GroupBox()
        Me.pnlStudent.SuspendLayout()
        Me.pnlTuitionSection.SuspendLayout()
        Me.pnlHistory.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDownPayment.SuspendLayout()
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
        Me.pnlStudent.Controls.Add(Me.Label1)
        Me.pnlStudent.Controls.Add(Me.lblHiddenBillingID)
        Me.pnlStudent.Controls.Add(Me.cmbStudentID)
        Me.pnlStudent.Controls.Add(Me.lblStudentID)
        Me.pnlStudent.Controls.Add(Me.lblStudentName)
        Me.pnlStudent.Controls.Add(Me.txtStudentName)
        Me.pnlStudent.Controls.Add(Me.lblCourse)
        Me.pnlStudent.Controls.Add(Me.txtCourse)
        Me.pnlStudent.Location = New System.Drawing.Point(20, 80)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(300, 592)
        Me.pnlStudent.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Billing ID"
        '
        'lblHiddenBillingID
        '
        Me.lblHiddenBillingID.Location = New System.Drawing.Point(23, 332)
        Me.lblHiddenBillingID.Name = "lblHiddenBillingID"
        Me.lblHiddenBillingID.ReadOnly = True
        Me.lblHiddenBillingID.Size = New System.Drawing.Size(200, 22)
        Me.lblHiddenBillingID.TabIndex = 22
        '
        'cmbStudentID
        '
        Me.cmbStudentID.FormattingEnabled = True
        Me.cmbStudentID.Location = New System.Drawing.Point(23, 103)
        Me.cmbStudentID.Name = "cmbStudentID"
        Me.cmbStudentID.Size = New System.Drawing.Size(247, 24)
        Me.cmbStudentID.TabIndex = 7
        '
        'lblStudentID
        '
        Me.lblStudentID.Location = New System.Drawing.Point(20, 77)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
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
        'pnlTuitionSection
        '
        Me.pnlTuitionSection.Controls.Add(Me.lblTotal)
        Me.pnlTuitionSection.Controls.Add(Me.txtTotal)
        Me.pnlTuitionSection.Controls.Add(Me.lblPaid)
        Me.pnlTuitionSection.Controls.Add(Me.txtPaid)
        Me.pnlTuitionSection.Controls.Add(Me.lblBalance)
        Me.pnlTuitionSection.Controls.Add(Me.txtBalance)
        Me.pnlTuitionSection.Controls.Add(Me.lblAmount)
        Me.pnlTuitionSection.Controls.Add(Me.txtAmount)
        Me.pnlTuitionSection.Controls.Add(Me.btnPay)
        Me.pnlTuitionSection.Controls.Add(Me.btnReceipt)
        Me.pnlTuitionSection.Location = New System.Drawing.Point(340, 80)
        Me.pnlTuitionSection.Name = "pnlTuitionSection"
        Me.pnlTuitionSection.Size = New System.Drawing.Size(380, 315)
        Me.pnlTuitionSection.TabIndex = 2
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
        Me.txtTotal.ReadOnly = True
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
        Me.txtPaid.ReadOnly = True
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
        Me.txtBalance.ReadOnly = True
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
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.Green
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(275, 49)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 10
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.Blue
        Me.btnReceipt.ForeColor = System.Drawing.Color.White
        Me.btnReceipt.Location = New System.Drawing.Point(275, 90)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(75, 23)
        Me.btnReceipt.TabIndex = 12
        Me.btnReceipt.Text = "RECEIPT"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'txtTransactionDate
        '
        Me.txtTransactionDate.Location = New System.Drawing.Point(545, 541)
        Me.txtTransactionDate.Name = "txtTransactionDate"
        Me.txtTransactionDate.ReadOnly = True
        Me.txtTransactionDate.Size = New System.Drawing.Size(150, 22)
        Me.txtTransactionDate.TabIndex = 21
        '
        'lblOR
        '
        Me.lblOR.Location = New System.Drawing.Point(365, 515)
        Me.lblOR.Name = "lblOR"
        Me.lblOR.Size = New System.Drawing.Size(100, 23)
        Me.lblOR.TabIndex = 13
        Me.lblOR.Text = "OR Number"
        '
        'txtOR
        '
        Me.txtOR.Location = New System.Drawing.Point(365, 545)
        Me.txtOR.Name = "txtOR"
        Me.txtOR.ReadOnly = True
        Me.txtOR.Size = New System.Drawing.Size(150, 22)
        Me.txtOR.TabIndex = 14
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(545, 515)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 23)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Date"
        '
        'lblCashier
        '
        Me.lblCashier.Location = New System.Drawing.Point(365, 589)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(100, 23)
        Me.lblCashier.TabIndex = 17
        Me.lblCashier.Text = "Cashier"
        '
        'txtCashier
        '
        Me.txtCashier.Location = New System.Drawing.Point(365, 615)
        Me.txtCashier.Name = "txtCashier"
        Me.txtCashier.ReadOnly = True
        Me.txtCashier.Size = New System.Drawing.Size(150, 22)
        Me.txtCashier.TabIndex = 18
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(545, 589)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 23)
        Me.lblStatus.TabIndex = 19
        Me.lblStatus.Text = "Status"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(545, 615)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(150, 22)
        Me.txtStatus.TabIndex = 20
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(20, 539)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 22)
        Me.dtpDate.TabIndex = 16
        '
        'pnlHistory
        '
        Me.pnlHistory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlHistory.Controls.Add(Me.lblHistory)
        Me.pnlHistory.Controls.Add(Me.dgvHistory)
        Me.pnlHistory.Controls.Add(Me.txtSearchHistory)
        Me.pnlHistory.Controls.Add(Me.btnSearchHistory)
        Me.pnlHistory.Controls.Add(Me.dtpDate)
        Me.pnlHistory.Location = New System.Drawing.Point(740, 80)
        Me.pnlHistory.Name = "pnlHistory"
        Me.pnlHistory.Size = New System.Drawing.Size(452, 580)
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
        Me.dgvHistory.Size = New System.Drawing.Size(416, 450)
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
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Down Payment (min. ₱3,000)"
        '
        'btnDownPayment
        '
        Me.btnDownPayment.BackColor = System.Drawing.Color.Green
        Me.btnDownPayment.ForeColor = System.Drawing.Color.White
        Me.btnDownPayment.Location = New System.Drawing.Point(262, 35)
        Me.btnDownPayment.Name = "btnDownPayment"
        Me.btnDownPayment.Size = New System.Drawing.Size(75, 23)
        Me.btnDownPayment.TabIndex = 24
        Me.btnDownPayment.Text = "DOWN"
        Me.btnDownPayment.UseVisualStyleBackColor = False
        '
        'txtDownpayment
        '
        Me.txtDownpayment.Location = New System.Drawing.Point(19, 45)
        Me.txtDownpayment.Name = "txtDownpayment"
        Me.txtDownpayment.Size = New System.Drawing.Size(200, 22)
        Me.txtDownpayment.TabIndex = 25
        '
        'grpDownPayment
        '
        Me.grpDownPayment.Controls.Add(Me.txtDownpayment)
        Me.grpDownPayment.Controls.Add(Me.btnDownPayment)
        Me.grpDownPayment.Controls.Add(Me.Label2)
        Me.grpDownPayment.Location = New System.Drawing.Point(340, 412)
        Me.grpDownPayment.Name = "grpDownPayment"
        Me.grpDownPayment.Size = New System.Drawing.Size(380, 84)
        Me.grpDownPayment.TabIndex = 26
        Me.grpDownPayment.TabStop = False
        '
        'CashierForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1204, 747)
        Me.Controls.Add(Me.grpDownPayment)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlStudent)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pnlTuitionSection)
        Me.Controls.Add(Me.pnlHistory)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtCashier)
        Me.Controls.Add(Me.txtTransactionDate)
        Me.Controls.Add(Me.lblOR)
        Me.Controls.Add(Me.lblCashier)
        Me.Controls.Add(Me.txtOR)
        Me.Name = "CashierForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier Module"
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.pnlTuitionSection.ResumeLayout(False)
        Me.pnlTuitionSection.PerformLayout()
        Me.pnlHistory.ResumeLayout(False)
        Me.pnlHistory.PerformLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDownPayment.ResumeLayout(False)
        Me.grpDownPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ================= DECLARATIONS =================
    Friend WithEvents lblTitle As Label

    Friend WithEvents pnlStudent As Panel
    Friend WithEvents pnlTuitionSection As Panel
    Friend WithEvents pnlHistory As Panel

    Friend WithEvents lblStudentID As Label

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

    Friend WithEvents btnPay As Button
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
    Friend WithEvents cmbStudentID As ComboBox
    Friend WithEvents txtTransactionDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHiddenBillingID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDownPayment As Button
    Friend WithEvents txtDownpayment As TextBox
    Friend WithEvents grpDownPayment As GroupBox
End Class