<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Summary))
        Me.lstpizza = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcounty = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtPostcode = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtcity = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txttitle = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Time = New System.Windows.Forms.TabControl
        Me.Delivery = New System.Windows.Forms.TabPage
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.lbltime2 = New System.Windows.Forms.Label
        Me.lbltime = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Time.SuspendLayout()
        Me.Delivery.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstpizza
        '
        Me.lstpizza.FormattingEnabled = True
        Me.lstpizza.HorizontalScrollbar = True
        Me.lstpizza.Location = New System.Drawing.Point(34, 211)
        Me.lstpizza.Name = "lstpizza"
        Me.lstpizza.Size = New System.Drawing.Size(330, 290)
        Me.lstpizza.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Placed! Thank you for ordering with Gourmet Pizza!"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(495, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 523)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 523)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:£"
        '
        'txtcounty
        '
        Me.txtcounty.Location = New System.Drawing.Point(110, 130)
        Me.txtcounty.Name = "txtcounty"
        Me.txtcounty.ReadOnly = True
        Me.txtcounty.Size = New System.Drawing.Size(102, 20)
        Me.txtcounty.TabIndex = 151
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(49, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 150
        Me.Label14.Text = "County"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(110, 104)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(102, 20)
        Me.txtaddress.TabIndex = 149
        '
        'txtPostcode
        '
        Me.txtPostcode.Location = New System.Drawing.Point(110, 182)
        Me.txtPostcode.Name = "txtPostcode"
        Me.txtPostcode.ReadOnly = True
        Me.txtPostcode.Size = New System.Drawing.Size(102, 20)
        Me.txtPostcode.TabIndex = 148
        '
        'txtcontactno
        '
        Me.txtcontactno.Location = New System.Drawing.Point(110, 208)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.ReadOnly = True
        Me.txtcontactno.Size = New System.Drawing.Size(102, 20)
        Me.txtcontactno.TabIndex = 147
        '
        'txtcity
        '
        Me.txtcity.Location = New System.Drawing.Point(110, 156)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.ReadOnly = True
        Me.txtcity.Size = New System.Drawing.Size(102, 20)
        Me.txtcity.TabIndex = 146
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 215)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 145
        Me.Label12.Text = "Contact number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "Postcode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(49, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Title"
        '
        'txttitle
        '
        Me.txttitle.Location = New System.Drawing.Point(110, 26)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.ReadOnly = True
        Me.txttitle.Size = New System.Drawing.Size(57, 20)
        Me.txttitle.TabIndex = 164
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 169
        Me.Label7.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(110, 78)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.ReadOnly = True
        Me.txtSurname.Size = New System.Drawing.Size(102, 20)
        Me.txtSurname.TabIndex = 168
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(102, 20)
        Me.txtName.TabIndex = 166
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Delivery address"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(54, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 179)
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(389, 515)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 28)
        Me.Button2.TabIndex = 172
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Time
        '
        Me.Time.Controls.Add(Me.Delivery)
        Me.Time.Controls.Add(Me.TabPage1)
        Me.Time.Location = New System.Drawing.Point(384, 197)
        Me.Time.Name = "Time"
        Me.Time.SelectedIndex = 0
        Me.Time.Size = New System.Drawing.Size(245, 272)
        Me.Time.TabIndex = 173
        '
        'Delivery
        '
        Me.Delivery.Controls.Add(Me.Label6)
        Me.Delivery.Controls.Add(Me.txttitle)
        Me.Delivery.Controls.Add(Me.Label4)
        Me.Delivery.Controls.Add(Me.txtcontactno)
        Me.Delivery.Controls.Add(Me.Label12)
        Me.Delivery.Controls.Add(Me.txtPostcode)
        Me.Delivery.Controls.Add(Me.txtcounty)
        Me.Delivery.Controls.Add(Me.Label14)
        Me.Delivery.Controls.Add(Me.Label11)
        Me.Delivery.Controls.Add(Me.txtcity)
        Me.Delivery.Controls.Add(Me.Label7)
        Me.Delivery.Controls.Add(Me.txtName)
        Me.Delivery.Controls.Add(Me.Label10)
        Me.Delivery.Controls.Add(Me.txtaddress)
        Me.Delivery.Controls.Add(Me.txtSurname)
        Me.Delivery.Controls.Add(Me.Label5)
        Me.Delivery.Controls.Add(Me.Label9)
        Me.Delivery.Location = New System.Drawing.Point(4, 22)
        Me.Delivery.Name = "Delivery"
        Me.Delivery.Padding = New System.Windows.Forms.Padding(3)
        Me.Delivery.Size = New System.Drawing.Size(237, 246)
        Me.Delivery.TabIndex = 0
        Me.Delivery.Text = "Delivery"
        Me.Delivery.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lbltime2)
        Me.TabPage1.Controls.Add(Me.lbltime)
        Me.TabPage1.Controls.Add(Me.MonthCalendar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(237, 246)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Date & Time"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Current time:"
        '
        'lbltime2
        '
        Me.lbltime2.AutoSize = True
        Me.lbltime2.Location = New System.Drawing.Point(18, 216)
        Me.lbltime2.Name = "lbltime2"
        Me.lbltime2.Size = New System.Drawing.Size(42, 13)
        Me.lbltime2.TabIndex = 2
        Me.lbltime2.Text = "lbltime2"
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Location = New System.Drawing.Point(90, 192)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(39, 13)
        Me.lbltime.TabIndex = 1
        Me.lbltime.Text = "Label8"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(5, 21)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(411, 481)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton1.TabIndex = 174
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Delivery"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(480, 481)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton2.TabIndex = 175
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Collection"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(638, 555)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstpizza)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Summary"
        Me.Text = "Receipt"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Time.ResumeLayout(False)
        Me.Delivery.ResumeLayout(False)
        Me.Delivery.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstpizza As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcounty As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPostcode As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttitle As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Time As System.Windows.Forms.TabControl
    Friend WithEvents Delivery As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents lbltime2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
