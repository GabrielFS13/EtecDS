Public Class matematica2
    Private Sub c10_CheckedChanged(sender As Object, e As EventArgs) Handles c10.CheckedChanged
        If c10.Checked = True Then
            resp10 = 1
        End If
    End Sub

    Private Sub c11_CheckedChanged(sender As Object, e As EventArgs) Handles c11.CheckedChanged
        If c11.Checked = True Then
            resp11 = 1
        End If
    End Sub

    Private Sub c12_CheckedChanged(sender As Object, e As EventArgs) Handles c12.CheckedChanged
        If c12.Checked = True Then
            resp12 = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalM = totalM + resp10 + resp11 + resp12
        TextBox1.Text = totalM
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class