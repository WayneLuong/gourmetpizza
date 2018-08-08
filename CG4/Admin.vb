Public Class Admin
    Dim number As Short
    Private Sub cboMemberId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMemberId.SelectedIndexChanged
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
        'Retrives the file using index as record number
        index = Me.cboMemberId.Text
        FileGet(1, OnePerson, index)

        'Presence check and IF Loop
        'Variables are trimmed to avoid blank spaces
        If Trim(OnePerson.title) = Trim("Mr") Then
            'Sets the check status to true if the above is true
            txtMr.Checked = True
            'The rest of the check boxes is then set to false as only one radio button can be selected at once
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Mrs") Then
            'Sets the check status to true if the above is true
            txtMrs.Checked = True
            'The rest of the check boxes is then set to false as only one radio button can be selected at once
            txtMr.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Miss") Then
            'Sets the check status to true if the above is true
            txtmiss.Checked = True
            'The rest of the check boxes is then set to false as only one radio button can be selected at once
            txtMrs.Checked = False
            txtMr.Checked = False
            txtMs.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Ms") Then
            'Sets the check status to true if the above is true
            txtMs.Checked = True
            'The rest of the check boxes is then set to false as only one radio button can be selected at once
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMr.Checked = False
            txtDr.Checked = False
        ElseIf Trim(OnePerson.title) = Trim("Dr") Then
            'Sets the check status to true if the above is true
            txtDr.Checked = True
            'The rest of the check boxes is then set to false as only one radio button can be selected at once
            txtMrs.Checked = False
            txtmiss.Checked = False
            txtMs.Checked = False
            txtMr.Checked = False
            'End of IF statement
        End If
        'Populates each text box with the variables retrieved from selected record
        Me.txtName.Text = Trim(OnePerson.name)
        'Each named field is filled with the given variable
        'Each variable is trimmed
        Me.txtSurname.Text = Trim(OnePerson.surname)
        Me.txtAge.Text = Trim(OnePerson.age)
        Me.txtaddress.Text = Trim(OnePerson.Address)
        Me.txtcity.Text = Trim(OnePerson.City)
        Me.txtPostcode.Text = Trim(OnePerson.Postcode)
        Me.txtcounty.Text = Trim(OnePerson.county)
        Me.txtemail.Text = Trim(OnePerson.Email)
        Me.txtcontactno.Text = Trim(OnePerson.Contactnumber)
        'Shows the delete status of the records retrieved
        Me.txtDeleted.Text = OnePerson.deleted
        'Shows the record number of the retrieved record 
        Me.txtID.Text = index
        'Close a file
        FileClose(1)
    End Sub
    Private Sub cboMemberId_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMemberId.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'The combo box named cboMember is cleared of any data
        Me.cboMemberId.Items.Clear()
        'output all record numbers in a combo box via a drop down menu
        NumberOfRecords = LOF(1) / Len(OnePerson)
        'Index is set from 1 to number of records of Person.Dat
        For index = 1 To NumberOfRecords
            'Retrieves the file Oneperson.Dat from the system 
            FileGet(1, OnePerson, index)
            'If loop to check whether the deleted status of the record is deleted
            If OnePerson.deleted = False Then
                'If deleted is false then populate the combobox with the record number
                Me.cboMemberId.Items.Add(index)
            End If
        Next index
        'Close a file
        FileClose(1)
    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
        NumberOfRecords = LOF(1) / Len(OnePerson)

        'Validation to ensure program does not crash (presence check)
        'If the named field is blank ("") then go through IF loop
        If Me.txtID.Text = "" Then
            'Output message box
            MsgBox("Record does not exist")
            'If field is not blank then loop through the else part of the loop
        Else
            index = Me.txtID.Text
            'If index is less than or equal to amount of records then go through the IF loop
            If index <= NumberOfRecords Then
                'delete record
                index = Me.txtID.Text
                NumberOfRecords = LOF(1) / Len(OnePerson)
                FileGet(1, OnePerson, index)
                'Delete status of the record is changed to true, this indicates the record is deleted
                OnePerson.deleted = True

                'Changes all fields to blank space
                OnePerson.name = ""
                OnePerson.surname = ""
                OnePerson.age = 0
                OnePerson.Address = ""
                'Message box informing the user record is deleted
                MsgBox("Record deleted")
                'Returns the record to the file
                FilePut(1, OnePerson, index)
                'If index is more than number of records then go through loop
            ElseIf index > NumberOfRecords Then
                MsgBox("Record does not exist")
                'If index is less than 1 then go through loop
            ElseIf index < 1 Then
                MsgBox("Record does not exist")
            Else
                MsgBox("Please select a record")
            End If
        End If
       
        'Close a file
        FileClose(1)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Presence check for all fields
        'If no radio buttons is checked then run through loop
        If txtMr.Checked = False And txtMrs.Checked = False And txtmiss.Checked = False And txtDr.Checked = False And txtMs.Checked = False Then
            MsgBox("Please choose a title")
            'If named field is blank then run through loop
        ElseIf txtName.Text = "" Then
            MsgBox("Please enter your name")
            'If named field is blank then run through loop
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please Enter your surname")
            'If named field is blank then run through loop
        ElseIf txtAge.Text = "" Then
            MsgBox("Please enter your age")
            'If named field is blank then run through loop
        ElseIf txtaddress.Text = "" Then
            MsgBox("Please enter your address")
            'If named field is blank then run through loop
        ElseIf txtcounty.Text = "" Then
            MsgBox("Please enter a county")
            'If named field is blank then run through loop
        ElseIf txtcity.Text = "" Then
            MsgBox("Please enter a city")
            'If named field is blank then run through loop
        ElseIf txtPostcode.Text = "" Then
            MsgBox("Please enter a postcode")
            'If named field is blank then run through loop
        ElseIf txtcontactno.Text = "" Then
            MsgBox("Please enter your contact number")
            'If named field is blank then run through loop
        ElseIf txtemail.Text = "" Then
            MsgBox("Please enter your email")
        Else
            'try loop for a character check
            Try
                'Variable 'number' is used to check whether the variable is a number or character
                number = txtAge.Text
                'Add a person to the file
                NumberOfRecords = LOF(1) / Len(OnePerson)
                If txtMr.Checked = True Then
                    OnePerson.title = Trim("Mr")
                ElseIf txtMrs.Checked = True Then
                    OnePerson.title = Trim("Mrs")
                ElseIf txtmiss.Checked = True Then
                    OnePerson.title = Trim("Miss")
                ElseIf txtMs.Checked = True Then
                    OnePerson.title = Trim("Ms")
                ElseIf txtDr.Checked = True Then
                    OnePerson.title = Trim("Dr")
                End If
                'saves input from each field into a record
                OnePerson.name = Me.txtName.Text
                OnePerson.surname = Me.txtSurname.Text
                OnePerson.age = Me.txtAge.Text
                OnePerson.Address = Me.txtaddress.Text
                OnePerson.City = Me.txtcity.Text
                OnePerson.county = Me.txtcounty.Text
                OnePerson.Postcode = Me.txtPostcode.Text
                OnePerson.Email = Me.txtemail.Text
                OnePerson.Contactnumber = Me.txtcontactno.Text

                'deleted status is set to false, this indicates record is not deleted
                OnePerson.deleted = False
                FilePut(1, OnePerson, NumberOfRecords + 1)
                Me.txtID.Text = NumberOfRecords + 1
                MsgBox("Saved")
                Me.txtID.Clear()
                Me.txtName.Clear()
                Me.txtSurname.Clear()
                Me.txtAge.Clear()
                Me.txtaddress.Clear()
                Me.txtcity.Clear()
                Me.txtcounty.Clear()
                Me.txtPostcode.Clear()
                Me.txtemail.Clear()
                Me.txtcontactno.Clear()
                'If variable 'number' is not a number then it goes through the catch loop
            Catch
                MsgBox("Please enter a number for Age field")
            End Try
        End If
        'Close a file
        FileClose(1)
    End Sub

    Private Sub cbofullname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbofullname.SelectedIndexChanged
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Populates each field from selected record
        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            'Checks whether full name is equal to surname and name combined
            If Trim(Me.cbofullname.Text) = Trim(OnePerson.surname) & ", " & Trim(OnePerson.name) Then
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
                Me.txtName.Text = Trim(OnePerson.name)
                Me.txtSurname.Text = Trim(OnePerson.surname)
                Me.txtAge.Text = Trim(OnePerson.age)
                Me.txtaddress.Text = Trim(OnePerson.Address)
                Me.txtcity.Text = Trim(OnePerson.City)
                Me.txtPostcode.Text = Trim(OnePerson.Postcode)
                Me.txtcounty.Text = Trim(OnePerson.county)
                Me.txtemail.Text = Trim(OnePerson.Email)
                Me.txtcontactno.Text = Trim(OnePerson.Contactnumber)
                Me.txtDeleted.Text = OnePerson.deleted
                Me.txtID.Text = index
            End If
        Next
        'Close a file
        FileClose(1)
    End Sub

    Private Sub cbofullname_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMemberId.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Clears all fields in cbofullname
        Me.cbofullname.Items.Clear()
        'output all record full name
        NumberOfRecords = LOF(1) / Len(OnePerson)
        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            'If delete status of record is deleted
            If OnePerson.deleted = False Then
                'Then populate the combo box with the record's surname and first name
                Me.cbofullname.Items.Add(Trim(OnePerson.surname) & ", " & Trim(OnePerson.name))
            End If
        Next index

        'Close a file
        FileClose(1)
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        'clears all fields on the form
        Me.txtName.Clear()
        Me.txtSurname.Clear()
        Me.txtAge.Clear()
        Me.txtaddress.Clear()
        Me.txtcounty.Clear()
        Me.txtcity.Clear()
        Me.txtPostcode.Clear()
        Me.txtcontactno.Clear()
        Me.txtemail.Clear()
        Me.txtID.Clear()
        Me.txtDeleted.Clear()
        Me.cboMemberId.Items.Clear()
        txtMs.Checked = False
        txtMrs.Checked = False
        txtmiss.Checked = False
        txtMr.Checked = False
        txtDr.Checked = False
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.cboMemberId.Text = ""
        'open customer file file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'presence check on each field of the customer record
        If Me.txtID.Text = "" Then
            MsgBox("Please select a record to edit")
        ElseIf txtMr.Checked = False And txtMrs.Checked = False And txtmiss.Checked = False And txtDr.Checked = False And txtMs.Checked = False Then
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
            ' Character check on age and contact number field
            Try
                'Variable 'number' is used to check whether the variable is a number or character
                number = txtAge.Text
                'Edit record
                index = Me.txtID.Text
                OnePerson.name = Me.txtName.Text
                OnePerson.surname = Me.txtSurname.Text
                OnePerson.age = Me.txtAge.Text
                OnePerson.Address = Me.txtaddress.Text
                OnePerson.county = Me.txtcounty.Text
                OnePerson.City = Me.txtcity.Text
                OnePerson.Postcode = Me.txtPostcode.Text
                OnePerson.Email = Me.txtemail.Text
                OnePerson.Contactnumber = Me.txtcontactno.Text
                OnePerson.deleted = Me.txtDeleted.Text

                FilePut(1, OnePerson, index)
                MsgBox("Changes have been saved")
                'If variable 'number' is not a number then it goes through the catch loop
            Catch
                MsgBox("Please enter a number on Age field")
            End Try
        End If
        'Close a file
        FileClose(1)

    End Sub

    Private Sub btnviewall1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewall.Click
        'Closes current form and goes to new form
        Dim Admin As New Viewall
        Admin.showdialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Change variable to blank space
        index = Me.txtID.Text
        OnePerson.Password = Trim("")
        FilePut(1, OnePerson, index)
        MsgBox("Password has been reset")

        'Close a file
        FileClose(1)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Navigate to a new form
        Dim admin As New AdminLogin
        Admin.ShowDialog()
    End Sub

    Private Sub Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'open order file
        FileName = CurDir() & "\Order.dat"
        FileOpen(4, FileName, OpenMode.Random, , , Len(Oneorder))
        'open pizza file
        FileName = CurDir() & "\Pizza.dat"
        FileOpen(3, FileName, OpenMode.Random, , , Len(Onepizza))

        'Calculates the length of each file
        NumberOfPizzas = LOF(3) / Len(Onepizza)
        NumberOfOrders = LOF(4) / Len(Oneorder)

        'Populates the labels with the stated variable
        Label17.Text = NumberOfOrders
        'Formats the variable into a currency format
        Label18.Text = Format(OneAdmin.revenue, "Currency")
        Label19.Text = NumberOfPizzas
        'Sets the current time of the computer
        lbltime.Text = TimeValue(Now)
        'Calculations
        Label22.Text = NumberOfPizzas / NumberOfOrders
        Label23.Text = Format(OneAdmin.revenue / NumberOfOrders, "currency")
        

        'Close order,pizza and admin files
        FileClose(4)
        FileClose(3)
        FileClose(2)
    End Sub

End Class
