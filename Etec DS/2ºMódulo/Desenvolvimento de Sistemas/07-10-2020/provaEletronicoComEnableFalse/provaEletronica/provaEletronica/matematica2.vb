Public Class matematica2
    Private Sub c10_CheckedChanged(sender As Object, e As EventArgs) Handles c10.CheckedChanged
        If c10.Checked = True Then
            resp10 = 1
            gp4.Enabled = False
        End If
    End Sub

    Private Sub c11_CheckedChanged(sender As Object, e As EventArgs) Handles c11.CheckedChanged
        If c11.Checked = True Then
            resp11 = 1
            gp5.Enabled = False
        End If
    End Sub

    Private Sub c12_CheckedChanged(sender As Object, e As EventArgs) Handles c12.CheckedChanged
        If c12.Checked = True Then
            resp12 = 1
            gp6.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalM = totalM + resp10 + resp11 + resp12
        TextBox1.Text = totalM
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gp4.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rb10.CheckedChanged
        If rb10.Checked = True Then
            gp4.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rb11.CheckedChanged
        If rb11.Checked = True Then
            gp4.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rb12.CheckedChanged
        If rb12.Checked = True Then
            gp4.Enabled = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gp5.Enter

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles rb13.CheckedChanged
        If rb13.Checked = True Then
            gp5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles rb14.CheckedChanged
        If rb14.Checked = True Then
            gp5.Enabled = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles rb15.CheckedChanged
        If rb15.Checked = True Then
            gp5.Enabled = False
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles gp6.Enter

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles rb16.CheckedChanged
        If rb16.Checked = True Then
            gp6.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles rb17.CheckedChanged
        If rb17.Checked = True Then
            gp6.Enabled = False
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles rb18.CheckedChanged
        If rb18.Checked = True Then
            gp6.Enabled = False
        End If
    End Sub
End Class