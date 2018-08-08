Module Structures
    'Declaration of each structure
    Structure Person
        <VBFixedString(4)> Public title As String
        <VBFixedString(30)> Public name As String
        <VBFixedString(30)> Public surname As String
        Public age As Short
        <VBFixedString(30)> Public username As String
        <VBFixedString(30)> Public Password As String
        <VBFixedString(30)> Public question As String
        <VBFixedString(30)> Public answer As String
        <VBFixedString(30)> Public Address As String
        <VBFixedString(30)> Public City As String
        <VBFixedString(30)> Public county As String
        <VBFixedString(30)> Public Postcode As String
        <VBFixedString(30)> Public Contactnumber As String
        <VBFixedString(30)> Public Email As String
        Public deleted As Boolean
    End Structure
    Structure Admin
        <VBFixedString(30)> Public password As String
        Public revenue As Integer
    End Structure
    Structure Pizza
        <VBFixedString(30)> Public Size As String
        <VBFixedString(30)> Public Base As String
        <VBFixedString(30)> Public Type As String
        <VBFixedString(30)> Public Topping As String
        <VBFixedString(30)> Public Price As Decimal
        Public PizzaNo As Integer
        Public Deleted As Boolean
        Public Orderno As Integer
    End Structure
    Structure Order
        Public Total As String
        Public Pizza1 As String
        Public Pizza2 As String
        Public Pizza3 As String
        Public Pizza4 As String
        Public Pizza5 As String
        Public Pizza6 As String
        Public Pizza7 As String
        Public Pizza8 As String
        Public Pizza9 As String
        Public Pizza10 As String
        Public Deleted As Boolean
        Public Orderno As Integer
    End Structure

    'Global variables
    Public numberofitems
    Public Oneorder As Order
    Public Onepizza As Pizza
    Public OneAdmin As Admin
    Public OnePerson As Person
    Public FileName As String
    Public NumberOfRecords As Integer
    Public NumberOfOrders As Integer
    Public NumberOfPizzas As Integer
    Public index As Integer
    Public fullname As String

End Module
