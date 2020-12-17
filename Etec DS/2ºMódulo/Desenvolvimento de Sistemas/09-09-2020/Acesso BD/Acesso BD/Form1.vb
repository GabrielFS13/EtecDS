Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadastroBDDataSet.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.CadastroTableAdapter.Fill(Me.CadastroBDDataSet.Cadastro)

    End Sub
End Class
