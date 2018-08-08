<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.TxtTitle = New System.Windows.Forms.GroupBox
        Me.txtDr = New System.Windows.Forms.RadioButton
        Me.txtMr = New System.Windows.Forms.RadioButton
        Me.txtMrs = New System.Windows.Forms.RadioButton
        Me.txtMiss = New System.Windows.Forms.RadioButton
        Me.txtMs = New System.Windows.Forms.RadioButton
        Me.Label31 = New System.Windows.Forms.Label
        Me.TxtID = New System.Windows.Forms.TextBox
        Me.TxtQuestion = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtpass1 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtPass = New System.Windows.Forms.TextBox
        Me.cancel = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.Txtcity = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.TxtSurname = New System.Windows.Forms.TextBox
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtage = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtcounty = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtpost = New System.Windows.Forms.TextBox
        Me.TxtTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtTitle
        '
        Me.TxtTitle.Controls.Add(Me.txtDr)
        Me.TxtTitle.Controls.Add(Me.txtMr)
        Me.TxtTitle.Controls.Add(Me.txtMrs)
        Me.TxtTitle.Controls.Add(Me.txtMiss)
        Me.TxtTitle.Controls.Add(Me.txtMs)
        Me.TxtTitle.Location = New System.Drawing.Point(200, 343)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(247, 38)
        Me.TxtTitle.TabIndex = 148
        Me.TxtTitle.TabStop = False
        '
        'txtDr
        '
        Me.txtDr.AutoSize = True
        Me.txtDr.Location = New System.Drawing.Point(180, 15)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(36, 17)
        Me.txtDr.TabIndex = 70
        Me.txtDr.TabStop = True
        Me.txtDr.Text = "Dr"
        Me.txtDr.UseVisualStyleBackColor = True
        '
        'txtMr
        '
        Me.txtMr.AutoSize = True
        Me.txtMr.Location = New System.Drawing.Point(6, 15)
        Me.txtMr.Name = "txtMr"
        Me.txtMr.Size = New System.Drawing.Size(37, 17)
        Me.txtMr.TabIndex = 66
        Me.txtMr.TabStop = True
        Me.txtMr.Text = "Mr"
        Me.txtMr.UseVisualStyleBackColor = True
        '
        'txtMrs
        '
        Me.txtMrs.AutoSize = True
        Me.txtMrs.Location = New System.Drawing.Point(51, 15)
        Me.txtMrs.Name = "txtMrs"
        Me.txtMrs.Size = New System.Drawing.Size(42, 17)
        Me.txtMrs.TabIndex = 67
        Me.txtMrs.TabStop = True
        Me.txtMrs.Text = "Mrs"
        Me.txtMrs.UseVisualStyleBackColor = True
        '
        'txtMiss
        '
        Me.txtMiss.AutoSize = True
        Me.txtMiss.Location = New System.Drawing.Point(93, 15)
        Me.txtMiss.Name = "txtMiss"
        Me.txtMiss.Size = New System.Drawing.Size(46, 17)
        Me.txtMiss.TabIndex = 68
        Me.txtMiss.TabStop = True
        Me.txtMiss.Text = "Miss"
        Me.txtMiss.UseVisualStyleBackColor = True
        '
        'txtMs
        '
        Me.txtMs.AutoSize = True
        Me.txtMs.Location = New System.Drawing.Point(141, 15)
        Me.txtMs.Name = "txtMs"
        Me.txtMs.Size = New System.Drawing.Size(39, 17)
        Me.txtMs.TabIndex = 69
        Me.txtMs.TabStop = True
        Me.txtMs.Text = "Ms"
        Me.txtMs.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(174, 187)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(18, 13)
        Me.Label31.TabIndex = 147
        Me.Label31.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(199, 184)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.ReadOnly = True
        Me.TxtID.Size = New System.Drawing.Size(92, 20)
        Me.TxtID.TabIndex = 146
        '
        'TxtQuestion
        '
        Me.TxtQuestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtQuestion.FormattingEnabled = True
        Me.TxtQuestion.Items.AddRange(New Object() {"Name of first pet?", "Mother's maiden name?", "Favourite food?", "Make of first car?", "Name of school?", "Favourite colour?"})
        Me.TxtQuestion.Location = New System.Drawing.Point(199, 290)
        Me.TxtQuestion.Name = "TxtQuestion"
        Me.TxtQuestion.Size = New System.Drawing.Size(172, 21)
        Me.TxtQuestion.TabIndex = 145
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.Green
        Me.Label29.Location = New System.Drawing.Point(377, 298)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 13)
        Me.Label29.TabIndex = 144
        Me.Label29.Text = "* "
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(112, 293)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 13)
        Me.Label30.TabIndex = 143
        Me.Label30.Text = "Secret Question"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Green
        Me.Label27.Location = New System.Drawing.Point(316, 322)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 13)
        Me.Label27.TabIndex = 142
        Me.Label27.Text = "* "
        Me.Label27.Visible = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(112, 320)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(82, 13)
        Me.Label28.TabIndex = 141
        Me.Label28.Text = "Secrect Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAnswer.Location = New System.Drawing.Point(199, 317)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(111, 20)
        Me.txtAnswer.TabIndex = 140
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Green
        Me.Label24.Location = New System.Drawing.Point(316, 267)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 13)
        Me.Label24.TabIndex = 139
        Me.Label24.Text = "* "
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Green
        Me.Label25.Location = New System.Drawing.Point(316, 239)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 13)
        Me.Label25.TabIndex = 138
        Me.Label25.Text = "* "
        Me.Label25.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(101, 267)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 13)
        Me.Label21.TabIndex = 137
        Me.Label21.Text = "Confirm Password"
        '
        'txtpass1
        '
        Me.txtpass1.Location = New System.Drawing.Point(199, 264)
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass1.Size = New System.Drawing.Size(111, 20)
        Me.txtpass1.TabIndex = 136
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(139, 239)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 135
        Me.Label22.Text = "Password"
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(199, 236)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(111, 20)
        Me.TxtPass.TabIndex = 134
        '
        'cancel
        '
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancel.Location = New System.Drawing.Point(251, 654)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(105, 26)
        Me.cancel.TabIndex = 133
        Me.cancel.Text = "Exit"
        Me.cancel.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button5.Location = New System.Drawing.Point(122, 654)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(105, 26)
        Me.Button5.TabIndex = 132
        Me.Button5.Text = "Submit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Green
        Me.Label18.Location = New System.Drawing.Point(297, 217)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 13)
        Me.Label18.TabIndex = 131
        Me.Label18.Text = "* "
        Me.Label18.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Green
        Me.Label17.Location = New System.Drawing.Point(298, 593)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 13)
        Me.Label17.TabIndex = 130
        Me.Label17.Text = "* "
        Me.Label17.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Green
        Me.Label16.Location = New System.Drawing.Point(298, 567)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 13)
        Me.Label16.TabIndex = 129
        Me.Label16.Text = "* "
        Me.Label16.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(298, 541)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 13)
        Me.Label15.TabIndex = 128
        Me.Label15.Text = "* "
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(298, 487)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 13)
        Me.Label14.TabIndex = 127
        Me.Label14.Text = "* "
        Me.Label14.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(298, 423)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 13)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "* "
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(298, 394)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "* "
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Green
        Me.Label10.Location = New System.Drawing.Point(185, 627)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 124
        Me.Label10.Text = "*Field must be filled in"
        Me.Label10.Visible = False
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(199, 210)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(92, 20)
        Me.txtemail.TabIndex = 123
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(200, 586)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(92, 20)
        Me.txtcontactno.TabIndex = 122
        '
        'Txtcity
        '
        Me.Txtcity.Location = New System.Drawing.Point(200, 534)
        Me.Txtcity.Name = "Txtcity"
        Me.Txtcity.Size = New System.Drawing.Size(92, 20)
        Me.Txtcity.TabIndex = 120
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(200, 480)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(92, 20)
        Me.txtaddress.TabIndex = 119
        '
        'TxtSurname
        '
        Me.TxtSurname.Location = New System.Drawing.Point(200, 416)
        Me.TxtSurname.Name = "TxtSurname"
        Me.TxtSurname.Size = New System.Drawing.Size(92, 20)
        Me.TxtSurname.TabIndex = 118
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(200, 387)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(92, 20)
        Me.TxtName.TabIndex = 117
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(160, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 593)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Contact Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 567)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Postcode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 541)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 487)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 457)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Title"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(199, 450)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(92, 20)
        Me.txtage.TabIndex = 149
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(297, 514)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 13)
        Me.Label13.TabIndex = 152
        Me.Label13.Text = "* "
        Me.Label13.Visible = False
        '
        'txtcounty
        '
        Me.txtcounty.Location = New System.Drawing.Point(199, 507)
        Me.txtcounty.Name = "txtcounty"
        Me.txtcounty.Size = New System.Drawing.Size(92, 20)
        Me.txtcounty.TabIndex = 151
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(148, 514)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 150
        Me.Label19.Text = "County"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Green
        Me.Label20.Location = New System.Drawing.Point(297, 453)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 13)
        Me.Label20.TabIndex = 153
        Me.Label20.Text = "* "
        Me.Label20.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Green
        Me.Label23.Location = New System.Drawing.Point(453, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 13)
        Me.Label23.TabIndex = 154
        Me.Label23.Text = "* "
        Me.Label23.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 179)
        Me.PictureBox1.TabIndex = 155
        Me.PictureBox1.TabStop = False
        '
        'txtpost
        '
        Me.txtpost.Location = New System.Drawing.Point(201, 560)
        Me.txtpost.Name = "txtpost"
        Me.txtpost.Size = New System.Drawing.Size(92, 20)
        Me.txtpost.TabIndex = 156
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 474)
        Me.Controls.Add(Me.txtpost)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtcounty)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.TxtQuestion)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtpass1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtcontactno)
        Me.Controls.Add(Me.Txtcity)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.TxtSurname)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Register"
        Me.Text = "Register now!"
        Me.TxtTitle.ResumeLayout(False)
        Me.TxtTitle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtMr As System.Windows.Forms.RadioButton
    Friend WithEvents txtMrs As System.Windows.Forms.RadioButton
    Friend WithEvents txtMiss As System.Windows.Forms.RadioButton
    Friend WithEvents txtMs As System.Windows.Forms.RadioButton
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuestion As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtpass1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents Txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtSurname As System.Windows.Forms.TextBox
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcounty As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtDr As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtpost As System.Windows.Forms.TextBox
End Class
