Public Class gerais2
    Private Sub c16_CheckedChanged(sender As Object, e As EventArgs) Handles c16.CheckedChanged
        If c16.Checked = True Then
            resp16 = 1
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub c17_CheckedChanged(sender As Object, e As EventArgs) Handles c17.CheckedChanged
        If c17.Checked = True Then
            resp17 = 1
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub c18_CheckedChanged(sender As Object, e As EventArgs) Handles c18.CheckedChanged
        If c18.Checked = True Then
            resp18 = 1
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalG = totalG + resp16 + resp17 + resp18
        TextBox1.Text = totalG
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
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

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        GroupBox2.Enabled = False
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox2.Enabled = False
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        GroupBox3.Enabled = False
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        GroupBox3.Enabled = False
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        GroupBox3.Enabled = False
    End Sub
End Class