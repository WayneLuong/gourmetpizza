<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboMemberId = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtDeleted = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbofullname = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Grptitle = New System.Windows.Forms.GroupBox
        Me.txtDr = New System.Windows.Forms.RadioButton
        Me.txtmiss = New System.Windows.Forms.RadioButton
        Me.txtMrs = New System.Windows.Forms.RadioButton
        Me.txtMr = New System.Windows.Forms.RadioButton
        Me.txtMs = New System.Windows.Forms.RadioButton
        Me.btnclear = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtPostcode = New System.Windows.Forms.TextBox
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcounty = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnviewall = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Grptitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Search by ID"
        '
        'cboMemberId
        '
        Me.cboMemberId.FormattingEnabled = True
        Me.cboMemberId.Location = New System.Drawing.Point(83, 30)
        Me.cboMemberId.Name = "cboMemberId"
        Me.cboMemberId.Size = New System.Drawing.Size(105, 21)
        Me.cboMemberId.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Deleted"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Name"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(73, 73)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(96, 20)
        Me.txtID.TabIndex = 17
        '
        'txtDeleted
        '
        Me.txtDeleted.Location = New System.Drawing.Point(73, 99)
        Me.txtDeleted.Name = "txtDeleted"
        Me.txtDeleted.ReadOnly = True
        Me.txtDeleted.Size = New System.Drawing.Size(98, 20)
        Me.txtDeleted.TabIndex = 16
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(73, 229)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(102, 20)
        Me.txtAge.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(73, 177)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(102, 20)
        Me.txtName.TabIndex = 14
        '
        'cmdDelete
        '
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDelete.Location = New System.Drawing.Point(226, 274)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(92, 27)
        Me.cmdDelete.TabIndex = 24
        Me.cmdDelete.Text = "Delete Record"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.Location = New System.Drawing.Point(18, 275)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(92, 26)
        Me.cmdSave.TabIndex = 25
        Me.cmdSave.Text = "Add "
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(207, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Search by Surname"
        '
        'cbofullname
        '
        Me.cbofullname.FormattingEnabled = True
        Me.cbofullname.Location = New System.Drawing.Point(313, 30)
        Me.cbofullname.Name = "cbofullname"
        Me.cbofullname.Size = New System.Drawing.Size(105, 21)
        Me.cbofullname.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(73, 203)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(102, 20)
        Me.txtSurname.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 127
        Me.Label8.Text = "Title"
        '
        'Grptitle
        '
        Me.Grptitle.Controls.Add(Me.txtDr)
        Me.Grptitle.Controls.Add(Me.txtmiss)
        Me.Grptitle.Controls.Add(Me.txtMrs)
        Me.Grptitle.Controls.Add(Me.txtMr)
        Me.Grptitle.Controls.Add(Me.txtMs)
        Me.Grptitle.Location = New System.Drawing.Point(73, 125)
        Me.Grptitle.Name = "Grptitle"
        Me.Grptitle.Size = New System.Drawing.Size(234, 39)
        Me.Grptitle.TabIndex = 128
        Me.Grptitle.TabStop = False
        '
        'txtDr
        '
        Me.txtDr.AutoSize = True
        Me.txtDr.Location = New System.Drawing.Point(194, 16)
        Me.txtDr.Name = "txtDr"
        Me.txtDr.Size = New System.Drawing.Size(36, 17)
        Me.txtDr.TabIndex = 4
        Me.txtDr.TabStop = True
        Me.txtDr.Text = "Dr"
        Me.txtDr.UseVisualStyleBackColor = True
        '
        'txtmiss
        '
        Me.txtmiss.AutoSize = True
        Me.txtmiss.Location = New System.Drawing.Point(97, 16)
        Me.txtmiss.Name = "txtmiss"
        Me.txtmiss.Size = New System.Drawing.Size(46, 17)
        Me.txtmiss.TabIndex = 3
        Me.txtmiss.TabStop = True
        Me.txtmiss.Text = "Miss"
        Me.txtmiss.UseVisualStyleBackColor = True
        '
        'txtMrs
        '
        Me.txtMrs.AutoSize = True
        Me.txtMrs.Location = New System.Drawing.Point(49, 16)
        Me.txtMrs.Name = "txtMrs"
        Me.txtMrs.Size = New System.Drawing.Size(42, 17)
        Me.txtMrs.TabIndex = 2
        Me.txtMrs.TabStop = True
        Me.txtMrs.Text = "Mrs"
        Me.txtMrs.UseVisualStyleBackColor = True
        '
        'txtMr
        '
        Me.txtMr.AutoSize = True
        Me.txtMr.Location = New System.Drawing.Point(6, 16)
        Me.txtMr.Name = "txtMr"
        Me.txtMr.Size = New System.Drawing.Size(37, 17)
        Me.txtMr.TabIndex = 0
        Me.txtMr.TabStop = True
        Me.txtMr.Text = "Mr"
        Me.txtMr.UseVisualStyleBackColor = True
        '
        'txtMs
        '
        Me.txtMs.AutoSize = True
        Me.txtMs.Location = New System.Drawing.Point(149, 16)
        Me.txtMs.Name = "txtMs"
        Me.txtMs.Size = New System.Drawing.Size(39, 17)
        Me.txtMs.TabIndex = 1
        Me.txtMs.TabStop = True
        Me.txtMs.Text = "Ms"
        Me.txtMs.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Location = New System.Drawing.Point(432, 275)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(92, 26)
        Me.btnclear.TabIndex = 129
        Me.btnclear.Text = "Clear fields"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(361, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 130
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(382, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 131
        Me.Label10.Text = "City"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(354, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Postcode"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(324, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 133
        Me.Label12.Text = "Contact number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(374, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 134
        Me.Label13.Text = "Email"
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(422, 172)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(102, 20)
        Me.txtcity.TabIndex = 135
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(422, 93)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(102, 20)
        Me.txtemail.TabIndex = 136
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(422, 229)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(102, 20)
        Me.txtcontactno.TabIndex = 137
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(422, 203)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.Size = New System.Drawing.Size(102, 20)
        Me.txtPostcode.TabIndex = 138
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(422, 119)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(102, 20)
        Me.txtaddress.TabIndex = 139
        '
        'txtcounty
        '
        Me.txtcounty.Location = New System.Drawing.Point(422, 145)
        Me.txtcounty.Name = "txtcounty"
        Me.txtcounty.Size = New System.Drawing.Size(102, 20)
        Me.txtcounty.TabIndex = 141
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(361, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "County"
        '
        'btnviewall
        '
        Me.btnviewall.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnviewall.Location = New System.Drawing.Point(441, 28)
        Me.btnviewall.Name = "btnviewall"
        Me.btnviewall.Size = New System.Drawing.Size(92, 24)
        Me.btnviewall.TabIndex = 142
        Me.btnviewall.Text = "View all records"
        Me.btnviewall.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(122, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 27)
        Me.Button2.TabIndex = 143
        Me.Button2.Text = "Save changes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(328, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 27)
        Me.Button1.TabIndex = 144
        Me.Button1.Text = "Reset password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 179)
        Me.PictureBox1.TabIndex = 145
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 530)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 146
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(15, 188)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(571, 339)
        Me.TabControl1.TabIndex = 147
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.lbltime)
        Me.TabPage2.Controls.Add(Me.MonthCalendar1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(563, 313)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sales Records"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(21, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(162, 13)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Average amount spent per order:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(189, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(189, 58)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(177, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Average number of pizzas per order:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(189, 36)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(95, 36)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Total pizzas sold:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(189, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(189, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(88, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Total orders made:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(80, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Total sales revenue:"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(326, 183)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(45, 13)
        Me.lbltime.TabIndex = 1
        Me.lbltime.Text = "Label15"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(319, 12)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cboMemberId)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.cbofullname)
        Me.TabPage1.Controls.Add(Me.btnclear)
        Me.TabPage1.Controls.Add(Me.cmdSave)
        Me.TabPage1.Controls.Add(Me.txtcounty)
        Me.TabPage1.Controls.Add(Me.cmdDelete)
        Me.TabPage1.Controls.Add(Me.btnviewall)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtaddress)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtPostcode)
        Me.TabPage1.Controls.Add(Me.txtAge)
        Me.TabPage1.Controls.Add(Me.txtcontactno)
        Me.TabPage1.Controls.Add(Me.txtemail)
        Me.TabPage1.Controls.Add(Me.txtDeleted)
        Me.TabPage1.Controls.Add(Me.txtcity)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtSurname)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Grptitle)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(563, 313)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer records"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 552)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Grptitle.ResumeLayout(False)
        Me.Grptitle.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMemberId As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtDeleted As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbofullname As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Grptitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDr As System.Windows.Forms.RadioButton
    Friend WithEvents txtmiss As System.Windows.Forms.RadioButton
    Friend WithEvents txtMrs As System.Windows.Forms.RadioButton
    Friend WithEvents txtMr As System.Windows.Forms.RadioButton
    Friend WithEvents txtMs As System.Windows.Forms.RadioButton
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcounty As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnviewall As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label

End Class
