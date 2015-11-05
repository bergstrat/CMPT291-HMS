Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Dim username As String = text_user.Text
        Dim password As String = text_pass.Text
        If (username.CompareTo(AdminCredentials.getUsername()) = 0 And
            password.CompareTo(AdminCredentials.getPassword()) = 0) Then
            Dim form As AdminPanel
            form = New AdminPanel()
            form.Show()
            Me.Close()
        Else
            MsgBox("Invalid credentials", , "HMS - Error")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
