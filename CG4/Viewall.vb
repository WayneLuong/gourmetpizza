Public Class Viewall
    'Declaration of variables
    'List count variable is set as 0
    Dim lstcount As Integer = 0
    Dim lstindex As Integer

    Private Sub Viewall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Clears field of any data
        Me.lstmembers.Items.Clear()
        'open person file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'output all records by looping through each record in the customer file to determine which record is not deleted
        NumberOfRecords = LOF(1) / Len(OnePerson)
        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            'If record is not deleted
            If OnePerson.deleted = False Then
                'Then add each field from each record to the list
                Me.lstmembers.Items.Add("Id:" & Trim(index) & "   Name: " & Trim(OnePerson.name) & "   Surname: " & Trim(OnePerson.surname) & "   Age:  " & Trim(OnePerson.age) & "   Address: " & Trim(OnePerson.Address) & "   County: " & Trim(OnePerson.county) & "   City: " & Trim(OnePerson.City) & "   Postcode: " & Trim(OnePerson.Postcode) & "   Contact number: " & Trim(OnePerson.Contactnumber) & "   Email: " & Trim(OnePerson.Email))
                'list count +1
                lstcount = lstcount + 1
            End If
            'Continues to loop until it reaches the max number of records
        Next index
        'Label displays the number of items in list
        lblRecords.Text = (lstcount)
        'Closes customer file
        FileClose(1)
    End Sub

    Private Sub linkBack_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkBack.LinkClicked
        'Navigate to new form
        Dim viewall As New Admin
        viewall.ShowDialog()
    End Sub

    Private Sub cmdDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'open customer file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))
        'index is the record number selected
        index = lstmembers.SelectedIndex
        'Calculates length of record
        NumberOfRecords = LOF(1) / Len(OnePerson)
        FileGet(1, OnePerson, index)
        OnePerson.deleted = True
        MsgBox("Record deleted")

        'Clears the items in the list
        Me.lstmembers.Items.Clear()

        'output all records by looping through each record in the customer file to determine which record is not deleted
        NumberOfRecords = LOF(1) / Len(OnePerson)
        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            If OnePerson.deleted = False Then
                'Then add each field from each record to the list
                Me.lstmembers.Items.Add("Id:" & Trim(index) & "   Name: " & Trim(OnePerson.name) & "   Surname: " & Trim(OnePerson.surname) & "   Age:  " & Trim(OnePerson.age) & "   Address: " & Trim(OnePerson.Address) & "   County: " & Trim(OnePerson.county) & "   City: " & Trim(OnePerson.City) & "   Postcode: " & Trim(OnePerson.Postcode) & "   Contact number: " & Trim(OnePerson.Contactnumber) & "   Email: " & Trim(OnePerson.Email))
                'list count +1
                lstcount = lstcount + 1
            End If
        Next index
        'Close customer file
        FileClose(1)
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        'Print preview document
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Declaration of font, structure and size
        Dim MyFont As New Font("Courier New", 12, FontStyle.Regular)
        Dim MyFormat As String = "{0, -10}{1, -10}{2, -12}{3, -4}{4, -15}{5, -18}"
        Dim LineToPrint As String
        Dim X, Y, FontHeight As Integer
        'Set the coordinates of the print preview
        X = 50
        Y = 50
        FontHeight = MyFont.GetHeight(e.Graphics)
        e.Graphics.DrawString("Report on Member", MyFont, Brushes.Black, X, Y)
        Y = Y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, X, Y)
        Y = Y + FontHeight
        LineToPrint = String.Format(MyFormat, "Title", "Name", "Surname", "Age", "Address", "County")
        e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, X, Y)
        Y = Y + FontHeight
        e.Graphics.DrawString("", MyFont, Brushes.Black, X, Y)

        'open a file
        FileName = CurDir() & "\Person.dat"
        FileOpen(1, FileName, OpenMode.Random, , , Len(OnePerson))

        'output all fields
        NumberOfRecords = LOF(1) / Len(OnePerson)

        For index = 1 To NumberOfRecords
            FileGet(1, OnePerson, index)
            If OnePerson.deleted = False Then
                Y = Y + FontHeight
                LineToPrint = String.Format(MyFormat, Trim(OnePerson.title), Trim(OnePerson.name), Trim(OnePerson.surname), Trim(OnePerson.age), Trim(OnePerson.Address), Trim(OnePerson.county))
                e.Graphics.DrawString(LineToPrint, MyFont, Brushes.Black, X, Y)
            End If
        Next index
        FileClose(1)
    End Sub
End Class
