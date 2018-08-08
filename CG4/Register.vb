Public Class Register
    'Declaration of variables
    Dim number As Short
    Dim message As String
    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        'Navigate to a new form
        Dim register As New Login
        register.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'If loop used to provide a presence check on each of the text boxes on the form
        If TxtPass.Text = "" And txtpass1.Text = "" Then
            'If the text box is empty the usere is informed to input data via a message box
            MsgBox("Please enter your password")
            Label25.Visible = True
            Label10.Visible = True
        ElseIf txtAnswer.Text = "" Then
            MsgBox("Please enter a secret answer")
            Label10.Visible = True
            Label29.Visible = True
        ElseIf TxtQuestion.Text = "" Then
            MsgBox("Please select a secret question")
            Label10.Visible = True
            Label27.Visible = True
        ElseIf txtMr.Checked = False And txtMrs.Checked = False And txtMiss.Checked = False And txtDr.Checked = False And txtMs.Checked = False Then
            MsgBox("Please choose a title")
            Label23.Visible = True
            Label10.Visible = True
        ElseIf TxtName.Text = "" Then
            MsgBox("Please enter your name")
            Label10.Visible = True
            Label11.Visible = True
        ElseIf TxtSurname.Text = "" Then
            MsgBox("Please Enter your surname")
            Label10.Visible = True
            Label12.Visible = True
        ElseIf txtage.Text = "" Then
            MsgBox("Please enter your age")
            Label10.Visible = True
            Label20.Visible = True
        ElseIf txtaddress.Text = "" Then
            MsgBox("Please enter your address")
            Label10.Visible = True
            Label14.Visible = True
        ElseIf txtcounty.Text = "" Then
            MsgBox("Please enter a county")
            Label10.Visible = True
            Label13.Visible = True
        ElseIf Txtcity.Text = "" Then
            MsgBox("Please enter a city")
            Label10.Visible = True
            Label15.Visible = True
        ElseIf txtpost.Text = "" Then
            MsgBox("Please enter a postcode")
            Label10.Visible = True
            Label16.Visible = True
        ElseIf txtcontactno.Text = "" Then
            MsgBox("Please enter your contact number")
            Label10.Visible = True
            Label17.Visible = True
        ElseIf txtemail.Text = "" Then
            MsgBox("Please enter your email")
            Label10.Visible = True
            Label18.Visible = True
        Else

            If TxtPass.Text = txtpass1.Text Then
                'Try catch used for a character check on all numeric fields such as age and number fields
                Try
                    'open customer file
                    FileName = CurDir() & "\Person.dat"
                    FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
                    number = txtage.Text
                    'Add a person to customer file
                    NumberOfRecords = LOF(1) / Len(OnePerson)
                    If txtMr.Checked = True Then
                        OnePerson.title = Trim("Mr")
                    ElseIf txtMrs.Checked = True Then
                        OnePerson.title = Trim("Mrs")
                    ElseIf txtMiss.Checked = True Then
                        OnePerson.title = Trim("Miss")
                    ElseIf txtMs.Checked = True Then
                        OnePerson.title = Trim("Ms")
                    ElseIf txtDr.Checked = True Then
                        OnePerson.title = Trim("Dr")
                    End If

                    'Saves all input by the user into a new record and stores back into the customer file
                    OnePerson.Password = Trim(Me.TxtPass.Text)
                    OnePerson.question = Trim(Me.TxtQuestion.Text)
                    OnePerson.answer = Trim(Me.txtAnswer.Text)
                    OnePerson.name = Trim(Me.TxtName.Text)
                    OnePerson.surname = Trim(Me.TxtSurname.Text)
                    OnePerson.age = Trim(Me.txtage.Text)
                    OnePerson.Address = Trim(Me.txtaddress.Text)
                    OnePerson.City = Trim(Me.Txtcity.Text)
                    OnePerson.county = Trim(Me.txtcounty.Text)
                    OnePerson.Postcode = Trim(Me.txtpost.Text)
                    OnePerson.Email = Trim(Me.txtemail.Text)
                    OnePerson.Contactnumber = Me.txtcontactno.Text

                    OnePerson.deleted = False
                    'Stores the record
                    FilePut(1, OnePerson, NumberOfRecords + 1)
                    Me.TxtID.Text = NumberOfRecords + 1
                    'Closes customer file
                    FileClose(1)
                    'Message box to let the user know
                    MsgBox("Your membership has been accepted!")
                    message = "Please make a note of your ID number: " & NumberOfRecords
                    MessageBox.Show(message)
                    'Character check if the age field is not a number then the user is prompted to re enter the data
                Catch
                    MsgBox("Please enter a number for age")
                End Try
            Else
                MsgBox("Password does not match")

            End If

        End If
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class