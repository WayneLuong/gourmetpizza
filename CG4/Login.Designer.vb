<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboMemberId = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Log = New System.Windows.Forms.Button
        Me.llbladmin = New System.Windows.Forms.LinkLabel
        Me.Register = New System.Windows.Forms.LinkLabel
        Me.Forgotpwd = New System.Windows.Forms.LinkLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboMemberId)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.Log)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(121, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 184)
        Me.Panel1.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Logging in..."
        Me.Label4.Visible = False
        '
        'cboMemberId
        '
        Me.cboMemberId.FormattingEnabled = True
        Me.cboMemberId.Location = New System.Drawing.Point(108, 28)
        Me.cboMemberId.Name = "cboMemberId"
        Me.cboMemberId.Size = New System.Drawing.Size(111, 21)
        Me.cboMemberId.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Email"
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Location = New System.Drawing.Point(108, 91)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(111, 20)
        Me.txtpassword.TabIndex = 13
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.SystemColors.Window
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Location = New System.Drawing.Point(108, 55)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(111, 20)
        Me.txtemail.TabIndex = 12
        '
        'Log
        '
        Me.Log.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Log.Location = New System.Drawing.Point(89, 130)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(100, 28)
        Me.Log.TabIndex = 0
        Me.Log.Text = "Login"
        Me.Log.UseVisualStyleBackColor = True
        '
        'llbladmin
        '
        Me.llbladmin.AutoSize = True
        Me.llbladmin.Location = New System.Drawing.Point(463, 465)
        Me.llbladmin.Name = "llbladmin"
        Me.llbladmin.Size = New System.Drawing.Size(36, 13)
        Me.llbladmin.TabIndex = 22
        Me.llbladmin.TabStop = True
        Me.llbladmin.Text = "Admin"
        '
        'Register
        '
        Me.Register.AutoSize = True
        Me.Register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Register.Location = New System.Drawing.Point(228, 385)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(46, 13)
        Me.Register.TabIndex = 21
        Me.Register.TabStop = True
        Me.Register.Text = "Register"
        '
        'Forgotpwd
        '
        Me.Forgotpwd.AutoSize = True
        Me.Forgotpwd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Forgotpwd.Location = New System.Drawing.Point(209, 398)
        Me.Forgotpwd.Name = "Forgotpwd"
        Me.Forgotpwd.Size = New System.Drawing.Size(91, 13)
        Me.Forgotpwd.TabIndex = 20
        Me.Forgotpwd.TabStop = True
        Me.Forgotpwd.Text = "Forgot password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 179)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(167, 414)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(175, 23)
        Me.ProgressBar1.TabIndex = 24
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(511, 486)
        Me.Controls.Add(Me.llbladmin)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Forgotpwd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Customer login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Log As System.Windows.Forms.Button
    Friend WithEvents llbladmin As System.Windows.Forms.LinkLabel
    Friend WithEvents Register As System.Windows.Forms.LinkLabel
    Friend WithEvents Forgotpwd As System.Windows.Forms.LinkLabel
    Friend WithEvents cboMemberId As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
