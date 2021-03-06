'Imports tools to create an image
Imports System.Drawing.Printing
Imports System.Drawing.Graphics
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Public Class Summary

    Private Sub Summary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'opens order file
        FileName = CurDir() & "\Order.dat"
        FileOpen(4, FileName, OpenMode.Random, , , Len(Oneorder))

        'opens pizza file
        FileName = CurDir() & "\Pizza.dat"
        FileOpen(3, FileName, OpenMode.Random, , , Len(Onepizza))
        index = Oneorder.Pizza1
        'Shows the label as a currency
        Label2.Text = Format(Oneorder.Total, "currency")

        'Sets the time and date in a label
        lbltime.Text = TimeString
        lbltime2.Text = ("Expected delivery time is 30-45minutes")
        'Populates the relevent fields with selected customer record
        Me.txttitle.Text = Trim(OnePerson.title)
        Me.txtName.Text = Trim(OnePerson.name)
        Me.txtSurname.Text = Trim(OnePerson.surname)
        Me.txtaddress.Text = Trim(OnePerson.Address)
        Me.txtcity.Text = Trim(OnePerson.City)
        Me.txtPostcode.Text = Trim(OnePerson.Postcode)
        Me.txtcounty.Text = Trim(OnePerson.county)
        Me.txtcontactno.Text = Trim(OnePerson.Contactnumber)

        'Populates the listbox with the customer's order from the previous order form
        'If order variable is not zero (Not empty, meaning there is a pizza item) then retrieve the pizza record and output this to the list box with all relevent fields
        If Oneorder.Pizza1 = 0 Then
        Else
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza2 = 0 Then
        Else
            index = Oneorder.Pizza2
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza3 = 0 Then
        Else
            index = Oneorder.Pizza3
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza4 = 0 Then
        Else
            index = Oneorder.Pizza4
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza5 = 0 Then
        Else
            index = Oneorder.Pizza5
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza6 = 0 Then
        Else
            index = Oneorder.Pizza6
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza7 = 0 Then
        Else
            index = Oneorder.Pizza7
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza8 = 0 Then
        Else
            index = Oneorder.Pizza8
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza8 = 0 Then
        Else
            index = Oneorder.Pizza8
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza9 = 0 Then
        Else
            index = Oneorder.Pizza9
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If
        If Oneorder.Pizza10 = 0 Then
        Else
            index = Oneorder.Pizza10
            FileGet(3, Onepizza, index)
            lstpizza.Items.Add("No" & Trim(Onepizza.PizzaNo) & " " & Trim(Onepizza.Size) & ", " & Trim(Onepizza.Base) & " base, " & Trim(Onepizza.Type) & " Pizza" & " x1" & " ...£" & Trim(Onepizza.Price))
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Print the whole form as an image
        Dim prd As PrintDocument
        prd = New PrintDocument

        AddHandler prd.PrintPage, AddressOf OnPrintPage

        prd.Print()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Close a file
        FileClose(1)
        FileClose(3)
        FileClose(4)
        'Navigate to a new form
        Dim summary As New Login
        summary.ShowDialog()
    End Sub

    Private Sub OnPrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Declaration of variables
        Dim hwndForm As IntPtr
        hwndForm = Me.Handle

        'Declares the varables as a bitmap 
        Dim hdcDIBSection As IntPtr
        Dim hdcRef As IntPtr
        Dim hbmDIBSection As IntPtr
        Dim hbmDIBSectionOld As IntPtr
        Dim BMPheader As Win32APICall.BITMAPINFOHEADER

        hdcRef = Win32APICall.GetDC(IntPtr.Zero)
        hdcDIBSection = Win32APICall.CreateCompatibleDC(hdcRef)
        Win32APICall.ReleaseDC(IntPtr.Zero, hdcRef)

        'Declares the size of the image
        BMPheader.biBitCount = 24
        BMPheader.biClrImportant = 0
        BMPheader.biClrUsed = 0
        BMPheader.biCompression = Win32APICall.BI_RGB
        BMPheader.biSize = 40
        BMPheader.biHeight = Me.Height
        BMPheader.biPlanes = 1
        BMPheader.biSizeImage = 0
        BMPheader.biWidth = Me.Width
        BMPheader.biXPelsPerMeter = 0
        BMPheader.biYPelsPerMeter = 0

        hbmDIBSection = Win32APICall.CreateDIBSection(hdcDIBSection, BMPheader, Win32APICall.DIB_RGB_COLORS, _
        IntPtr.Zero, IntPtr.Zero, 0)

        hbmDIBSectionOld = Win32APICall.SelectObject(hdcDIBSection, hbmDIBSection)
        Win32APICall.PatBlt(hdcDIBSection, 0, 0, Me.Width, Me.Height, Win32APICall.WHITENESS)
        Win32APICall.PrintWindow(hwndForm, hdcDIBSection, 0)
        Win32APICall.SelectObject(hdcDIBSection, hbmDIBSectionOld)

        'Declares image as bitmap
        Dim imageFrm As Bitmap
        imageFrm = Image.FromHbitmap(hbmDIBSection)
        e.Graphics.DrawImage(imageFrm, 0, 0)

        Win32APICall.DeleteDC(hdcDIBSection)
        Win32APICall.DeleteObject(hbmDIBSection)
    End Sub

End Class
Public Class Win32APICall

    'Declares the colours used
    Public Const DIB_RGB_COLORS = 0
    Public Const BI_RGB = 0
    Public Const WHITENESS = 16711778

    'Import Dll files
    'Calling ByVal
    <DllImport("user32.dll", EntryPoint:="PrintWindow", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function PrintWindow(ByVal hWnd As IntPtr, ByVal hDC As IntPtr, ByVal dwFlags As Integer) As UInt32
    End Function
    'Declares the structure of the image
    <StructLayout(LayoutKind.Sequential, pack:=8, CharSet:=CharSet.Auto)> _
    Structure BITMAPINFOHEADER
        Dim biSize As Int32
        Dim biWidth As Int32
        Dim biHeight As Int32
        Dim biPlanes As Int16
        Dim biBitCount As Int16
        Dim biCompression As Int32
        Dim biSizeImage As Int32
        Dim biXPelsPerMeter As Int32
        Dim biYPelsPerMeter As Int32
        Dim biClrUsed As Int32
        Dim biClrImportant As Int32
    End Structure
    'Import DLL file
    'Calling by Val
    <DllImport("gdi32.dll", EntryPoint:="CreateDIBSection", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function CreateDIBSection(ByVal hdc As IntPtr, ByRef pbmi As BITMAPINFOHEADER, _
    ByVal iUsage As Int32, ByVal ppvBits As IntPtr, ByVal hSection As IntPtr, _
    ByVal dwOffset As Int32) As IntPtr
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("gdi32.dll", EntryPoint:="PatBlt", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function PatBlt(ByVal hDC As IntPtr, ByVal nXLeft As Int32, _
        ByVal nYLeft As Int32, ByVal nWidth As Int32, ByVal nHeight As Int32, _
        ByVal dwRop As Int32) As Boolean
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("gdi32.dll", EntryPoint:="SelectObject", _
    SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObj As IntPtr) As IntPtr
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("GDI32.dll", EntryPoint:="CreateCompatibleDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function CreateCompatibleDC(ByVal hRefDC As IntPtr) As IntPtr
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("GDI32.dll", EntryPoint:="DeleteDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DeleteDC(ByVal hDC As IntPtr) As Boolean
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("GDI32.dll", EntryPoint:="DeleteObject", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function DeleteObject(ByVal hObj As IntPtr) As Boolean
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("User32.dll", EntryPoint:="ReleaseDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Boolean
    End Function
    'Import DLL file
    'Calling by Val
    <DllImport("User32.dll", EntryPoint:="GetDC", SetLastError:=True, CharSet:=CharSet.Unicode, _
    ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
    Public Shared Function GetDC(ByVal hWnd As IntPtr) As IntPtr
    End Function
End Class