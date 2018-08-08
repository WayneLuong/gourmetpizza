<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.lstPizza = New System.Windows.Forms.ListBox
        Me.Pizzas = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Pizzas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPizza
        '
        Me.lstPizza.FormattingEnabled = True
        Me.lstPizza.Items.AddRange(New Object() {"Cheese and Tomato", "Pepperoni", "Hawaiian", "Meat feast", "Vegetarian", "BBQ chicken", "Create your own"})
        Me.lstPizza.Location = New System.Drawing.Point(18, 34)
        Me.lstPizza.Name = "lstPizza"
        Me.lstPizza.Size = New System.Drawing.Size(126, 108)
        Me.lstPizza.TabIndex = 0
        '
        'Pizzas
        '
        Me.Pizzas.Controls.Add(Me.Label3)
        Me.Pizzas.Controls.Add(Me.Label2)
        Me.Pizzas.Controls.Add(Me.Label1)
        Me.Pizzas.Controls.Add(Me.lstPizza)
        Me.Pizzas.Location = New System.Drawing.Point(25, 70)
        Me.Pizzas.Name = "Pizzas"
        Me.Pizzas.Size = New System.Drawing.Size(373, 169)
        Me.Pizzas.TabIndex = 2
        Me.Pizzas.TabStop = False
        Me.Pizzas.Text = "Pizzas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 251)
        Me.Controls.Add(Me.Pizzas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.Pizzas.ResumeLayout(False)
        Me.Pizzas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPizza As System.Windows.Forms.ListBox
    Friend WithEvents Pizzas As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
