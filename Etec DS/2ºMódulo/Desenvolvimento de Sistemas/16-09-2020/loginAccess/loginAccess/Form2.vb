Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, res As Double
        n1 = txtV1.Text
        n2 = txtV2.Text
        res = n1 + n2
        lblRes.Text = "A soma dos valores é de: " & res

    End Sub
End Class