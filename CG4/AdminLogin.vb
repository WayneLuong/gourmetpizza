Public Class AdminLogin

    Private Sub Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Log.Click
        'open a file
        FileName = CurDir() & "\Admin.dat"
        FileOpen(2, FileName, OpenMode.Random, , , Len(oneadmin))
        index = 1
        FileGet(2, OneAdmin, index)

        'Validation to ensure the old password is entered correctly
        If Trim(Me.txtpassword.Text) = Trim(OneAdmin.password) Then
            'Navigate to new form
            Dim adminlogin As New Admin
            adminlogin.ShowDialog()
        Else
            'Message box to inform the user that wrong password is entered
            MsgBox("Incorrect password entered")
            'Close a file
            FileClose(2)
        End If

       
    End Sub

    Private Sub Changepass_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Changepass.LinkClicked
        'Navigate to new form
        Dim adminlogin As New Adminpass
        adminlogin.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Close a file
        FileClose(2)
        'Navigate to new form
        Dim adminlogin As New Login
        adminlogin.ShowDialog()
    End Sub

    Private Sub AdminLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class