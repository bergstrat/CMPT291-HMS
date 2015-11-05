<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formstaff
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
        Me.button1 = New System.Windows.Forms.Button()
        Me.department = New System.Windows.Forms.ComboBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.staff = New System.Windows.Forms.ComboBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.province = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.postalcode = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.street = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.suitenum = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.mName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(82, 262)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 34)
        Me.button1.TabIndex = 43
        Me.button1.Text = "Submit"
        Me.button1.UseVisualStyleBackColor = True
        '
        'department
        '
        Me.department.FormattingEnabled = True
        Me.department.Location = New System.Drawing.Point(378, 212)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(121, 21)
        Me.department.TabIndex = 42
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(301, 215)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(62, 13)
        Me.label11.TabIndex = 41
        Me.label11.Text = "Department"
        '
        'staff
        '
        Me.staff.FormattingEnabled = True
        Me.staff.Location = New System.Drawing.Point(140, 212)
        Me.staff.Name = "staff"
        Me.staff.Size = New System.Drawing.Size(121, 21)
        Me.staff.TabIndex = 40
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(78, 215)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(56, 13)
        Me.label10.TabIndex = 39
        Me.label10.Text = "Staff Type"
        '
        'province
        '
        Me.province.FormattingEnabled = True
        Me.province.Items.AddRange(New Object() {"AB", "BC", "MB", "NB", "NL", "NS", "NT", "NU", "ON", "PE", "QC", "SK", "YT"})
        Me.province.Location = New System.Drawing.Point(465, 152)
        Me.province.Name = "province"
        Me.province.Size = New System.Drawing.Size(121, 21)
        Me.province.TabIndex = 38
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(410, 156)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(49, 13)
        Me.label9.TabIndex = 37
        Me.label9.Text = "Province"
        '
        'city
        '
        Me.city.Location = New System.Drawing.Point(304, 153)
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(100, 20)
        Me.city.TabIndex = 36
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(248, 156)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(24, 13)
        Me.label8.TabIndex = 35
        Me.label8.Text = "City"
        '
        'postalcode
        '
        Me.postalcode.Location = New System.Drawing.Point(142, 153)
        Me.postalcode.Name = "postalcode"
        Me.postalcode.Size = New System.Drawing.Size(100, 20)
        Me.postalcode.TabIndex = 34
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(79, 156)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(64, 13)
        Me.label7.TabIndex = 33
        Me.label7.Text = "Postal Code"
        '
        'street
        '
        Me.street.Location = New System.Drawing.Point(304, 112)
        Me.street.Name = "street"
        Me.street.Size = New System.Drawing.Size(100, 20)
        Me.street.TabIndex = 32
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(248, 115)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(35, 13)
        Me.label6.TabIndex = 31
        Me.label6.Text = "Street"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(79, 115)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(41, 13)
        Me.label5.TabIndex = 30
        Me.label5.Text = "Suite #"
        '
        'suitenum
        '
        Me.suitenum.Location = New System.Drawing.Point(129, 112)
        Me.suitenum.Name = "suitenum"
        Me.suitenum.Size = New System.Drawing.Size(100, 20)
        Me.suitenum.TabIndex = 29
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(78, 89)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(66, 16)
        Me.label4.TabIndex = 28
        Me.label4.Text = "Address"
        '
        'lName
        '
        Me.lName.Location = New System.Drawing.Point(474, 57)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(100, 20)
        Me.lName.TabIndex = 27
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(410, 60)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(58, 13)
        Me.label3.TabIndex = 26
        Me.label3.Text = "Last Name"
        '
        'mName
        '
        Me.mName.Location = New System.Drawing.Point(304, 57)
        Me.mName.Name = "mName"
        Me.mName.Size = New System.Drawing.Size(100, 20)
        Me.mName.TabIndex = 25
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(248, 60)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 13)
        Me.label2.TabIndex = 24
        Me.label2.Text = "M. Name"
        '
        'fName
        '
        Me.fName.Location = New System.Drawing.Point(142, 57)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(100, 20)
        Me.fName.TabIndex = 23
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(79, 60)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 22
        Me.label1.Text = "First Name"
        '
        'Formstaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 352)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.department)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.staff)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.province)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.postalcode)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.street)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.suitenum)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.mName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.label1)
        Me.Name = "Formstaff"
        Me.Text = "Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents department As ComboBox
    Private WithEvents label11 As Label
    Private WithEvents staff As ComboBox
    Private WithEvents label10 As Label
    Private WithEvents province As ComboBox
    Private WithEvents label9 As Label
    Private WithEvents city As TextBox
    Private WithEvents label8 As Label
    Private WithEvents postalcode As TextBox
    Private WithEvents label7 As Label
    Private WithEvents street As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents suitenum As TextBox
    Private WithEvents label4 As Label
    Private WithEvents lName As TextBox
    Private WithEvents label3 As Label
    Private WithEvents mName As TextBox
    Private WithEvents label2 As Label
    Private WithEvents fName As TextBox
    Private WithEvents label1 As Label
End Class
