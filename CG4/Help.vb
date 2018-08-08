Public Class Help

    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lstpizza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPizza.SelectedIndexChanged
        'Variable 'Pizza set up for a Case loop
        Dim pizza As String
        pizza = lstPizza.Text       'selected item from pizza list box
        'Case loop
        'Which populates the labels with the stated text
        Select Case pizza
            Case "Cheese and Tomato"
                'Text in each label
                Label1.Text = "Simple mozzarella cheese and tomato"
                Label2.Text = "baked to perfection."
                'Stated labels become visible
                Label1.Visible = True
                Label2.Visible = True
            Case "Pepperoni"
                'Text in each label
                Label1.Text = "Spicy pepperoni topped with mushrooms,"
                Label2.Text = "green peppers and onions"
                'Stated labels become visible
                Label1.Visible = True
                Label2.Visible = True
            Case "Hawaiian"
                'Text in each label
                Label1.Text = "Classic ham and pineapple pizza"
                'Stated labels become visible
                Label1.Visible = True
                Label2.Visible = True
            Case "Meat feast"
                'Text in each label
                Label1.Text = "Cheesy pizza topped with pepperoni,"
                Label2.Text = "sausage, lamb meatballs and ham"
                'Stated labels become visible
                Label1.Visible = True
                Label2.Visible = True
            Case "Vegetarian"
                'Text in each label
                Label1.Text = "For vegans, cheesy pizza with Green "
                Label2.Text = "peppers, sweetcorn, olives, mushrooms "
                Label3.Text = "and onions"
                'Stated labels become visible
                Label3.Visible = True
                Label1.Visible = True
                Label2.Visible = True
            Case "BBQ chicken"
                'Text in each label
                Label1.Text = "Sweet BBQ chicken pizza with mushrooms,"
                Label2.Text = "onions and green peppers"
                'Stated labels become visible
                Label1.Visible = True
                Label2.Visible = True
            Case "Create your own"
                'Text in each label
                Label1.Text = "Add any topping of your choice from "
                Label2.Text = "our range of toppings"
                'Stated labels become visible
                Label1.Visible = True
                Label2.Visible = True
        End Select

    End Sub
End Class