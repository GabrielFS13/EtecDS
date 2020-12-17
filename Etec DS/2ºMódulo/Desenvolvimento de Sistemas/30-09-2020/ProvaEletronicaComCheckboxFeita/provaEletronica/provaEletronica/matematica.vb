Public Class matematica

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        matematica2.Show()
        Me.Hide()
    End Sub

    Private Sub c7_CheckedChanged(sender As Object, e As EventArgs) Handles c7.CheckedChanged
        If c7.Checked = True Then
            resp7 = 1
        End If
    End Sub

    Private Sub c8_CheckedChanged(sender As Object, e As EventArgs) Handles c8.CheckedChanged
        If c8.Checked = True Then
            resp8 = 1
        End If
    End Sub

    Private Sub c9_CheckedChanged(sender As Object, e As EventArgs) Handles c9.CheckedChanged
        If c9.Checked = True Then
            resp9 = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalM = resp7 + resp8 + resp9
        TextBox1.Text = totalM
    End Sub
End Class