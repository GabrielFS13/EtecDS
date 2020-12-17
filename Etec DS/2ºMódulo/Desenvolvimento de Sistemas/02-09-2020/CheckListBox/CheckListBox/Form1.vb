Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblUser.Text = "Usuário: " + TXT_NOME.Text
        lblstatus.Text = "Permissões: "
        For i = 0 To cblpermissoes.CheckedItems.Count - 1
            lblstatus.Text = lblstatus.Text + cblpermissoes.CheckedItems(i) + " "
        Next
    End Sub
End Class
