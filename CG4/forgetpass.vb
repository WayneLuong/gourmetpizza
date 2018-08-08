Public Class forgetpass
    Dim number As Short
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        'Try loop
        'Character Check
        Try
            'Variable 'number' is used to check whether the variable is a number or character
            number = txtID.Text
            'open a file
            FileName = CurDir() & "\Person.dat"
            FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
            index = Me.txtID.Text
            FileGet(1, OnePerson, index)
            BtnOk.Visible = False
            txtID.ReadOnly = True
            txtquestion.Text = Trim(OnePerson.question)
            'If variable 'number' is not a number then it goes through the catch loop
        Catch
            MsgBox("Enter a number for ID")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Hides and shows form controls
        'If loop
        If txtanswer.Text = Trim(OnePerson.answer) Then
            txtpass.Visible = True
            txtpass2.Visible = True
            Btnconfirm.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Button1.Visible = False
            txtanswer.ReadOnly = True
            txtquestion.ReadOnly = True
        Else
            MsgBox("Answer does not match the question")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Close a file
        FileClose(1)
        'Go to new form
        Dim forgetpass As New Login
        forgetpass.ShowDialog()
    End Sub

    Private Sub Btnconfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnconfirm.Click
        'Password validation
        'Checks whether both password fields are the same
        If txtpass.Text = txtpass2.Text Then
            OnePerson.Password = Trim(txtpass.Text)
            FilePut(1, OnePerson, index)
            MsgBox("Your password has been changed")
        Else
            MsgBox("Password does not match")
        End If
    End Sub

    Private Sub forgetpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class