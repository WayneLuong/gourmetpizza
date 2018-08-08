Public Class Adminpass

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Navigate to new form
        Dim adminpass As New AdminLogin
        adminpass.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'open Admin file
        FileName = CurDir() & "\Admin.dat"
        FileOpen(2, FileName, OpenMode.Random, , , Len(oneadmin))

        'If loop for validation of both password fields
        'Validation to check both passwords is consistent
        If Trim(txtoldpass.Text) = Trim(OneAdmin.password) And Trim(txtnewpass.Text) = Trim(txtconfirmnewpass.Text) Then
            'Calculations to work out the number of records
            NumberOfRecords = LOF(2) / Len(OneAdmin)
            'If number of records is equal to one then 
            'Save the admin password into the current record
            If NumberOfRecords = 1 Then
                index = 1
                FileGet(2, OneAdmin, index)
                OneAdmin.password = Trim(Me.txtnewpass.Text)
                FilePut(2, OneAdmin, index)
                MsgBox("Password has been changed")
                ' Close Admin file
                FileClose(2)
                Dim adminpass As New AdminLogin
                adminpass.ShowDialog()
                'If number of records is equal to 0 then create a new record
                ' The admin password is saved into a new record
            ElseIf NumberOfRecords = 0 Then
                NumberOfRecords = LOF(2) / Len(OneAdmin)
                OneAdmin.password = Trim(Me.txtnewpass.Text)
                FilePut(2, OneAdmin, NumberOfRecords + 1)
                MsgBox("Password has been changed")
                ' Close Admin file
                FileClose(2)
                'Navigate to new form
                Dim adminpass As New AdminLogin
                adminpass.ShowDialog()
            End If
        Else
            MsgBox("Invalid data entered")
        End If
        '
        'Close Admin file
        FileClose(2)
    End Sub

    Private Sub Adminpass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class