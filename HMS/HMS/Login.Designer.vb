<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btn_reception = New System.Windows.Forms.Button()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.text_user = New System.Windows.Forms.TextBox()
        Me.text_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_reception
        '
        Me.btn_reception.Location = New System.Drawing.Point(12, 135)
        Me.btn_reception.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_reception.Name = "btn_reception"
        Me.btn_reception.Size = New System.Drawing.Size(82, 19)
        Me.btn_reception.TabIndex = 1
        Me.btn_reception.Text = "Receptionist"
        Me.btn_reception.UseVisualStyleBackColor = True
        '
        'btn_admin
        '
        Me.btn_admin.Location = New System.Drawing.Point(134, 135)
        Me.btn_admin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(80, 19)
        Me.btn_admin.TabIndex = 2
        Me.btn_admin.Text = "Admin Login"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'text_user
        '
        Me.text_user.Location = New System.Drawing.Point(8, 57)
        Me.text_user.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.text_user.Name = "text_user"
        Me.text_user.Size = New System.Drawing.Size(205, 20)
        Me.text_user.TabIndex = 3
        '
        'text_pass
        '
        Me.text_pass.Location = New System.Drawing.Point(8, 102)
        Me.text_pass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.text_pass.Name = "text_pass"
        Me.text_pass.Size = New System.Drawing.Size(205, 20)
        Me.text_pass.TabIndex = 4
        Me.text_pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hospital Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 168)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text_pass)
        Me.Controls.Add(Me.text_user)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.btn_reception)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(240, 206)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(240, 206)
        Me.Name = "Login"
        Me.Text = "HMS Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_reception As Button
    Friend WithEvents btn_admin As Button
    Friend WithEvents text_user As TextBox
    Friend WithEvents text_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
