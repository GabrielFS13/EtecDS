Public Class gerais2
    Private Sub c16_CheckedChanged(sender As Object, e As EventArgs) Handles c16.CheckedChanged
        If c16.Checked = True Then
            resp16 = 1
        End If
    End Sub

    Private Sub c17_CheckedChanged(sender As Object, e As EventArgs) Handles c17.CheckedChanged
        If c17.Checked = True Then
            resp17 = 1
        End If
    End Sub

    Private Sub c18_CheckedChanged(sender As Object, e As EventArgs) Handles c18.CheckedChanged
        If c18.Checked = True Then
            resp18 = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalG = totalG + resp16 + resp17 + resp18
        TextBox1.Text = totalG
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class