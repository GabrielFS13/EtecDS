Public Class Form1
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim Login = Me.LoginTableAdapter1.PassUserString(txtUser.Text, txtPass.Text)
        If Login Is Nothing Then
            MsgBox("Erro de entrada!", MsgBoxStyle.Critical, "Falha no Login!")
        Else
            MsgBox("Login realizado com Sucesso!", MsgBoxStyle.Information, "Login realizado com sucesso!")
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
