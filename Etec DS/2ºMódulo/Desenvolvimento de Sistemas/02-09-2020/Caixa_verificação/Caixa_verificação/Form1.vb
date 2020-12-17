Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblSexo.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim status As String = ""
        Dim permissoes As String = ""
        Dim sexo As String = ""

        status = TXT_nome.Text + " incluído."

        lblStatus.Text = status

        If (chkAlterar.Checked) Then
            permissoes = permissoes + chkAlterar.Text + " "
        End If
        If (chkConsultar.Checked) Then
            permissoes = permissoes + chkConsultar.Text + " "
        End If
        If (chkExcluir.Checked) Then
            permissoes = permissoes + chkExcluir.Text + " "
        End If
        If (chkIncluir.Checked) Then
            permissoes = permissoes + chkIncluir.Text + " "
        End If

        lblPermissoes.Text = "Permissões: " + permissoes

        If (rbMasculino.Checked) Then
            sexo = "Masculino"
        End If
        If (rbFemenino.Checked) Then
            sexo = "Femenino"
        End If
        lblSexo.Text = "Sexo: " + sexo

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
