Public Class Orderscreen



    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadCYO.CheckedChanged
        'If radio button is checked then
        'Shows/Hide form controls
        If RadCYO.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub


    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'If loop - to check whether the radio buttons has been checked. If it has been checked then loop through and
        'Add valid pizza items into structure Pizza
        If RadCheese.Checked = True Then
            Onepizza.Type = Trim(RadCheese.Text)
        ElseIf RadPep.Checked = True Then
            Onepizza.Type = Trim(RadPep.Text)
        ElseIf RadHaw.Checked = True Then
            Onepizza.Type = Trim(RadHaw.Text)
        ElseIf radmeat.Checked = True Then
            Onepizza.Type = Trim(radmeat.Text)
        ElseIf RadVeg.Checked = True Then
            Onepizza.Type = Trim(RadVeg.Text)
        ElseIf RadBBQ.Checked = True Then
            Onepizza.Type = Trim(RadBBQ.Text)
        ElseIf RadCYO.Checked = True Then
            Onepizza.Type = Trim(RadCYO.Text)
        End If
        'If true then loop and add pizza variable into pizza record
        If Radthin.Checked = True Then
            Onepizza.Base = Trim(Radthin.Text)
        ElseIf Radthick.Checked = True Then
            Onepizza.Base = Trim(Radthick.Text)
        ElseIf RadStuffed.Checked = True Then
            Onepizza.Base = Trim(RadStuffed.Text)
        End If
        'Presence check to check if the user has filled in all fields
        ' if there is an empty field then the user is informed if this via a message box
        If CboSize.Text = "" Then
            MsgBox("Please select a size")
        Else
            Onepizza.Size = Trim(CboSize.Text)
        End If
        If Onepizza.Size = "Small" Then
            Onepizza.Price = 5.0
        ElseIf Onepizza.Size = "Medium" Then
            Onepizza.Price = 8.0
        ElseIf Onepizza.Size = "Large" Then
            Onepizza.Price = 10.0
        ElseIf Onepizza.Size = "Extra Large" Then
            Onepizza.Price = 12.0
        End If
        If Onepizza.Type = "" Then
            MsgBox("Please choose a type of pizza")
        ElseIf Onepizza.Base = "" Then
            MsgBox("Please select a base")
        ElseIf Onepizza.Size = "" Then
            MsgBox("Please select a size")
        ElseIf RadCYO.Checked = True Then
            numberofitems = lstPizza.Items.Count
            Label36.Text = numberofitems
            'If the number of items is less than 10 then
            If numberofitems < 10 Then 'Loop through code
                'The total of the order is calculated and outputted through a label
                Oneorder.Total = Oneorder.Total + Onepizza.Price
                txttotal.Text = Oneorder.Total
                txttotal.Text = Format(Oneorder.Total, "Currency")

                'open pizza file
                FileName = CurDir() & "\Pizza.dat"
                FileOpen(3, FileName, OpenMode.Random, , , Len(Onepizza))
                'Adds the pizza record to the pizza file
                NumberOfPizzas = LOF(3) / Len(Onepizza)
                Onepizza.PizzaNo = NumberOfPizzas + 1
                'new record = not deleted
                Onepizza.Deleted = False
                'The If loop is to check whether the variable is empty, If it is empty then the pizzaID number will be saved onto the variable
                If Oneorder.Pizza1 = "" Then
                    Oneorder.Pizza1 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza2 = "" Then
                    Oneorder.Pizza2 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza3 = "" Then
                    Oneorder.Pizza3 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza4 = "" Then
                    Oneorder.Pizza4 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza5 = "" Then
                    Oneorder.Pizza5 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza6 = "" Then
                    Oneorder.Pizza6 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza7 = "" Then
                    Oneorder.Pizza7 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza8 = "" Then
                    Oneorder.Pizza8 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza9 = "" Then
                    Oneorder.Pizza9 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza10 = "" Then
                    Oneorder.Pizza10 = Onepizza.PizzaNo
                End If
                'Stores the record back into the pizza file and adds 1 to the total amount of pizza records
                FilePut(3, Onepizza, NumberOfPizzas + 1)

                'If checked then add pizza record to list box
                lstPizza.Items.Add("No" & Onepizza.PizzaNo & " " & Onepizza.Size & ", " & Onepizza.Base & " base, " & Onepizza.Type & " Pizza" & " x1" & " ...£" & Onepizza.Price)
                If ChCheese.Checked = True Then
                    lstPizza.Items.Add("w/ " & ChCheese.Text)
                End If
                If ChOnions.Checked = True Then
                    lstPizza.Items.Add("w/ " & ChOnions.Text)
                End If
                If chpepper.Checked = True Then
                    lstPizza.Items.Add("w/ " & chpepper.Text)
                End If
                If chmeatballs.Checked = True Then
                    lstPizza.Items.Add("w/ " & chmeatballs.Text)
                End If
                If chpepperoni.Checked = True Then
                    lstPizza.Items.Add("w/ " & chpepperoni.Text)
                End If
                If cholives.Checked = True Then
                    lstPizza.Items.Add("w/ " & cholives.Text)
                End If
                If chbbq.Checked = True Then
                    lstPizza.Items.Add("w/ " & chbbq.Text)
                End If
                If chsausage.Checked = True Then
                    lstPizza.Items.Add("w/ " & chsausage.Text)
                End If
                If chpineapple.Checked = True Then
                    lstPizza.Items.Add("w/ " & chpineapple.Text)
                End If
                If chsweetcorn.Checked = True Then
                    lstPizza.Items.Add("w/ " & chsweetcorn.Text)
                End If
                If chbacon.Checked = True Then
                    lstPizza.Items.Add("w/ " & chbacon.Text)
                End If
                If chturkey.Checked = True Then
                    lstPizza.Items.Add("w/ " & chturkey.Text)
                End If
                If chham.Checked = True Then
                    lstPizza.Items.Add("w/ " & chham.Text)
                End If
                If chbeef.Checked = True Then
                    lstPizza.Items.Add("w/ " & chbeef.Text)
                End If
                If chjalapenos.Checked = True Then
                    lstPizza.Items.Add("w/ " & chjalapenos.Text)
                End If
                If chmushrooms.Checked = True Then
                    lstPizza.Items.Add("w/ " & chmushrooms.Text)
                End If

                'Close pizza file
                FileClose(3)
                'Validation to ensure only 10 pizzas maximun in the list box
            ElseIf numberofitems = 10 Or numberofitems > 10 Then
                MsgBox("10 pizzas maximum")
            End If
        Else
            'Counts the number of items in list box
            numberofitems = lstPizza.Items.Count
            'Out put the number of items in list box
            Label36.Text = numberofitems

            'Calculates the total price of the order
            'This calcualtion is then displayed onto the label
            If numberofitems < 10 Then
                Oneorder.Total = Oneorder.Total + Onepizza.Price
                txttotal.Text = Oneorder.Total
                'Outputs this variable in the value of currency
                txttotal.Text = Format(Oneorder.Total, "Currency")

                'open pizza file
                FileName = CurDir() & "\Pizza.dat"
                FileOpen(3, FileName, OpenMode.Random, , , Len(Onepizza))
                'Add the pizza record to pizza file
                NumberOfOrders = LOF(4) / Len(Oneorder)
                NumberOfPizzas = LOF(3) / Len(Onepizza)
                Onepizza.PizzaNo = NumberOfPizzas + 1
                Onepizza.Deleted = False
                'Presence check to check whether the variable is empty, If it is empty then the pizzaID number will be saved onto the variable
                If Oneorder.Pizza1 = "" Then
                    Oneorder.Pizza1 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza2 = "" Then
                    Oneorder.Pizza2 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza3 = "" Then
                    Oneorder.Pizza3 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza4 = "" Then
                    Oneorder.Pizza4 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza5 = "" Then
                    Oneorder.Pizza5 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza6 = "" Then
                    Oneorder.Pizza6 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza7 = "" Then
                    Oneorder.Pizza7 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza8 = "" Then
                    Oneorder.Pizza8 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza9 = "" Then
                    Oneorder.Pizza9 = Onepizza.PizzaNo
                ElseIf Oneorder.Pizza10 = "" Then
                    Oneorder.Pizza10 = Onepizza.PizzaNo
                End If
                'Stores the record in the file
                FilePut(3, Onepizza, NumberOfPizzas + 1)

                'Adds the following items to the list box
                lstPizza.Items.Add("No" & Onepizza.PizzaNo & " " & Onepizza.Size & ", " & Onepizza.Base & " base, " & Onepizza.Type & " Pizza" & " x1" & " ...£" & Onepizza.Price)


                'Close pizza file
                FileClose(3)
                'Validation to ensure 10 pizza max, if the user tries to exceed this amount they will be informed of this via a message box
            ElseIf numberofitems = 10 Or numberofitems > 10 Then
                MsgBox("10 pizzas maximum")
            End If
        End If
    End Sub

    Private Sub Orderscreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'open order file
        FileName = CurDir() & "\Order.dat"
        FileOpen(4, FileName, OpenMode.Random, , , Len(Oneorder))
        'Adds text to the listbox
        lstPizza.Items.Add("Order")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Close order file
        FileClose(4)
        'Navigate to a new form
        Dim orderscreen As New Welcome
        orderscreen.ShowDialog()
    End Sub

    Private Sub Btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnremove.Click
        'Removes the selected item from the list box
        lstPizza.Items.RemoveAt(lstPizza.SelectedIndex)
        'Counts the number of items in the list box
        numberofitems = lstPizza.Items.Count
        '  Updates the number of items in the list box in a label
        Label36.Text = numberofitems
        'Shows the total in a label
        Oneorder.Total = Oneorder.Total - Onepizza.Price
        txttotal.Text = Format(Oneorder.Total, "Currency")
    End Sub

    Private Sub BtnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrder.Click
        'Range check to ensure at least one pizza is in the list, user is informed if no pizza is in the listbox
        If lstPizza.Items.Count = 1 Then
            MsgBox("No pizza has been added")
        Else
            'open admin file
            FileName = CurDir() & "\Admin.dat"
            FileOpen(2, FileName, OpenMode.Random, , , Len(OneAdmin))
            index = 1
            FileGet(2, OneAdmin, index)

            'Add a person to the file
            OneAdmin.revenue = OneAdmin.revenue + Oneorder.Total
            NumberOfOrders = LOF(4) / Len(Oneorder)
            Oneorder.Orderno = NumberOfOrders + 1
            Oneorder.Deleted = False
            FilePut(2, OneAdmin, index)
            FilePut(4, Oneorder, NumberOfOrders + 1)



            'Close files order and admin
            FileClose(4)
            FileClose(2)
            'navigate to a new form
            Dim orderscreen As New Summary
            orderscreen.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Navigate to another form
        Dim orderscreen As New Help
        orderscreen.ShowDialog()
    End Sub
End Class