Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Dim username As String = text_user.Text
        Dim password As String = text_pass.Text
        If (username.CompareTo(AdminCredentials.GetUsername()) = 0 And
            password.CompareTo(AdminCredentials.GetPassword()) = 0) Then
            Dim form As Form2
            form = New Form2()
            form.Show()

            Me.Close()
        Else
            MsgBox("Invalid credentials", , "HMS - Error")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub text_user_TextChanged(sender As Object, e As EventArgs) Handles text_user.TextChanged

    End Sub
End Class
