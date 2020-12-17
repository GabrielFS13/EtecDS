Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login = Me.UsuariosTableAdapter1.PassUserString(TextBox1.Text, TextBox2.Text)

        If login Is Nothing Then
            MsgBox("Erro de entrada!", MsgBoxStyle.Critical, "Falha no login!")
        Else
            MsgBox("Login com sucesso!", MsgBoxStyle.Information, "Login com sucesso!")
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
