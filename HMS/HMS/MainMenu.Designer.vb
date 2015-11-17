<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add New Patient")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update Patient Information")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Find Patient ID")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Patient History")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Patient Tasks", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add New Staff Member")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update Staff Information")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Doctor Patient History")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Staff Administration", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Create New Medical Case")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update Medical Case")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Find Case ID")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add New Medication")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Medical Tasks", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(467, 56)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = " Hospital Management System"
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(0, 54)
        Me.TreeView2.Name = "TreeView2"
        TreeNode1.Name = "NewPatient"
        TreeNode1.Text = "Add New Patient"
        TreeNode2.Name = "UpdatePatient"
        TreeNode2.Text = "Update Patient Information"
        TreeNode3.Name = "GetPID"
        TreeNode3.Text = "Find Patient ID"
        TreeNode4.Name = "GetHistory"
        TreeNode4.Text = "View Patient History"
        TreeNode5.Name = "Ptasks"
        TreeNode5.Text = "Patient Tasks"
        TreeNode6.Name = "AddStaff"
        TreeNode6.Text = "Add New Staff Member"
        TreeNode7.Name = "UpdateStaff"
        TreeNode7.Text = "Update Staff Information"
        TreeNode8.Name = "DoctorHistory"
        TreeNode8.Text = "View Doctor Patient History"
        TreeNode9.Name = "StaffAdmin"
        TreeNode9.Text = "Staff Administration"
        TreeNode10.Name = "CreateMedCase"
        TreeNode10.Text = "Create New Medical Case"
        TreeNode11.Name = "UpdateCase"
        TreeNode11.Text = "Update Medical Case"
        TreeNode12.Name = "FindCaseID"
        TreeNode12.Text = "Find Case ID"
        TreeNode13.Name = "AddMeds"
        TreeNode13.Text = "Add New Medication"
        TreeNode14.Name = "MedicalTasks"
        TreeNode14.Text = "Medical Tasks"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode14})
        Me.TreeView2.Size = New System.Drawing.Size(182, 475)
        Me.TreeView2.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 530)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TreeView2 As TreeView
End Class
