<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnnouncementForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()

        Me.lblTitle = New Label()

        ' ================= INPUT PANEL =================
        Me.pnlInput = New Panel()

        Me.lblSubject = New Label()
        Me.txtSubject = New TextBox()

        Me.lblAudience = New Label()
        Me.cmbAudience = New ComboBox()

        Me.lblMessage = New Label()
        Me.txtMessage = New TextBox()

        Me.btnPost = New Button()
        Me.btnClear = New Button()

        ' ================= LIST PANEL =================
        Me.pnlList = New Panel()

        Me.lblHistory = New Label()
        Me.dgvAnnouncements = New DataGridView()

        CType(Me.dgvAnnouncements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ================= FORM =================
        Me.ClientSize = New Size(1100, 650)
        Me.Text = "Post Announcements"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White

        ' ================= TITLE =================
        Me.lblTitle.Text = "POST ANNOUNCEMENTS"
        Me.lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        Me.lblTitle.Location = New Point(380, 20)
        Me.lblTitle.AutoSize = True

        ' ================= INPUT PANEL =================
        Me.pnlInput.Location = New Point(30, 80)
        Me.pnlInput.Size = New Size(450, 520)
        Me.pnlInput.BackColor = Color.WhiteSmoke

        ' Subject
        Me.lblSubject.Text = "Subject"
        Me.lblSubject.Location = New Point(20, 20)

        Me.txtSubject.Location = New Point(20, 50)
        Me.txtSubject.Size = New Size(380, 25)

        ' Audience
        Me.lblAudience.Text = "Audience"
        Me.lblAudience.Location = New Point(20, 100)

        Me.cmbAudience.Location = New Point(20, 130)
        Me.cmbAudience.Size = New Size(200, 25)
        Me.cmbAudience.Items.AddRange(New Object() {"All Students", "Specific Course", "Faculty"})

        ' Message
        Me.lblMessage.Text = "Message"
        Me.lblMessage.Location = New Point(20, 180)

        Me.txtMessage.Location = New Point(20, 210)
        Me.txtMessage.Size = New Size(380, 200)
        Me.txtMessage.Multiline = True

        ' Buttons
        Me.btnPost.Text = "POST"
        Me.btnPost.Location = New Point(20, 430)
        Me.btnPost.BackColor = Color.FromArgb(46, 204, 113)
        Me.btnPost.ForeColor = Color.White
        Me.btnPost.FlatStyle = FlatStyle.Flat

        Me.btnClear.Text = "CLEAR"
        Me.btnClear.Location = New Point(120, 430)

        ' ================= LIST PANEL =================
        Me.pnlList.Location = New Point(520, 80)
        Me.pnlList.Size = New Size(540, 520)
        Me.pnlList.BackColor = Color.White

        Me.lblHistory.Text = "Announcement History"
        Me.lblHistory.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblHistory.Location = New Point(20, 20)
        Me.lblHistory.AutoSize = True

        Me.dgvAnnouncements.Location = New Point(20, 60)
        Me.dgvAnnouncements.Size = New Size(500, 440)

        ' ================= ADD CONTROLS =================
        Me.pnlInput.Controls.Add(Me.lblSubject)
        Me.pnlInput.Controls.Add(Me.txtSubject)
        Me.pnlInput.Controls.Add(Me.lblAudience)
        Me.pnlInput.Controls.Add(Me.cmbAudience)
        Me.pnlInput.Controls.Add(Me.lblMessage)
        Me.pnlInput.Controls.Add(Me.txtMessage)
        Me.pnlInput.Controls.Add(Me.btnPost)
        Me.pnlInput.Controls.Add(Me.btnClear)

        Me.pnlList.Controls.Add(Me.lblHistory)
        Me.pnlList.Controls.Add(Me.dgvAnnouncements)

        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlList)

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

End Class