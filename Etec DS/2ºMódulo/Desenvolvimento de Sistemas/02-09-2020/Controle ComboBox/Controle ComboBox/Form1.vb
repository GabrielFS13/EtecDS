Public Class Form1
    Private Sub lbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCargo.SelectedIndexChanged
        lblCargo.Text = "Cargo: " + lbCargo.SelectedItem
    End Sub

    Private Sub cbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargo.SelectedIndexChanged
        lblCargo1.Text = "Cargo: " + cbCargo.SelectedItem
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cargo As String
        cargo = InputBox("Informe o cargo", "Incluir")
        lbCargo.Items.Add(cargo)

        If Not lbCargo.Items.Contains(cargo) And cargo <> "" Then
            lbCargo.Items.Add(cargo)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbCargo.Items.Remove(lbCargo.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lbCargo.Items.Clear()
    End Sub
End Class
