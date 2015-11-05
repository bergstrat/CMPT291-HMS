<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Suite = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ptype = New System.Windows.Forms.Label()
        Me.FemaleButton = New System.Windows.Forms.RadioButton()
        Me.MaleButton = New System.Windows.Forms.RadioButton()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Enumb = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Ename = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Snumb = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Pnumb = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Province = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.Label()
        Me.Country = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Pcode = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mname = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Lname = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 17)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Patient Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 17)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Emergency Contact Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 17)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Contact Information"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(67, 164)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(51, 20)
        Me.TextBox14.TabIndex = 75
        '
        'Suite
        '
        Me.Suite.AutoSize = True
        Me.Suite.Location = New System.Drawing.Point(20, 167)
        Me.Suite.Name = "Suite"
        Me.Suite.Size = New System.Drawing.Size(41, 13)
        Me.Suite.TabIndex = 74
        Me.Suite.Text = "Suite #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Address"
        '
        'Ptype
        '
        Me.Ptype.AutoSize = True
        Me.Ptype.Location = New System.Drawing.Point(423, 109)
        Me.Ptype.Name = "Ptype"
        Me.Ptype.Size = New System.Drawing.Size(67, 13)
        Me.Ptype.TabIndex = 72
        Me.Ptype.Text = "Patient Type"
        '
        'FemaleButton
        '
        Me.FemaleButton.AutoSize = True
        Me.FemaleButton.Location = New System.Drawing.Point(358, 105)
        Me.FemaleButton.Name = "FemaleButton"
        Me.FemaleButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleButton.TabIndex = 71
        Me.FemaleButton.TabStop = True
        Me.FemaleButton.Text = "Female"
        Me.FemaleButton.UseVisualStyleBackColor = True
        '
        'MaleButton
        '
        Me.MaleButton.AutoSize = True
        Me.MaleButton.Location = New System.Drawing.Point(287, 105)
        Me.MaleButton.Name = "MaleButton"
        Me.MaleButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleButton.TabIndex = 70
        Me.MaleButton.TabStop = True
        Me.MaleButton.Text = "Male"
        Me.MaleButton.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(166, 367)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(104, 20)
        Me.TextBox13.TabIndex = 69
        '
        'Enumb
        '
        Me.Enumb.AutoSize = True
        Me.Enumb.Location = New System.Drawing.Point(20, 370)
        Me.Enumb.Name = "Enumb"
        Me.Enumb.Size = New System.Drawing.Size(140, 13)
        Me.Enumb.TabIndex = 68
        Me.Enumb.Text = "Emergency Contact Number"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(358, 325)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(124, 20)
        Me.TextBox12.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 325)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Relationship"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(157, 325)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(124, 20)
        Me.TextBox4.TabIndex = 65
        '
        'Ename
        '
        Me.Ename.AutoSize = True
        Me.Ename.Location = New System.Drawing.Point(20, 328)
        Me.Ename.Name = "Ename"
        Me.Ename.Size = New System.Drawing.Size(131, 13)
        Me.Ename.TabIndex = 64
        Me.Ename.Text = "Emergency Contact Name"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(57, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 63
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(366, 267)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 62
        '
        'Snumb
        '
        Me.Snumb.AutoSize = True
        Me.Snumb.Location = New System.Drawing.Point(237, 271)
        Me.Snumb.Name = "Snumb"
        Me.Snumb.Size = New System.Drawing.Size(98, 13)
        Me.Snumb.TabIndex = 61
        Me.Snumb.Text = "Secondary Number"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(112, 269)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(104, 20)
        Me.TextBox10.TabIndex = 60
        '
        'Pnumb
        '
        Me.Pnumb.AutoSize = True
        Me.Pnumb.Location = New System.Drawing.Point(25, 269)
        Me.Pnumb.Name = "Pnumb"
        Me.Pnumb.Size = New System.Drawing.Size(81, 13)
        Me.Pnumb.TabIndex = 59
        Me.Pnumb.Text = "Primary Number"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(382, 207)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(37, 20)
        Me.TextBox8.TabIndex = 58
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(186, 207)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 57
        '
        'Province
        '
        Me.Province.AutoSize = True
        Me.Province.Location = New System.Drawing.Point(292, 210)
        Me.Province.Name = "Province"
        Me.Province.Size = New System.Drawing.Size(79, 13)
        Me.Province.TabIndex = 56
        Me.Province.Text = "Province/State"
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(156, 207)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(24, 13)
        Me.City.TabIndex = 55
        Me.City.Text = "City"
        '
        'Country
        '
        Me.Country.AutoSize = True
        Me.Country.Location = New System.Drawing.Point(423, 210)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(43, 13)
        Me.Country.TabIndex = 54
        Me.Country.Text = "Country"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(109, 204)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(42, 20)
        Me.TextBox6.TabIndex = 53
        '
        'Pcode
        '
        Me.Pcode.AutoSize = True
        Me.Pcode.Location = New System.Drawing.Point(19, 207)
        Me.Pcode.Name = "Pcode"
        Me.Pcode.Size = New System.Drawing.Size(84, 13)
        Me.Pcode.TabIndex = 52
        Me.Pcode.Text = "Postal Code/Zip"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(222, 164)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(149, 20)
        Me.TextBox5.TabIndex = 51
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Location = New System.Drawing.Point(131, 167)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(76, 13)
        Me.Address.TabIndex = 50
        Me.Address.Text = "Street Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "DOB "
        '
        'Mname
        '
        Me.Mname.AutoSize = True
        Me.Mname.Location = New System.Drawing.Point(207, 74)
        Me.Mname.Name = "Mname"
        Me.Mname.Size = New System.Drawing.Size(50, 13)
        Me.Mname.TabIndex = 48
        Me.Mname.Text = "M. Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(261, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 47
        '
        'Lname
        '
        Me.Lname.AutoSize = True
        Me.Lname.Location = New System.Drawing.Point(362, 77)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(58, 13)
        Me.Lname.TabIndex = 46
        Me.Lname.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(424, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 45
        '
        'Fname
        '
        Me.Fname.AutoSize = True
        Me.Fname.Location = New System.Drawing.Point(21, 74)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(57, 13)
        Me.Fname.TabIndex = 44
        Me.Fname.Text = "First Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(101, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Create Patient Record"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 489)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Suite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ptype)
        Me.Controls.Add(Me.FemaleButton)
        Me.Controls.Add(Me.MaleButton)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Enumb)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Ename)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Snumb)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Pnumb)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Province)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Pcode)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mname)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Suite As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Ptype As Label
    Friend WithEvents FemaleButton As RadioButton
    Friend WithEvents MaleButton As RadioButton
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Enumb As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Ename As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Snumb As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Pnumb As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Province As Label
    Friend WithEvents City As Label
    Friend WithEvents Country As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Pcode As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Mname As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Lname As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Fname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
