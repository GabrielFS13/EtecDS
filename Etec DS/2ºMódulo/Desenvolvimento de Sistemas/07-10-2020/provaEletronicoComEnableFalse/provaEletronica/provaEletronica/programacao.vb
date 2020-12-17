Public Class programacao
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        programacao2.Show()
        Me.Hide()
    End Sub

    Private Sub resp1_CheckedChanged(sender As Object, e As EventArgs) Handles c1.CheckedChanged
        If c1.Checked = True Then
            resp1 = 1
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub c2_CheckedChanged(sender As Object, e As EventArgs) Handles c2.CheckedChanged
        If c2.Checked = True Then
            resp2 = 1
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub c3_CheckedChanged(sender As Object, e As EventArgs) Handles c3.CheckedChanged
        If c3.Checked = True Then
            resp3 = 1
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        totalP = resp1 + resp2 + resp3
        TextBox1.Text = totalP
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox1.Enabled = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        GroupBox1.Enabled = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
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

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
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

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        GroupBox3.Enabled = False
    End Sub
End Class