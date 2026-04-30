<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.lblSchoolSub = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.pnlDivider = New System.Windows.Forms.Panel()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.pnlCardTop = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblSubWelcome = New System.Windows.Forms.Label()
        Me.pnlCardBody = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.pnlBackground.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.pnlCardTop.SuspendLayout()
        Me.pnlCardBody.SuspendLayout()
        Me.SuspendLayout()

        ' ===== FORM =====
        Me.ClientSize = New System.Drawing.Size(1100, 650)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enrollment System — Login"
        Me.BackColor = System.Drawing.Color.FromArgb(237, 233, 254)
        Me.Name = "Login"

        ' ===== BACKGROUND PANEL (full form) =====
        Me.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBackground.BackColor = System.Drawing.Color.FromArgb(237, 233, 254)
        Me.pnlBackground.Controls.Add(Me.pnlLeft)
        Me.pnlBackground.Controls.Add(Me.pnlCard)

        ' ===== LEFT PANEL =====
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Size = New System.Drawing.Size(480, 650)
        Me.pnlLeft.Controls.Add(Me.lblSchoolName)
        Me.pnlLeft.Controls.Add(Me.lblSchoolSub)
        Me.pnlLeft.Controls.Add(Me.lblBrand)
        Me.pnlLeft.Controls.Add(Me.lblTagline)
        Me.pnlLeft.Controls.Add(Me.pnlDivider)

        ' School icon/logo label (emoji as placeholder)
        Me.lblSchoolName.Text = "🎓"
        Me.lblSchoolName.Font = New System.Drawing.Font("Segoe UI", 52.0!)
        Me.lblSchoolName.ForeColor = System.Drawing.Color.White
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.Location = New System.Drawing.Point(175, 100)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.TabIndex = 0

        ' School subtitle
        Me.lblSchoolSub.Text = "ENROLLMENT SYSTEM"
        Me.lblSchoolSub.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSchoolSub.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblSchoolSub.AutoSize = True
        Me.lblSchoolSub.Location = New System.Drawing.Point(130, 175)
        Me.lblSchoolSub.Name = "lblSchoolSub"
        Me.lblSchoolSub.TabIndex = 1

        ' Divider line
        Me.pnlDivider.BackColor = System.Drawing.Color.FromArgb(139, 92, 246)
        Me.pnlDivider.Location = New System.Drawing.Point(60, 230)
        Me.pnlDivider.Size = New System.Drawing.Size(360, 2)
        Me.pnlDivider.Name = "pnlDivider"
        Me.pnlDivider.TabIndex = 2

        ' Brand name
        Me.lblBrand.Text = "EduEnroll"
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 34.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(100, 255)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.TabIndex = 3

        ' Tagline
        Me.lblTagline.Text = "Smart Enrollment," & vbCrLf & "Simplified."
        Me.lblTagline.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblTagline.ForeColor = System.Drawing.Color.FromArgb(221, 214, 254)
        Me.lblTagline.AutoSize = True
        Me.lblTagline.Location = New System.Drawing.Point(100, 340)
        Me.lblTagline.Name = "lblTagline"
        Me.lblTagline.TabIndex = 4

        ' ===== RIGHT CARD =====
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Size = New System.Drawing.Size(440, 520)
        Me.pnlCard.Location = New System.Drawing.Point(530, 65)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.TabIndex = 1
        Me.pnlCard.Controls.Add(Me.pnlCardTop)
        Me.pnlCard.Controls.Add(Me.pnlCardBody)

        ' Card top colored strip
        Me.pnlCardTop.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.pnlCardTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCardTop.Height = 10
        Me.pnlCardTop.Name = "pnlCardTop"
        Me.pnlCardTop.TabIndex = 0
        Me.pnlCardTop.Controls.Add(Me.lblWelcome)
        Me.pnlCardTop.Controls.Add(Me.lblSubWelcome)

        ' Welcome label (placed in card body area, not in strip)
        Me.lblWelcome.Text = "Welcome Back!"
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(49, 46, 129)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(40, 30)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.TabIndex = 0

        Me.lblSubWelcome.Text = "Sign in to your account to continue"
        Me.lblSubWelcome.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubWelcome.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
        Me.lblSubWelcome.AutoSize = True
        Me.lblSubWelcome.Location = New System.Drawing.Point(40, 65)
        Me.lblSubWelcome.Name = "lblSubWelcome"
        Me.lblSubWelcome.TabIndex = 1

        ' Card body panel
        Me.pnlCardBody.BackColor = System.Drawing.Color.White
        Me.pnlCardBody.Location = New System.Drawing.Point(0, 10)
        Me.pnlCardBody.Size = New System.Drawing.Size(440, 510)
        Me.pnlCardBody.Name = "pnlCardBody"
        Me.pnlCardBody.TabIndex = 1
        Me.pnlCardBody.Controls.Add(Me.lblWelcome)
        Me.pnlCardBody.Controls.Add(Me.lblSubWelcome)
        Me.pnlCardBody.Controls.Add(Me.lblUsername)
        Me.pnlCardBody.Controls.Add(Me.txtUsername)
        Me.pnlCardBody.Controls.Add(Me.lblPassword)
        Me.pnlCardBody.Controls.Add(Me.txtPassword)
        Me.pnlCardBody.Controls.Add(Me.btnLogin)
        Me.pnlCardBody.Controls.Add(Me.lblFooter)

        ' Username label
        Me.lblUsername.Text = "👤  Username"
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(40, 120)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.TabIndex = 2

        ' Username textbox
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(49, 46, 129)
        Me.txtUsername.Location = New System.Drawing.Point(40, 145)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(360, 32)
        Me.txtUsername.TabIndex = 3

        ' Password label
        Me.lblPassword.Text = "🔒  Password"
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(40, 200)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.TabIndex = 4

        ' Password textbox
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 243, 255)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(49, 46, 129)
        Me.txtPassword.Location = New System.Drawing.Point(40, 225)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(360, 32)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True

        ' Login button
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(67, 56, 202)
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(40, 295)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(360, 50)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Sign In  →"
        Me.btnLogin.UseVisualStyleBackColor = False

        ' Footer label
        Me.lblFooter.Text = "© 2025 EduEnroll  •  All rights reserved"
        Me.lblFooter.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblFooter.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175)
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Location = New System.Drawing.Point(95, 380)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.TabIndex = 7

        ' ===== ADD TO FORM =====
        Me.Controls.Add(Me.pnlBackground)

        Me.pnlBackground.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCardTop.ResumeLayout(False)
        Me.pnlCardTop.PerformLayout()
        Me.pnlCardBody.ResumeLayout(False)
        Me.pnlCardBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBackground As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents lblSchoolName As System.Windows.Forms.Label
    Friend WithEvents lblSchoolSub As System.Windows.Forms.Label
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblTagline As System.Windows.Forms.Label
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents pnlCardTop As System.Windows.Forms.Panel
    Friend WithEvents pnlCardBody As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblSubWelcome As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblFooter As System.Windows.Forms.Label
End Class
