<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmbBilling = New System.Windows.Forms.ComboBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgvPayments = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(250, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(538, 53)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PAYMENT / CASHIERING"
        '
        'cmbBilling
        '
        Me.cmbBilling.Location = New System.Drawing.Point(20, 70)
        Me.cmbBilling.Name = "cmbBilling"
        Me.cmbBilling.Size = New System.Drawing.Size(200, 24)
        Me.cmbBilling.TabIndex = 1
        '
        'lblBalance
        '
        Me.lblBalance.Location = New System.Drawing.Point(240, 70)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(100, 23)
        Me.lblBalance.TabIndex = 2
        Me.lblBalance.Text = "Balance: 0"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(420, 70)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(150, 22)
        Me.txtAmount.TabIndex = 3
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.ForeColor = System.Drawing.Color.White
        Me.btnPay.Location = New System.Drawing.Point(20, 110)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPay.TabIndex = 4
        Me.btnPay.Text = "Pay"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(120, 110)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        '
        'dgvPayments
        '
        Me.dgvPayments.ColumnHeadersHeight = 29
        Me.dgvPayments.Location = New System.Drawing.Point(20, 160)
        Me.dgvPayments.Name = "dgvPayments"
        Me.dgvPayments.RowHeadersWidth = 51
        Me.dgvPayments.Size = New System.Drawing.Size(740, 200)
        Me.dgvPayments.TabIndex = 6
        '
        'PaymentForm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cmbBilling)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgvPayments)
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Module"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cmbBilling As ComboBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents dgvPayments As DataGridView

End Class