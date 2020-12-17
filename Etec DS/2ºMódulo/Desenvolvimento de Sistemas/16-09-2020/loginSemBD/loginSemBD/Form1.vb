Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtLogin.Text = "Paulo" And txtPassword.Text = "1234" Then
            Form2.Show()
        ElseIf txtLogin.Text <> "Paulo" Or txtPassword.Text <> "1234" Then
            MsgBox("Usuário ou senha inválido.")
        End If
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Close()
    End Sub
End Class
