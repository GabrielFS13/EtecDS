Public Class matematica

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        matematica2.Show()
        Me.Hide()
    End Sub

    Private Sub c7_CheckedChanged(sender As Object, e As EventArgs) Handles c7.CheckedChanged
        If c7.Checked = True Then
            resp7 = 1
            gp1.Enabled = False
        End If
    End Sub

    Private Sub c8_CheckedChanged(sender As Object, e As EventArgs) Handles c8.CheckedChanged
        If c8.Checked = True Then
            resp8 = 1
            gp2.Enabled = False
        End If
    End Sub

    Private Sub c9_CheckedChanged(sender As Object, e As EventArgs) Handles c9.CheckedChanged
        If c9.Checked = True Then
            resp9 = 1
            gp3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalM = resp7 + resp8 + resp9
        TextBox1.Text = totalM
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gp1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then
            gp1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked = True Then
            gp1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked = True Then
            gp1.Enabled = False
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gp2.Enter

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked = True Then
            gp2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked = True Then
            gp2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged
        If rb6.Checked = True Then
            gp2.Enabled = False
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles gp3.Enter

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles rb7.CheckedChanged
        If rb7.Checked = True Then
            gp3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles rb8.CheckedChanged
        If rb8.Checked = True Then
            gp3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles rb9.CheckedChanged
        If rb9.Checked = True Then
            gp3.Enabled = False
        End If
    End Sub
End Class