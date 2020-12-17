Imports System.Reflection

Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Dim nota1, nota2, nota3, nota4, total As Double
        nota1 = TXT_nota1.Text
        nota2 = TXT_NOTA2.Text
        nota3 = txt_NOTA3.Text
        nota4 = TXT_NOTA4.Text
        total = (nota1 + nota2 + nota3 + nota4) / 4
        If total < 5 Then
            MsgBox("Aluno Reprovado pois sua média é inferior a 5, média do aluno(a): " & total)
        ElseIf total >= 5 And total < 7 Then
            MsgBox("Aluno está em recuperação!, pois sua média não atendeu aos requisitos, média do aluno(a): " & total)
        ElseIf total >= 7 Then
            MsgBox("Aluno aprovado!, sua média atendeu aos requisitos, média do aluno(a): " & total)
        Else
            MsgBox("Algo deu errado...Tente novamente.")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TXT_nota1.Text = ""
        TXT_NOTA2.Text = ""
        txt_NOTA3.Text = ""
        TXT_NOTA4.Text = ""

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
