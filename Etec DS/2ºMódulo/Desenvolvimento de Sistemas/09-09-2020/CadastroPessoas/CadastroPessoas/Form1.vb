Public Class Form1
    Private Sub CadastroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CadastroBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CadastroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CadastroBDDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadastroBDDataSet.Cadastro'. Você pode movê-la ou removê-la conforme necessário.
        Me.CadastroTableAdapter.Fill(Me.CadastroBDDataSet.Cadastro)

    End Sub
End Class
