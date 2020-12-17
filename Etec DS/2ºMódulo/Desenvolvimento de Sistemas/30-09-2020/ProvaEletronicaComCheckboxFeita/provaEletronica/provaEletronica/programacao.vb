Public Class programacao
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        programacao2.Show()
        Me.Hide()
    End Sub

    Private Sub resp1_CheckedChanged(sender As Object, e As EventArgs) Handles c1.CheckedChanged
        If c1.Checked = True Then
            resp1 = 1
        End If
    End Sub

    Private Sub c2_CheckedChanged(sender As Object, e As EventArgs) Handles c2.CheckedChanged
        If c2.Checked = True Then
            resp2 = 1
        End If
    End Sub

    Private Sub c3_CheckedChanged(sender As Object, e As EventArgs) Handles c3.CheckedChanged
        If c3.Checked = True Then
            resp3 = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalP = resp1 + resp2 + resp3
        TextBox1.Text = totalP
    End Sub
End Class