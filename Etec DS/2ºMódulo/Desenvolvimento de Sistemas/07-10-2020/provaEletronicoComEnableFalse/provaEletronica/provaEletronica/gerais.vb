Public Class gerais
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gerais2.Show()
        Me.Hide()
    End Sub

    Private Sub c13_CheckedChanged(sender As Object, e As EventArgs) Handles c13.CheckedChanged
        If c13.Checked = True Then
            resp13 = 1
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub c14_CheckedChanged(sender As Object, e As EventArgs) Handles c14.CheckedChanged
        If c14.Checked = True Then
            resp14 = 1
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub c15_CheckedChanged(sender As Object, e As EventArgs) Handles c15.CheckedChanged
        If c15.Checked = True Then
            resp15 = 1
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalG = resp13 + resp14 + resp15
        TextBox1.Text = totalG
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox1.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox1.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        GroupBox1.Enabled = False
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        GroupBox2.Enabled = False
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        GroupBox2.Enabled = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox2.Enabled = False
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        GroupBox3.Enabled = False
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        GroupBox3.Enabled = False
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        GroupBox3.Enabled = False
    End Sub
End Class