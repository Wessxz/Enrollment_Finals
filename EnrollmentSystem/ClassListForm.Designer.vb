<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClassListForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()

        Me.lblTitle = New Label()

        ' ================= LEFT PANEL (CLASS LIST) =================
        Me.pnlClasses = New Panel()

        Me.lblSearch = New Label()
        Me.txtSearch = New TextBox()
        Me.dgvClasses = New DataGridView()

        ' ================= RIGHT PANEL (STUDENT LIST) =================
        Me.pnlStudents = New Panel()

        Me.lblClassInfo = New Label()
        Me.lblSubject = New Label()
        Me.lblCourse = New Label()
        Me.lblSchedule = New Label()
        Me.lblRoom = New Label()

        Me.dgvStudents = New DataGridView()

        CType(Me.dgvClasses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ================= FORM =================
        Me.ClientSize = New Size(1100, 650)
        Me.Text = "Class List"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.White

        ' ================= TITLE =================
        Me.lblTitle.Text = "CLASS LIST"
        Me.lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        Me.lblTitle.Location = New Point(450, 20)
        Me.lblTitle.AutoSize = True

        ' =====================================================
        ' LEFT PANEL - CLASSES
        ' =====================================================
        Me.pnlClasses.Location = New Point(20, 80)
        Me.pnlClasses.Size = New Size(350, 520)
        Me.pnlClasses.BackColor = Color.WhiteSmoke

        Me.lblSearch.Text = "Search Class"
        Me.lblSearch.Location = New Point(20, 20)

        Me.txtSearch.Location = New Point(20, 50)
        Me.txtSearch.Size = New Size(300, 25)

        Me.dgvClasses.Location = New Point(20, 90)
        Me.dgvClasses.Size = New Size(300, 400)

        ' =====================================================
        ' RIGHT PANEL - STUDENTS + CLASS INFO
        ' =====================================================
        Me.pnlStudents.Location = New Point(390, 80)
        Me.pnlStudents.Size = New Size(680, 520)
        Me.pnlStudents.BackColor = Color.White

        Me.lblClassInfo.Text = "CLASS INFORMATION"
        Me.lblClassInfo.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblClassInfo.Location = New Point(20, 20)
        Me.lblClassInfo.AutoSize = True

        Me.lblSubject.Text = "Subject: -"
        Me.lblSubject.Location = New Point(20, 60)

        Me.lblCourse.Text = "Course: -"
        Me.lblCourse.Location = New Point(20, 90)

        Me.lblSchedule.Text = "Schedule: -"
        Me.lblSchedule.Location = New Point(20, 120)

        Me.lblRoom.Text = "Room: -"
        Me.lblRoom.Location = New Point(20, 150)

        ' ================= STUDENT TABLE =================
        Me.dgvStudents.Location = New Point(20, 200)
        Me.dgvStudents.Size = New Size(630, 280)

        ' =====================================================
        ' ADD CONTROLS
        ' =====================================================

        Me.pnlClasses.Controls.Add(Me.lblSearch)
        Me.pnlClasses.Controls.Add(Me.txtSearch)
        Me.pnlClasses.Controls.Add(Me.dgvClasses)

        Me.pnlStudents.Controls.Add(Me.lblClassInfo)
        Me.pnlStudents.Controls.Add(Me.lblSubject)
        Me.pnlStudents.Controls.Add(Me.lblCourse)
        Me.pnlStudents.Controls.Add(Me.lblSchedule)
        Me.pnlStudents.Controls.Add(Me.lblRoom)
        Me.pnlStudents.Controls.Add(Me.dgvStudents)

        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pnlClasses)
        Me.Controls.Add(Me.pnlStudents)

        CType(Me.dgvClasses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label

    Friend WithEvents pnlClasses As Panel
    Friend WithEvents pnlStudents As Panel

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvClasses As DataGridView

    Friend WithEvents lblClassInfo As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblRoom As Label

    Friend WithEvents dgvStudents As DataGridView

End Class