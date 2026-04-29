<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnnouncementForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.lblAudience = New System.Windows.Forms.Label()
        Me.cmbAudience = New System.Windows.Forms.ComboBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnPost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlList = New System.Windows.Forms.Panel()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.dgvAnnouncements = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.pnlInput.SuspendLayout()
        Me.pnlList.SuspendLayout()
        CType(Me.dgvAnnouncements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(380, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(379, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "POST ANNOUNCEMENTS"
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlInput.Controls.Add(Me.btnDelete)
        Me.pnlInput.Controls.Add(Me.lblSubject)
        Me.pnlInput.Controls.Add(Me.txtSubject)
        Me.pnlInput.Controls.Add(Me.lblAudience)
        Me.pnlInput.Controls.Add(Me.cmbAudience)
        Me.pnlInput.Controls.Add(Me.lblMessage)
        Me.pnlInput.Controls.Add(Me.txtMessage)
        Me.pnlInput.Controls.Add(Me.btnPost)
        Me.pnlInput.Controls.Add(Me.btnClear)
        Me.pnlInput.Location = New System.Drawing.Point(30, 80)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(450, 520)
        Me.pnlInput.TabIndex = 1
        '
        'lblSubject
        '
        Me.lblSubject.Location = New System.Drawing.Point(20, 20)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(100, 23)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(20, 50)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(380, 22)
        Me.txtSubject.TabIndex = 1
        '
        'lblAudience
        '
        Me.lblAudience.Location = New System.Drawing.Point(20, 100)
        Me.lblAudience.Name = "lblAudience"
        Me.lblAudience.Size = New System.Drawing.Size(100, 23)
        Me.lblAudience.TabIndex = 2
        Me.lblAudience.Text = "Audience"
        '
        'cmbAudience
        '
        Me.cmbAudience.Items.AddRange(New Object() {"All Students", "Specific Course", "Faculty"})
        Me.cmbAudience.Location = New System.Drawing.Point(20, 130)
        Me.cmbAudience.Name = "cmbAudience"
        Me.cmbAudience.Size = New System.Drawing.Size(200, 24)
        Me.cmbAudience.TabIndex = 3
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(20, 180)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(100, 23)
        Me.lblMessage.TabIndex = 4
        Me.lblMessage.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(20, 210)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(380, 200)
        Me.txtMessage.TabIndex = 5
        '
        'btnPost
        '
        Me.btnPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPost.ForeColor = System.Drawing.Color.White
        Me.btnPost.Location = New System.Drawing.Point(20, 430)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(75, 23)
        Me.btnPost.TabIndex = 6
        Me.btnPost.Text = "POST"
        Me.btnPost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(223, 430)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "CLEAR"
        '
        'pnlList
        '
        Me.pnlList.BackColor = System.Drawing.Color.White
        Me.pnlList.Controls.Add(Me.lblHistory)
        Me.pnlList.Controls.Add(Me.dgvAnnouncements)
        Me.pnlList.Location = New System.Drawing.Point(520, 80)
        Me.pnlList.Name = "pnlList"
        Me.pnlList.Size = New System.Drawing.Size(540, 520)
        Me.pnlList.TabIndex = 2
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHistory.Location = New System.Drawing.Point(20, 20)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(195, 23)
        Me.lblHistory.TabIndex = 0
        Me.lblHistory.Text = "Announcement History"
        '
        'dgvAnnouncements
        '
        Me.dgvAnnouncements.ColumnHeadersHeight = 29
        Me.dgvAnnouncements.Location = New System.Drawing.Point(20, 60)
        Me.dgvAnnouncements.Name = "dgvAnnouncements"
        Me.dgvAnnouncements.RowHeadersWidth = 51
        Me.dgvAnnouncements.Size = New System.Drawing.Size(500, 440)
        Me.dgvAnnouncements.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(125, 430)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'AnnouncementForm
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlList)
        Me.Name = "AnnouncementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Post Announcements"
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlList.ResumeLayout(False)
        Me.pnlList.PerformLayout()
        CType(Me.dgvAnnouncements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label

    Friend WithEvents pnlInput As Panel
    Friend WithEvents pnlList As Panel

    Friend WithEvents lblSubject As Label
    Friend WithEvents txtSubject As TextBox

    Friend WithEvents lblAudience As Label
    Friend WithEvents cmbAudience As ComboBox

    Friend WithEvents lblMessage As Label
    Friend WithEvents txtMessage As TextBox

    Friend WithEvents btnPost As Button
    Friend WithEvents btnClear As Button

    Friend WithEvents lblHistory As Label   ' ✅ FIXED HERE
    Friend WithEvents dgvAnnouncements As DataGridView
    Friend WithEvents btnDelete As Button
End Class