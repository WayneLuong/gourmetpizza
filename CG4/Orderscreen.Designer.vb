<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orderscreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orderscreen))
        Me.Radthin = New System.Windows.Forms.RadioButton
        Me.Radthick = New System.Windows.Forms.RadioButton
        Me.RadStuffed = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnOrder = New System.Windows.Forms.Button
        Me.Btnremove = New System.Windows.Forms.Button
        Me.RadCheese = New System.Windows.Forms.RadioButton
        Me.RadHaw = New System.Windows.Forms.RadioButton
        Me.RadVeg = New System.Windows.Forms.RadioButton
        Me.radmeat = New System.Windows.Forms.RadioButton
        Me.RadPep = New System.Windows.Forms.RadioButton
        Me.RadBBQ = New System.Windows.Forms.RadioButton
        Me.RadCYO = New System.Windows.Forms.RadioButton
        Me.ChCheese = New System.Windows.Forms.CheckBox
        Me.ChOnions = New System.Windows.Forms.CheckBox
        Me.chsausage = New System.Windows.Forms.CheckBox
        Me.chpineapple = New System.Windows.Forms.CheckBox
        Me.chpepperoni = New System.Windows.Forms.CheckBox
        Me.chmeatballs = New System.Windows.Forms.CheckBox
        Me.chsweetcorn = New System.Windows.Forms.CheckBox
        Me.cholives = New System.Windows.Forms.CheckBox
        Me.chham = New System.Windows.Forms.CheckBox
        Me.chbacon = New System.Windows.Forms.CheckBox
        Me.chbbq = New System.Windows.Forms.CheckBox
        Me.chpepper = New System.Windows.Forms.CheckBox
        Me.chmushrooms = New System.Windows.Forms.CheckBox
        Me.chjalapenos = New System.Windows.Forms.CheckBox
        Me.chturkey = New System.Windows.Forms.CheckBox
        Me.chbeef = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstPizza = New System.Windows.Forms.ListBox
        Me.CboSize = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.lbltotal = New System.Windows.Forms.Label
        Me.txttotal = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Radthin
        '
        Me.Radthin.AutoSize = True
        Me.Radthin.Location = New System.Drawing.Point(12, 18)
        Me.Radthin.Name = "Radthin"
        Me.Radthin.Size = New System.Drawing.Size(80, 17)
        Me.Radthin.TabIndex = 0
        Me.Radthin.TabStop = True
        Me.Radthin.Text = "Italian(Thin)"
        Me.Radthin.UseVisualStyleBackColor = True
        '
        'Radthick
        '
        Me.Radthick.AutoSize = True
        Me.Radthick.Location = New System.Drawing.Point(98, 17)
        Me.Radthick.Name = "Radthick"
        Me.Radthick.Size = New System.Drawing.Size(77, 17)
        Me.Radthick.TabIndex = 1
        Me.Radthick.TabStop = True
        Me.Radthick.Text = "Pan(Thick)"
        Me.Radthick.UseVisualStyleBackColor = True
        '
        'RadStuffed
        '
        Me.RadStuffed.AutoSize = True
        Me.RadStuffed.Location = New System.Drawing.Point(181, 17)
        Me.RadStuffed.Name = "RadStuffed"
        Me.RadStuffed.Size = New System.Drawing.Size(85, 17)
        Me.RadStuffed.TabIndex = 2
        Me.RadStuffed.TabStop = True
        Me.RadStuffed.Text = "Stuffed crust"
        Me.RadStuffed.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadStuffed)
        Me.GroupBox1.Controls.Add(Me.Radthick)
        Me.GroupBox1.Controls.Add(Me.Radthin)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 565)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 45)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose your pizza base"
        '
        'BtnAdd
        '
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Location = New System.Drawing.Point(485, 187)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnOrder
        '
        Me.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOrder.Location = New System.Drawing.Point(485, 580)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(110, 29)
        Me.BtnOrder.TabIndex = 5
        Me.BtnOrder.Text = "Place order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'Btnremove
        '
        Me.Btnremove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnremove.Location = New System.Drawing.Point(566, 187)
        Me.Btnremove.Name = "Btnremove"
        Me.Btnremove.Size = New System.Drawing.Size(75, 23)
        Me.Btnremove.TabIndex = 6
        Me.Btnremove.Text = "Remove"
        Me.Btnremove.UseVisualStyleBackColor = True
        '
        'RadCheese
        '
        Me.RadCheese.AutoSize = True
        Me.RadCheese.Location = New System.Drawing.Point(20, 58)
        Me.RadCheese.Name = "RadCheese"
        Me.RadCheese.Size = New System.Drawing.Size(117, 17)
        Me.RadCheese.TabIndex = 3
        Me.RadCheese.TabStop = True
        Me.RadCheese.Text = "Cheese and tomato"
        Me.RadCheese.UseVisualStyleBackColor = True
        '
        'RadHaw
        '
        Me.RadHaw.AutoSize = True
        Me.RadHaw.Location = New System.Drawing.Point(20, 104)
        Me.RadHaw.Name = "RadHaw"
        Me.RadHaw.Size = New System.Drawing.Size(69, 17)
        Me.RadHaw.TabIndex = 7
        Me.RadHaw.TabStop = True
        Me.RadHaw.Text = "Hawaiian"
        Me.RadHaw.UseVisualStyleBackColor = True
        '
        'RadVeg
        '
        Me.RadVeg.AutoSize = True
        Me.RadVeg.Location = New System.Drawing.Point(20, 150)
        Me.RadVeg.Name = "RadVeg"
        Me.RadVeg.Size = New System.Drawing.Size(76, 17)
        Me.RadVeg.TabIndex = 8
        Me.RadVeg.TabStop = True
        Me.RadVeg.Text = "Vegetarian"
        Me.RadVeg.UseVisualStyleBackColor = True
        '
        'radmeat
        '
        Me.radmeat.AutoSize = True
        Me.radmeat.Location = New System.Drawing.Point(20, 127)
        Me.radmeat.Name = "radmeat"
        Me.radmeat.Size = New System.Drawing.Size(75, 17)
        Me.radmeat.TabIndex = 9
        Me.radmeat.TabStop = True
        Me.radmeat.Text = "Meat feast"
        Me.radmeat.UseVisualStyleBackColor = True
        '
        'RadPep
        '
        Me.RadPep.AutoSize = True
        Me.RadPep.Location = New System.Drawing.Point(20, 81)
        Me.RadPep.Name = "RadPep"
        Me.RadPep.Size = New System.Drawing.Size(73, 17)
        Me.RadPep.TabIndex = 10
        Me.RadPep.TabStop = True
        Me.RadPep.Text = "Pepperoni"
        Me.RadPep.UseVisualStyleBackColor = True
        '
        'RadBBQ
        '
        Me.RadBBQ.AutoSize = True
        Me.RadBBQ.Location = New System.Drawing.Point(20, 173)
        Me.RadBBQ.Name = "RadBBQ"
        Me.RadBBQ.Size = New System.Drawing.Size(88, 17)
        Me.RadBBQ.TabIndex = 11
        Me.RadBBQ.TabStop = True
        Me.RadBBQ.Text = "BBQ chicken"
        Me.RadBBQ.UseVisualStyleBackColor = True
        '
        'RadCYO
        '
        Me.RadCYO.AutoSize = True
        Me.RadCYO.Location = New System.Drawing.Point(20, 196)
        Me.RadCYO.Name = "RadCYO"
        Me.RadCYO.Size = New System.Drawing.Size(102, 17)
        Me.RadCYO.TabIndex = 12
        Me.RadCYO.TabStop = True
        Me.RadCYO.Text = "Create your own"
        Me.RadCYO.UseVisualStyleBackColor = True
        '
        'ChCheese
        '
        Me.ChCheese.AutoSize = True
        Me.ChCheese.Location = New System.Drawing.Point(18, 12)
        Me.ChCheese.Name = "ChCheese"
        Me.ChCheese.Size = New System.Drawing.Size(62, 17)
        Me.ChCheese.TabIndex = 13
        Me.ChCheese.Text = "Cheese"
        Me.ChCheese.UseVisualStyleBackColor = True
        '
        'ChOnions
        '
        Me.ChOnions.AutoSize = True
        Me.ChOnions.Location = New System.Drawing.Point(18, 35)
        Me.ChOnions.Name = "ChOnions"
        Me.ChOnions.Size = New System.Drawing.Size(59, 17)
        Me.ChOnions.TabIndex = 14
        Me.ChOnions.Text = "Onions"
        Me.ChOnions.UseVisualStyleBackColor = True
        '
        'chsausage
        '
        Me.chsausage.AutoSize = True
        Me.chsausage.Location = New System.Drawing.Point(94, 81)
        Me.chsausage.Name = "chsausage"
        Me.chsausage.Size = New System.Drawing.Size(68, 17)
        Me.chsausage.TabIndex = 15
        Me.chsausage.Text = "Sausage"
        Me.chsausage.UseVisualStyleBackColor = True
        '
        'chpineapple
        '
        Me.chpineapple.AutoSize = True
        Me.chpineapple.Location = New System.Drawing.Point(188, 12)
        Me.chpineapple.Name = "chpineapple"
        Me.chpineapple.Size = New System.Drawing.Size(73, 17)
        Me.chpineapple.TabIndex = 16
        Me.chpineapple.Text = "Pineapple"
        Me.chpineapple.UseVisualStyleBackColor = True
        '
        'chpepperoni
        '
        Me.chpepperoni.AutoSize = True
        Me.chpepperoni.Location = New System.Drawing.Point(94, 12)
        Me.chpepperoni.Name = "chpepperoni"
        Me.chpepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chpepperoni.TabIndex = 17
        Me.chpepperoni.Text = "Pepperoni"
        Me.chpepperoni.UseVisualStyleBackColor = True
        '
        'chmeatballs
        '
        Me.chmeatballs.AutoSize = True
        Me.chmeatballs.Location = New System.Drawing.Point(18, 81)
        Me.chmeatballs.Name = "chmeatballs"
        Me.chmeatballs.Size = New System.Drawing.Size(71, 17)
        Me.chmeatballs.TabIndex = 18
        Me.chmeatballs.Text = "Meatballs"
        Me.chmeatballs.UseVisualStyleBackColor = True
        '
        'chsweetcorn
        '
        Me.chsweetcorn.AutoSize = True
        Me.chsweetcorn.Location = New System.Drawing.Point(188, 35)
        Me.chsweetcorn.Name = "chsweetcorn"
        Me.chsweetcorn.Size = New System.Drawing.Size(77, 17)
        Me.chsweetcorn.TabIndex = 19
        Me.chsweetcorn.Text = "Sweetcorn"
        Me.chsweetcorn.UseVisualStyleBackColor = True
        '
        'cholives
        '
        Me.cholives.AutoSize = True
        Me.cholives.Location = New System.Drawing.Point(94, 35)
        Me.cholives.Name = "cholives"
        Me.cholives.Size = New System.Drawing.Size(55, 17)
        Me.cholives.TabIndex = 20
        Me.cholives.Text = "Olives"
        Me.cholives.UseVisualStyleBackColor = True
        '
        'chham
        '
        Me.chham.AutoSize = True
        Me.chham.Location = New System.Drawing.Point(188, 81)
        Me.chham.Name = "chham"
        Me.chham.Size = New System.Drawing.Size(48, 17)
        Me.chham.TabIndex = 21
        Me.chham.Text = "Ham"
        Me.chham.UseVisualStyleBackColor = True
        '
        'chbacon
        '
        Me.chbacon.AutoSize = True
        Me.chbacon.Location = New System.Drawing.Point(188, 58)
        Me.chbacon.Name = "chbacon"
        Me.chbacon.Size = New System.Drawing.Size(57, 17)
        Me.chbacon.TabIndex = 22
        Me.chbacon.Text = "Bacon"
        Me.chbacon.UseVisualStyleBackColor = True
        '
        'chbbq
        '
        Me.chbbq.AutoSize = True
        Me.chbbq.Location = New System.Drawing.Point(94, 58)
        Me.chbbq.Name = "chbbq"
        Me.chbbq.Size = New System.Drawing.Size(89, 17)
        Me.chbbq.TabIndex = 23
        Me.chbbq.Text = "BBQ chicken"
        Me.chbbq.UseVisualStyleBackColor = True
        '
        'chpepper
        '
        Me.chpepper.AutoSize = True
        Me.chpepper.Location = New System.Drawing.Point(18, 58)
        Me.chpepper.Name = "chpepper"
        Me.chpepper.Size = New System.Drawing.Size(60, 17)
        Me.chpepper.TabIndex = 24
        Me.chpepper.Text = "Pepper"
        Me.chpepper.UseVisualStyleBackColor = True
        '
        'chmushrooms
        '
        Me.chmushrooms.AutoSize = True
        Me.chmushrooms.Location = New System.Drawing.Point(276, 81)
        Me.chmushrooms.Name = "chmushrooms"
        Me.chmushrooms.Size = New System.Drawing.Size(80, 17)
        Me.chmushrooms.TabIndex = 25
        Me.chmushrooms.Text = "Mushrooms"
        Me.chmushrooms.UseVisualStyleBackColor = True
        '
        'chjalapenos
        '
        Me.chjalapenos.AutoSize = True
        Me.chjalapenos.Location = New System.Drawing.Point(276, 58)
        Me.chjalapenos.Name = "chjalapenos"
        Me.chjalapenos.Size = New System.Drawing.Size(74, 17)
        Me.chjalapenos.TabIndex = 26
        Me.chjalapenos.Text = "Jalapenos"
        Me.chjalapenos.UseVisualStyleBackColor = True
        '
        'chturkey
        '
        Me.chturkey.AutoSize = True
        Me.chturkey.Location = New System.Drawing.Point(276, 12)
        Me.chturkey.Name = "chturkey"
        Me.chturkey.Size = New System.Drawing.Size(59, 17)
        Me.chturkey.TabIndex = 27
        Me.chturkey.Text = "Turkey"
        Me.chturkey.UseVisualStyleBackColor = True
        '
        'chbeef
        '
        Me.chbeef.AutoSize = True
        Me.chbeef.Location = New System.Drawing.Point(276, 35)
        Me.chbeef.Name = "chbeef"
        Me.chbeef.Size = New System.Drawing.Size(48, 17)
        Me.chbeef.TabIndex = 28
        Me.chbeef.Text = "Beef"
        Me.chbeef.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chbeef)
        Me.Panel1.Controls.Add(Me.chturkey)
        Me.Panel1.Controls.Add(Me.chjalapenos)
        Me.Panel1.Controls.Add(Me.chmushrooms)
        Me.Panel1.Controls.Add(Me.chpepper)
        Me.Panel1.Controls.Add(Me.chbbq)
        Me.Panel1.Controls.Add(Me.chbacon)
        Me.Panel1.Controls.Add(Me.chham)
        Me.Panel1.Controls.Add(Me.cholives)
        Me.Panel1.Controls.Add(Me.chsweetcorn)
        Me.Panel1.Controls.Add(Me.chmeatballs)
        Me.Panel1.Controls.Add(Me.chpepperoni)
        Me.Panel1.Controls.Add(Me.chpineapple)
        Me.Panel1.Controls.Add(Me.chsausage)
        Me.Panel1.Controls.Add(Me.ChOnions)
        Me.Panel1.Controls.Add(Me.ChCheese)
        Me.Panel1.Location = New System.Drawing.Point(20, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 112)
        Me.Panel1.TabIndex = 29
        Me.Panel1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.RadCYO)
        Me.GroupBox2.Controls.Add(Me.RadBBQ)
        Me.GroupBox2.Controls.Add(Me.RadPep)
        Me.GroupBox2.Controls.Add(Me.radmeat)
        Me.GroupBox2.Controls.Add(Me.RadVeg)
        Me.GroupBox2.Controls.Add(Me.RadHaw)
        Me.GroupBox2.Controls.Add(Me.RadCheese)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 362)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose your pizza"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(310, 197)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 61
        Me.Label29.Text = "£12.00"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(264, 197)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 13)
        Me.Label30.TabIndex = 60
        Me.Label30.Text = "£10.00"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(217, 198)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 59
        Me.Label31.Text = "£8.00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(177, 198)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 13)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "£5.00"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(310, 173)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 13)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "£12.00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(264, 173)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "£10.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(217, 173)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(34, 13)
        Me.Label27.TabIndex = 55
        Me.Label27.Text = "£8.00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(177, 173)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "£5.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(310, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "£12.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(264, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "£10.00"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(217, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "£8.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(177, 152)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 13)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "£5.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(310, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "£12.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(264, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "£10.00"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(217, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "£8.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(177, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 13)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "£5.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(310, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "£12.00"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(264, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "£10.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(217, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "£8.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(177, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "£5.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(310, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "£12.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "£10.00"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(217, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "£8.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(177, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "£5.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(217, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "M (10"")"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(265, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "L (12"")"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "XL (14"")"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "S (8"")"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "£12.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "£10.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "£8.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "£5.00"
        '
        'lstPizza
        '
        Me.lstPizza.FormattingEnabled = True
        Me.lstPizza.HorizontalScrollbar = True
        Me.lstPizza.Location = New System.Drawing.Point(469, 217)
        Me.lstPizza.Name = "lstPizza"
        Me.lstPizza.Size = New System.Drawing.Size(172, 316)
        Me.lstPizza.TabIndex = 31
        '
        'CboSize
        '
        Me.CboSize.BackColor = System.Drawing.SystemColors.Window
        Me.CboSize.ForeColor = System.Drawing.Color.Black
        Me.CboSize.FormattingEnabled = True
        Me.CboSize.Items.AddRange(New Object() {"Small", "Medium", "Large", "Extra Large"})
        Me.CboSize.Location = New System.Drawing.Point(17, 16)
        Me.CboSize.Name = "CboSize"
        Me.CboSize.Size = New System.Drawing.Size(96, 21)
        Me.CboSize.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CboSize)
        Me.GroupBox3.Location = New System.Drawing.Point(311, 564)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(130, 49)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Size"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 179)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 616)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(32, 13)
        Me.LinkLabel1.TabIndex = 35
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Back"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(875, 799)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 62
        Me.lbltotal.Text = "0"
        '
        'txttotal
        '
        Me.txttotal.AutoSize = True
        Me.txttotal.Location = New System.Drawing.Point(566, 556)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(13, 13)
        Me.txttotal.TabIndex = 63
        Me.txttotal.Text = "0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(517, 556)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 13)
        Me.Label34.TabIndex = 64
        Me.Label34.Text = "Total: £"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(466, 543)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(86, 13)
        Me.Label35.TabIndex = 65
        Me.Label35.Text = "Number of items:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(566, 543)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 13)
        Me.Label36.TabIndex = 66
        Me.Label36.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(15, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 18)
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'Orderscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(679, 635)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lstPizza)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btnremove)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Orderscreen"
        Me.Text = "Order now!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Radthin As System.Windows.Forms.RadioButton
    Friend WithEvents Radthick As System.Windows.Forms.RadioButton
    Friend WithEvents RadStuffed As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnOrder As System.Windows.Forms.Button
    Friend WithEvents Btnremove As System.Windows.Forms.Button
    Friend WithEvents RadCheese As System.Windows.Forms.RadioButton
    Friend WithEvents RadHaw As System.Windows.Forms.RadioButton
    Friend WithEvents RadVeg As System.Windows.Forms.RadioButton
    Friend WithEvents radmeat As System.Windows.Forms.RadioButton
    Friend WithEvents RadPep As System.Windows.Forms.RadioButton
    Friend WithEvents RadBBQ As System.Windows.Forms.RadioButton
    Friend WithEvents RadCYO As System.Windows.Forms.RadioButton
    Friend WithEvents ChCheese As System.Windows.Forms.CheckBox
    Friend WithEvents ChOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chsausage As System.Windows.Forms.CheckBox
    Friend WithEvents chpineapple As System.Windows.Forms.CheckBox
    Friend WithEvents chpepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents chmeatballs As System.Windows.Forms.CheckBox
    Friend WithEvents chsweetcorn As System.Windows.Forms.CheckBox
    Friend WithEvents cholives As System.Windows.Forms.CheckBox
    Friend WithEvents chham As System.Windows.Forms.CheckBox
    Friend WithEvents chbacon As System.Windows.Forms.CheckBox
    Friend WithEvents chbbq As System.Windows.Forms.CheckBox
    Friend WithEvents chpepper As System.Windows.Forms.CheckBox
    Friend WithEvents chmushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chjalapenos As System.Windows.Forms.CheckBox
    Friend WithEvents chturkey As System.Windows.Forms.CheckBox
    Friend WithEvents chbeef As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lstPizza As System.Windows.Forms.ListBox
    Friend WithEvents CboSize As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
