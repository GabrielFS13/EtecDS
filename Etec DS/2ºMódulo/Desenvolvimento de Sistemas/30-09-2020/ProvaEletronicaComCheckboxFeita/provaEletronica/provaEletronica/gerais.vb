Public Class gerais
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gerais2.Show()
        Me.Hide()
    End Sub

    Private Sub c13_CheckedChanged(sender As Object, e As EventArgs) Handles c13.CheckedChanged
        If c13.Checked = True Then
            resp13 = 1
        End If
    End Sub

    Private Sub c14_CheckedChanged(sender As Object, e As EventArgs) Handles c14.CheckedChanged
        If c14.Checked = True Then
            resp14 = 1
        End If
    End Sub

    Private Sub c15_CheckedChanged(sender As Object, e As EventArgs) Handles c15.CheckedChanged
        If c15.Checked = True Then
            resp15 = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalG = resp13 + resp14 + resp15
        TextBox1.Text = totalG
    End Sub
End Class