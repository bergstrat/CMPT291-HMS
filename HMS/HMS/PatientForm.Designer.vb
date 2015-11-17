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
        Me.SuiteBox = New System.Windows.Forms.TextBox()
        Me.Suite = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ptype = New System.Windows.Forms.Label()
        Me.FemaleButton = New System.Windows.Forms.RadioButton()
        Me.MaleButton = New System.Windows.Forms.RadioButton()
        Me.EnumbBox = New System.Windows.Forms.TextBox()
        Me.Enumb = New System.Windows.Forms.Label()
        Me.RelationshipBox = New System.Windows.Forms.TextBox()
        Me.Relationship = New System.Windows.Forms.Label()
        Me.EnameBox = New System.Windows.Forms.TextBox()
        Me.Ename = New System.Windows.Forms.Label()
        Me.PnumbBox = New System.Windows.Forms.TextBox()
        Me.Pnumb = New System.Windows.Forms.Label()
        Me.ProvinceBox = New System.Windows.Forms.TextBox()
        Me.CityBox = New System.Windows.Forms.TextBox()
        Me.Province = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.Label()
        Me.Country = New System.Windows.Forms.Label()
        Me.PcodeBox = New System.Windows.Forms.TextBox()
        Me.Pcode = New System.Windows.Forms.Label()
        Me.StreetBox = New System.Windows.Forms.TextBox()
        Me.Street = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.Label()
        Me.Mname = New System.Windows.Forms.Label()
        Me.MnameBox = New System.Windows.Forms.TextBox()
        Me.Lname = New System.Windows.Forms.Label()
        Me.LnameBox = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.Label()
        Me.FnameBox = New System.Windows.Forms.TextBox()
        Me.CreatePatient = New System.Windows.Forms.Button()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.Birthday = New System.Windows.Forms.DateTimePicker()
        Me.PtypeBox = New System.Windows.Forms.ListBox()
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
        'SuiteBox
        '
        Me.SuiteBox.Location = New System.Drawing.Point(67, 164)
        Me.SuiteBox.Name = "SuiteBox"
        Me.SuiteBox.Size = New System.Drawing.Size(51, 20)
        Me.SuiteBox.TabIndex = 75
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
        'EnumbBox
        '
        Me.EnumbBox.Location = New System.Drawing.Point(166, 367)
        Me.EnumbBox.Name = "EnumbBox"
        Me.EnumbBox.Size = New System.Drawing.Size(115, 20)
        Me.EnumbBox.TabIndex = 69
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
        'RelationshipBox
        '
        Me.RelationshipBox.Location = New System.Drawing.Point(358, 325)
        Me.RelationshipBox.Name = "RelationshipBox"
        Me.RelationshipBox.Size = New System.Drawing.Size(124, 20)
        Me.RelationshipBox.TabIndex = 67
        '
        'Relationship
        '
        Me.Relationship.AutoSize = True
        Me.Relationship.Location = New System.Drawing.Point(287, 325)
        Me.Relationship.Name = "Relationship"
        Me.Relationship.Size = New System.Drawing.Size(65, 13)
        Me.Relationship.TabIndex = 66
        Me.Relationship.Text = "Relationship"
        '
        'EnameBox
        '
        Me.EnameBox.Location = New System.Drawing.Point(157, 325)
        Me.EnameBox.Name = "EnameBox"
        Me.EnameBox.Size = New System.Drawing.Size(124, 20)
        Me.EnameBox.TabIndex = 65
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
        'PnumbBox
        '
        Me.PnumbBox.Location = New System.Drawing.Point(112, 269)
        Me.PnumbBox.Name = "PnumbBox"
        Me.PnumbBox.Size = New System.Drawing.Size(104, 20)
        Me.PnumbBox.TabIndex = 60
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
        'ProvinceBox
        '
        Me.ProvinceBox.Location = New System.Drawing.Point(382, 207)
        Me.ProvinceBox.Name = "ProvinceBox"
        Me.ProvinceBox.Size = New System.Drawing.Size(37, 20)
        Me.ProvinceBox.TabIndex = 58
        '
        'CityBox
        '
        Me.CityBox.Location = New System.Drawing.Point(186, 207)
        Me.CityBox.Name = "CityBox"
        Me.CityBox.Size = New System.Drawing.Size(100, 20)
        Me.CityBox.TabIndex = 57
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
        'PcodeBox
        '
        Me.PcodeBox.Location = New System.Drawing.Point(109, 204)
        Me.PcodeBox.Name = "PcodeBox"
        Me.PcodeBox.Size = New System.Drawing.Size(42, 20)
        Me.PcodeBox.TabIndex = 53
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
        'StreetBox
        '
        Me.StreetBox.Location = New System.Drawing.Point(222, 164)
        Me.StreetBox.Name = "StreetBox"
        Me.StreetBox.Size = New System.Drawing.Size(149, 20)
        Me.StreetBox.TabIndex = 51
        '
        'Street
        '
        Me.Street.AutoSize = True
        Me.Street.Location = New System.Drawing.Point(131, 167)
        Me.Street.Name = "Street"
        Me.Street.Size = New System.Drawing.Size(76, 13)
        Me.Street.TabIndex = 50
        Me.Street.Text = "Street Address"
        '
        'DOB
        '
        Me.DOB.AutoSize = True
        Me.DOB.Location = New System.Drawing.Point(20, 105)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(33, 13)
        Me.DOB.TabIndex = 49
        Me.DOB.Text = "DOB "
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
        'MnameBox
        '
        Me.MnameBox.Location = New System.Drawing.Point(261, 71)
        Me.MnameBox.Name = "MnameBox"
        Me.MnameBox.Size = New System.Drawing.Size(100, 20)
        Me.MnameBox.TabIndex = 47
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
        'LnameBox
        '
        Me.LnameBox.Location = New System.Drawing.Point(424, 74)
        Me.LnameBox.Name = "LnameBox"
        Me.LnameBox.Size = New System.Drawing.Size(100, 20)
        Me.LnameBox.TabIndex = 45
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
        'FnameBox
        '
        Me.FnameBox.Location = New System.Drawing.Point(101, 71)
        Me.FnameBox.Name = "FnameBox"
        Me.FnameBox.Size = New System.Drawing.Size(100, 20)
        Me.FnameBox.TabIndex = 43
        '
        'CreatePatient
        '
        Me.CreatePatient.Location = New System.Drawing.Point(210, 420)
        Me.CreatePatient.Name = "CreatePatient"
        Me.CreatePatient.Size = New System.Drawing.Size(123, 23)
        Me.CreatePatient.TabIndex = 42
        Me.CreatePatient.Text = "Create Patient Record"
        Me.CreatePatient.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CreatePatient.UseVisualStyleBackColor = True
        '
        'CountryBox
        '
        Me.CountryBox.Location = New System.Drawing.Point(472, 207)
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(52, 20)
        Me.CountryBox.TabIndex = 79
        '
        'Birthday
        '
        Me.Birthday.Location = New System.Drawing.Point(57, 101)
        Me.Birthday.Name = "Birthday"
        Me.Birthday.Size = New System.Drawing.Size(200, 20)
        Me.Birthday.TabIndex = 63
        '
        'PtypeBox
        '
        Me.PtypeBox.FormattingEnabled = True
        Me.PtypeBox.Items.AddRange(New Object() {"In", "Out"})
        Me.PtypeBox.Location = New System.Drawing.Point(496, 109)
        Me.PtypeBox.Name = "PtypeBox"
        Me.PtypeBox.Size = New System.Drawing.Size(29, 30)
        Me.PtypeBox.TabIndex = 80
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 489)
        Me.Controls.Add(Me.PtypeBox)
        Me.Controls.Add(Me.CountryBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SuiteBox)
        Me.Controls.Add(Me.Suite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Ptype)
        Me.Controls.Add(Me.FemaleButton)
        Me.Controls.Add(Me.MaleButton)
        Me.Controls.Add(Me.EnumbBox)
        Me.Controls.Add(Me.Enumb)
        Me.Controls.Add(Me.RelationshipBox)
        Me.Controls.Add(Me.Relationship)
        Me.Controls.Add(Me.EnameBox)
        Me.Controls.Add(Me.Ename)
        Me.Controls.Add(Me.Birthday)
        Me.Controls.Add(Me.PnumbBox)
        Me.Controls.Add(Me.Pnumb)
        Me.Controls.Add(Me.ProvinceBox)
        Me.Controls.Add(Me.CityBox)
        Me.Controls.Add(Me.Province)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.PcodeBox)
        Me.Controls.Add(Me.Pcode)
        Me.Controls.Add(Me.StreetBox)
        Me.Controls.Add(Me.Street)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Mname)
        Me.Controls.Add(Me.MnameBox)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.LnameBox)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.FnameBox)
        Me.Controls.Add(Me.CreatePatient)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SuiteBox As TextBox
    Friend WithEvents Suite As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Ptype As Label
    Friend WithEvents FemaleButton As RadioButton
    Friend WithEvents MaleButton As RadioButton
    Friend WithEvents EnumbBox As TextBox
    Friend WithEvents Enumb As Label
    Friend WithEvents RelationshipBox As TextBox
    Friend WithEvents Relationship As Label
    Friend WithEvents EnameBox As TextBox
    Friend WithEvents Ename As Label
    Friend WithEvents PnumbBox As TextBox
    Friend WithEvents Pnumb As Label
    Friend WithEvents ProvinceBox As TextBox
    Friend WithEvents CityBox As TextBox
    Friend WithEvents Province As Label
    Friend WithEvents City As Label
    Friend WithEvents Country As Label
    Friend WithEvents PcodeBox As TextBox
    Friend WithEvents Pcode As Label
    Friend WithEvents StreetBox As TextBox
    Friend WithEvents Street As Label
    Friend WithEvents DOB As Label
    Friend WithEvents Mname As Label
    Friend WithEvents MnameBox As TextBox
    Friend WithEvents Lname As Label
    Friend WithEvents LnameBox As TextBox
    Friend WithEvents Fname As Label
    Friend WithEvents FnameBox As TextBox
    Friend WithEvents CreatePatient As Button
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents Birthday As DateTimePicker
    Friend WithEvents PtypeBox As ListBox
End Class
