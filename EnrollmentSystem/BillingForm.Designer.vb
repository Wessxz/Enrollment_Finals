<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillingForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlStudent = New System.Windows.Forms.Panel()
        Me.cmbStudentID = New System.Windows.Forms.ComboBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.pnlFees = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPaymentType = New System.Windows.Forms.ComboBox()
        Me.lblBreakdown = New System.Windows.Forms.Label()
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.txtTuition = New System.Windows.Forms.TextBox()
        Me.lblMisc = New System.Windows.Forms.Label()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.lblLab = New System.Windows.Forms.Label()
        Me.txtLab = New System.Windows.Forms.TextBox()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblBillingList = New System.Windows.Forms.Label()
        Me.dgvBilling = New System.Windows.Forms.DataGridView()
        Me.pnlStudent.SuspendLayout()
        Me.pnlFees.SuspendLayout()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(300, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(359, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "BILLING MANAGEMENT"
        '
        'pnlStudent
        '
        Me.pnlStudent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlStudent.Controls.Add(Me.cmbStudentID)
        Me.pnlStudent.Controls.Add(Me.lblStudentID)
        Me.pnlStudent.Controls.Add(Me.lblStudentName)
        Me.pnlStudent.Controls.Add(Me.txtStudentName)
        Me.pnlStudent.Controls.Add(Me.lblCourse)
        Me.pnlStudent.Controls.Add(Me.txtCourse)
        Me.pnlStudent.Location = New System.Drawing.Point(20, 80)
        Me.pnlStudent.Name = "pnlStudent"
        Me.pnlStudent.Size = New System.Drawing.Size(300, 200)
        Me.pnlStudent.TabIndex = 1
        '
        'cmbStudentID
        '
        Me.cmbStudentID.FormattingEnabled = True
        Me.cmbStudentID.Location = New System.Drawing.Point(23, 47)
        Me.cmbStudentID.Name = "cmbStudentID"
        Me.cmbStudentID.Size = New System.Drawing.Size(247, 24)
        Me.cmbStudentID.TabIndex = 7
        '
        'lblStudentID
        '
        Me.lblStudentID.Location = New System.Drawing.Point(20, 20)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'lblStudentName
        '
        Me.lblStudentName.Location = New System.Drawing.Point(20, 120)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(100, 23)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(20, 145)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(250, 22)
        Me.txtStudentName.TabIndex = 4
        '
        'lblCourse
        '
        Me.lblCourse.Location = New System.Drawing.Point(20, 175)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 23)
        Me.lblCourse.TabIndex = 5
        Me.lblCourse.Text = "Course"
        '
        'txtCourse
        '
        Me.txtCourse.Location = New System.Drawing.Point(20, 200)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(250, 22)
        Me.txtCourse.TabIndex = 6
        '
        'pnlFees
        '
        Me.pnlFees.Controls.Add(Me.Label1)
        Me.pnlFees.Controls.Add(Me.cmbPaymentType)
        Me.pnlFees.Controls.Add(Me.lblBreakdown)
        Me.pnlFees.Controls.Add(Me.lblTuition)
        Me.pnlFees.Controls.Add(Me.txtTuition)
        Me.pnlFees.Controls.Add(Me.lblMisc)
        Me.pnlFees.Controls.Add(Me.txtMisc)
        Me.pnlFees.Controls.Add(Me.lblLab)
        Me.pnlFees.Controls.Add(Me.txtLab)
        Me.pnlFees.Controls.Add(Me.lblOther)
        Me.pnlFees.Controls.Add(Me.txtOther)
        Me.pnlFees.Controls.Add(Me.lblTotal)
        Me.pnlFees.Controls.Add(Me.txtTotal)
        Me.pnlFees.Controls.Add(Me.btnCompute)
        Me.pnlFees.Controls.Add(Me.btnSave)
        Me.pnlFees.Controls.Add(Me.btnClear)
        Me.pnlFees.Location = New System.Drawing.Point(340, 80)
        Me.pnlFees.Name = "pnlFees"
        Me.pnlFees.Size = New System.Drawing.Size(519, 350)
        Me.pnlFees.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(254, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Payment Type"
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.FormattingEnabled = True
        Me.cmbPaymentType.Items.AddRange(New Object() {"Full Payment", "Partial Payment"})
        Me.cmbPaymentType.Location = New System.Drawing.Point(257, 47)
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.Size = New System.Drawing.Size(247, 24)
        Me.cmbPaymentType.TabIndex = 8
        '
        'lblBreakdown
        '
        Me.lblBreakdown.AutoSize = True
        Me.lblBreakdown.Location = New System.Drawing.Point(318, 140)
        Me.lblBreakdown.Name = "lblBreakdown"
        Me.lblBreakdown.Size = New System.Drawing.Size(48, 16)
        Me.lblBreakdown.TabIndex = 13
        Me.lblBreakdown.Text = "Label1"
        '
        'lblTuition
        '
        Me.lblTuition.Location = New System.Drawing.Point(20, 20)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(100, 23)
        Me.lblTuition.TabIndex = 0
        Me.lblTuition.Text = "Tuition Fee"
        '
        'txtTuition
        '
        Me.txtTuition.Location = New System.Drawing.Point(20, 45)
        Me.txtTuition.Name = "txtTuition"
        Me.txtTuition.ReadOnly = True
        Me.txtTuition.Size = New System.Drawing.Size(200, 22)
        Me.txtTuition.TabIndex = 1
        '
        'lblMisc
        '
        Me.lblMisc.Location = New System.Drawing.Point(20, 80)
        Me.lblMisc.Name = "lblMisc"
        Me.lblMisc.Size = New System.Drawing.Size(100, 23)
        Me.lblMisc.TabIndex = 2
        Me.lblMisc.Text = "Miscellaneous Fee"
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(20, 105)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(200, 22)
        Me.txtMisc.TabIndex = 3
        '
        'lblLab
        '
        Me.lblLab.Location = New System.Drawing.Point(20, 140)
        Me.lblLab.Name = "lblLab"
        Me.lblLab.Size = New System.Drawing.Size(100, 23)
        Me.lblLab.TabIndex = 4
        Me.lblLab.Text = "Laboratory Fee"
        '
        'txtLab
        '
        Me.txtLab.Location = New System.Drawing.Point(20, 165)
        Me.txtLab.Name = "txtLab"
        Me.txtLab.Size = New System.Drawing.Size(200, 22)
        Me.txtLab.TabIndex = 5
        '
        'lblOther
        '
        Me.lblOther.Location = New System.Drawing.Point(20, 200)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(100, 23)
        Me.lblOther.TabIndex = 6
        Me.lblOther.Text = "Other Fees"
        '
        'txtOther
        '
        Me.txtOther.Location = New System.Drawing.Point(20, 225)
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(200, 22)
        Me.txtOther.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(20, 260)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total Amount"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(20, 285)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(200, 22)
        Me.txtTotal.TabIndex = 9
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(20, 320)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 10
        Me.btnCompute.Text = "Compute"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(110, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(190, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        '
        'lblBillingList
        '
        Me.lblBillingList.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblBillingList.Location = New System.Drawing.Point(56, 365)
        Me.lblBillingList.Name = "lblBillingList"
        Me.lblBillingList.Size = New System.Drawing.Size(100, 23)
        Me.lblBillingList.TabIndex = 3
        Me.lblBillingList.Text = "Billing Records"
        '
        'dgvBilling
        '
        Me.dgvBilling.ColumnHeadersHeight = 29
        Me.dgvBilling.Location = New System.Drawing.Point(20, 445)
        Me.dgvBilling.Name = "dgvBilling"
        Me.dgvBilling.RowHeadersWidth = 51
        Me.dgvBilling.Size = New System.Drawing.Size(940, 230)
        Me.dgvBilling.TabIndex = 4
        '
        'BillingForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 687)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlStudent)
        Me.Controls.Add(Me.pnlFees)
        Me.Controls.Add(Me.lblBillingList)
        Me.Controls.Add(Me.dgvBilling)
        Me.Name = "BillingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Management"
        Me.pnlStudent.ResumeLayout(False)
        Me.pnlStudent.PerformLayout()
        Me.pnlFees.ResumeLayout(False)
        Me.pnlFees.PerformLayout()
        CType(Me.dgvBilling, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ================= DECLARATIONS =================
    Friend WithEvents lblTitle As Label

    Friend WithEvents pnlStudent As Panel
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtCourse As TextBox

    Friend WithEvents pnlFees As Panel
    Friend WithEvents lblTuition As Label
    Friend WithEvents txtTuition As TextBox
    Friend WithEvents lblMisc As Label
    Friend WithEvents txtMisc As TextBox
    Friend WithEvents lblLab As Label
    Friend WithEvents txtLab As TextBox
    Friend WithEvents lblOther As Label
    Friend WithEvents txtOther As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox

    Friend WithEvents btnCompute As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents lblBillingList As Label
    Friend WithEvents dgvBilling As DataGridView
    Friend WithEvents cmbStudentID As ComboBox
    Friend WithEvents lblBreakdown As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPaymentType As ComboBox
End Class