Public Class Login
    'Set up local variables (number variable is used for a character check)
    Dim number As Integer
    Private Sub llbladmin_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbladmin.LinkClicked
        'Navigate to a new form
        Dim login As New AdminLogin
        login.ShowDialog()
    End Sub


    Private Sub Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log.Click
        'open customer file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
        'Try loop (Character check) on member ID field to ensure only numbers are entered
        'Variable 'number' is used to check whether the variable is a number or character
        Try
            number = index
            index = Me.cboMemberId.Text
            FileGet(1, OnePerson, index)

            If Trim(txtpassword.Text) = Trim(OnePerson.Password) And Trim(txtemail.Text) = Trim(OnePerson.Email) Then
                'Shows the hidden form control
                Log.Visible = False
                Label4.Visible = True
                'Goes to progress bar code
                ProgressBar1.Show()
                Timer1.Start()
            Else
                MsgBox("Password does not match")
                'Close a file
                FileClose(1)
            End If
            'If variable 'number' is not a number then it goes through the catch loop
        Catch
            MsgBox("Invalid Data Entered")
        End Try
    End Sub

    Private Sub Forgotpwd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Forgotpwd.LinkClicked
        'Navigate to new form
        Dim login As New forgetpass
        login.ShowDialog()
    End Sub

    Private Sub Register_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Register.LinkClicked
        'Navigate to new form
        Dim login As New Register
        login.ShowDialog()
    End Sub
    Private Sub cboMemberId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMemberId.SelectedIndexChanged
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Reads in variable and retrieves the record
        index = Me.cboMemberId.Text
        FileGet(1, OnePerson, index)
        '     txtemail.Text = Trim(OnePerson.Email)
        '   txtpassword.Text = Trim(OnePerson.Password)

        'Close a file
        FileClose(1)
    End Sub
    Private Sub cboMemberId_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMemberId.Click
        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'Clears all records
        Me.cboMemberId.Items.Clear()
        'output all record Id number
        NumberOfRecords = LOF(1) / Len(OnePerson)
        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            If OnePerson.deleted = False Then
                Me.cboMemberId.Items.Add(index)
            End If
        Next index
        'Close a file
        FileClose(1)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Sets the progress bar timer
        ProgressBar1.Increment(35)
        'If loop
        'Loops when progress bar reaches max value
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()

            'Navigate to new form
            Dim Login As Welcome
            Login = New Welcome
            'Hide current form
            Login.Show()
            Login = Nothing

        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Hide the progress bar
        ProgressBar1.Hide()

    End Sub
End Class