<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.btnorder = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtcounty = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtPostcode = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Grptitle = New System.Windows.Forms.GroupBox
        Me.txtDr = New System.Windows.Forms.RadioButton
        Me.txtmiss = New System.Windows.Forms.RadioButton
        Me.txtMrs = New System.Windows.Forms.RadioButton
        Me.txtMr = New System.Windows.Forms.RadioButton
        Me.txtMs = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grptitle.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Location = New System.Drawing.Point(475, 492)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(40, 13)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logout"
        '
        'btnorder
        '
        Me.btnorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnorder.Location = New System.Drawing.Point(280, 434)
        Me.btnorder.Name = "btnorder"
        Me.btnorder.Size = New System.Drawing.Size(112, 39)
        Me.btnorder.TabIndex = 1
        Me.btnorder.Text = "Order"
        Me.btnorder.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.Location = New System.Drawing.Point(121, 434)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(112, 39)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "Edit details"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Location = New System.Drawing.Point(67, 167)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 29)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save changes"
        Me.btnsave.UseVisualStyleBackColor = True
        Me.btnsave.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(39, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 179)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'txtcounty
        '
        Me.txtcounty.Location = New System.Drawing.Point(408, 80)
        Me.txtcounty.Name = "txtcounty"
        Me.txtcounty.ReadOnly = True
        Me.txtcounty.Size = New System.Drawing.Size(102, 20)
        Me.txtcounty.TabIndex = 153
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(347, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "County"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(408, 54)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(102, 20)
        Me.txtaddress.TabIndex = 151
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(408, 138)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.ReadOnly = True
        Me.txtPostcode.Size = New System.Drawing.Size(102, 20)
        Me.txtPostcode.TabIndex = 150
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(408, 164)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.ReadOnly = True
        Me.txtcontactno.Size = New System.Drawing.Size(102, 20)
        Me.txtcontactno.TabIndex = 149
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(408, 28)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(102, 20)
        Me.txtemail.TabIndex = 148
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(408, 107)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.ReadOnly = True
        Me.txtcity.Size = New System.Drawing.Size(102, 20)
        Me.txtcity.TabIndex = 147
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(360, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "Email"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(320, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "Contact number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(340, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "Postcode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(347, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Address"
        '
        'Grptitle
        '
        Me.Grptitle.Controls.Add(Me.txtDr)
        Me.Grptitle.Controls.Add(Me.txtmiss)
        Me.Grptitle.Controls.Add(Me.txtMrs)
        Me.Grptitle.Controls.Add(Me.txtMr)
        Me.Grptitle.Controls.Add(Me.txtMs)
        Me.Grptitle.Location = New System.Drawing.Point(67, 19)
        Me.Grptitle.Name = "Grptitle"
        Me.Grptitle.Size = New System.Drawing.Size(234, 39)
        Me.Grptitle.TabIndex = 161
        Me.Grptitle.TabStop = False
        Me.Grptitle.Visible = False
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Title"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(67, 97)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(102, 20)
        Me.txtSurname.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Age"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 156
        Me.Label4.Text = "Name"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(67, 123)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(102, 20)
        Me.txtAge.TabIndex = 155
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(67, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(102, 20)
        Me.txtName.TabIndex = 154
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txttitle)
        Me.GroupBox1.Controls.Add(Me.Grptitle)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSurname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtcounty)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtPostcode)
        Me.GroupBox1.Controls.Add(Me.txtcontactno)
        Me.GroupBox1.Controls.Add(Me.txtemail)
        Me.GroupBox1.Controls.Add(Me.txtcity)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 209)
        Me.GroupBox1.TabIndex = 162
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Title"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(67, 149)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.ReadOnly = True
        Me.txttitle.Size = New System.Drawing.Size(57, 20)
        Me.txttitle.TabIndex = 162
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 514)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnorder)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grptitle.ResumeLayout(False)
        Me.Grptitle.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnorder As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtcounty As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Grptitle As System.Windows.Forms.GroupBox
    Friend WithEvents txtDr As System.Windows.Forms.RadioButton
    Friend WithEvents txtmiss As System.Windows.Forms.RadioButton
    Friend WithEvents txtMrs As System.Windows.Forms.RadioButton
    Friend WithEvents txtMr As System.Windows.Forms.RadioButton
    Friend WithEvents txtMs As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
