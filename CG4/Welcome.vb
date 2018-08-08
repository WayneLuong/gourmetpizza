Public Class Welcome
    'Declaration of variables
    Dim number As Short
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Close customer file
        FileClose(1)
        'Navigating to a new form
        Dim welcome As New Login
        welcome.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnorder.Click
        'Navigating to a new form
        Dim welcome As New Orderscreen
        welcome.ShowDialog()
    End Sub

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loads relevent variables from customer file into the text
        Me.GroupBox1.Text = ("Welcome" & " " & Trim(OnePerson.name) & " " & Trim(OnePerson.surname) & "!")

        'Opens and retrieves the relevent record record
        FileGet(1, OnePerson, index)
        'If loop
        'Populates each customer field from the variables in the retrieved record
        If Trim(OnePerson.title) = Trim("Mr") Then
            txtMr.Checked = True
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Mrs") Then
            txtMrs.Checked = True
            txtMr.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Miss") Then
            txtmiss.Checked = True
            txtMrs.Checked = False
            txtMr.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Ms") Then
            txtMs.Checked = True
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMr.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Dr") Then
            txtDr.Checked = True
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtMr.Checked = False
        End If
        txttitle.Visible = True
        'Populates the fields with the customer record that was previously retrieved
        Me.txttitle.Text = Trim(OnePerson.title)
        Me.txtName.Text = Trim(OnePerson.name)
        Me.txtSurname.Text = Trim(OnePerson.surname)
        Me.txtAge.Text = Trim(OnePerson.age)
        Me.txtaddress.Text = Trim(OnePerson.Address)
        Me.txtcity.Text = Trim(OnePerson.City)
        Me.txtPostcode.Text = Trim(OnePerson.Postcode)
        Me.txtcounty.Text = Trim(OnePerson.county)
        Me.txtemail.Text = Trim(OnePerson.Email)
        Me.txtcontactno.Text = Trim(OnePerson.Contactnumber)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        'Shows and hides form controls
        btnedit.Visible = False
        btnsave.Visible = True
        Grptitle.Visible = True
        txttitle.Visible = False
        Label1.Visible = False
        Label8.Visible = True

        'Makes the fields read-only (Cannot be editted)
        txtName.ReadOnly = False
        txtSurname.ReadOnly = False
        txtAge.ReadOnly = False
        txtaddress.ReadOnly = False
        txtcounty.ReadOnly = False
        txtcity.ReadOnly = False
        txtPostcode.ReadOnly = False
        txtcontactno.ReadOnly = False
        txtemail.ReadOnly = False
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        'Presence check on each field of the customer record
        If txtMr.Checked = False And txtMrs.Checked = False And txtmiss.Checked = False And txtDr.Checked = False And txtMs.Checked = False Then
            MsgBox("Please choose a title")
        ElseIf txtName.Text = "" Then
            MsgBox("Please enter your name")
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please Enter your surname")
        ElseIf txtAge.Text = "" Then
            MsgBox("Please enter your age")
        ElseIf txtaddress.Text = "" Then
            MsgBox("Please enter your address")
        ElseIf txtcounty.Text = "" Then
            MsgBox("Please enter a county")
        ElseIf txtcity.Text = "" Then
            MsgBox("Please enter a city")
        ElseIf txtPostcode.Text = "" Then
            MsgBox("Please enter a postcode")
        ElseIf txtcontactno.Text = "" Then
            MsgBox("Please enter your contact number")
        ElseIf txtemail.Text = "" Then
            MsgBox("Please enter your email")
        Else
            'Try catch used for a character check on the numerical fields of the customer records
            Try
                number = txtAge.Text
                'Edit customer record
                'Reads in the input from the user and save the inputted data into the current customer record open
                OnePerson.name = Me.txtName.Text
                OnePerson.surname = Me.txtSurname.Text
                OnePerson.age = Me.txtAge.Text
                OnePerson.Address = Me.txtaddress.Text
                OnePerson.county = Me.txtcounty.Text
                OnePerson.City = Me.txtcity.Text
                OnePerson.Postcode = Me.txtPostcode.Text
                OnePerson.Email = Me.txtemail.Text
                OnePerson.Contactnumber = Me.txtcontactno.Text

                'Stores the current record
                FilePut(1, OnePerson, index)
                'Stores and hides the form controls
                btnsave.Visible = False
                btnedit.Visible = True
                Label1.Visible = True
                txttitle.Visible = True
                Grptitle.Visible = False
                Label8.Visible = False

                'Makes the fields read-only (Cannot be editted)
                txtName.ReadOnly = True
                txtSurname.ReadOnly = True
                txtAge.ReadOnly = True
                txtaddress.ReadOnly = True
                txtcounty.ReadOnly = True
                txtcity.ReadOnly = True
                txtPostcode.ReadOnly = True
                txtcontactno.ReadOnly = True
                txtemail.ReadOnly = True
                MsgBox("Changes have been saved")
            Catch
                MsgBox("Please enter number on Age field")
            End Try
        End If

        'If loop to determine which radio button has been selected from the group
        ' This is then saved as part of the title variable of the customer record
        If Trim(OnePerson.title) = Trim("Mr") Then
            txtMr.Checked = True
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Mrs") Then
            txtMrs.Checked = True
            txtMr.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Miss") Then
            txtmiss.Checked = True
            txtMrs.Checked = False
            txtMr.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Ms") Then
            txtMs.Checked = True
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMr.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Dr") Then
            txtDr.Checked = True
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtMr.Checked = False
        End If
        'The rest of the customer fields are saved into the current record based on what the user has entered
        txttitle.Visible = True
        Me.txttitle.Text = Trim(OnePerson.title)
        Me.txtName.Text = Trim(OnePerson.name)
        Me.txtSurname.Text = Trim(OnePerson.surname)
        Me.txtAge.Text = Trim(OnePerson.age)
        Me.txtaddress.Text = Trim(OnePerson.Address)
        Me.txtcity.Text = Trim(OnePerson.City)
        Me.txtPostcode.Text = Trim(OnePerson.Postcode)
        Me.txtcounty.Text = Trim(OnePerson.county)
        Me.txtemail.Text = Trim(OnePerson.Email)
        Me.txtcontactno.Text = Trim(OnePerson.Contactnumber)
    End Sub

End Class