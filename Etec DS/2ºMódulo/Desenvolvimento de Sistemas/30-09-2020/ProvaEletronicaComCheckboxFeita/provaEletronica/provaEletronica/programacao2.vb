Public Class programacao2
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles c4.CheckedChanged
        If c4.Checked = True Then
            resp4 = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalP = totalP + resp4 + resp5 + resp6
        TextBox1.Text = totalP
    End Sub

    Private Sub c5_CheckedChanged(sender As Object, e As EventArgs) Handles c5.CheckedChanged
        If c5.Checked = True Then
            resp5 = 1
        End If
    End Sub

    Private Sub c6_CheckedChanged(sender As Object, e As EventArgs) Handles c6.CheckedChanged
        If c6.Checked = True Then
            resp6 = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class