Imports System.Data.OleDb
Imports System.IO

Public Class frmListaClientes1
    Private Sub frmListaClientes1()
        Using con As OleDbConnection = getcommetion()
            Try
                con.Open()
                Dim sql As String = "SELECT codigo, nome FROM clientes"
                Dim cnd As OleDbCommand = New OleDbCommand(sql, con)
                Dim da As OleDbDataAdapter = New OleDbDataAdapter(cnd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvClientes.DataSource = dt
            Catch ex As Exception
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub frmListaClientes1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PcarregaListaClientes1()
    End Sub

    Private Sub PlistaClientes()
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = getcommetion()
            Try
                con.Open()
                Dim sql As String = "SELECT nome.imagem FROM clientes WHERE=" & dgvClientes.CurrentRow().Cells(0).Value
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    txtNome.Text = dr.Item("nome")

                    Dim fsimagem As New FileStream("Imagem.jpj", FileMode.Create)
                    Dim blob As Byte() = DirectCast(dr.Item("image"), Byte())
                    fsimagem.Close()
                    fsimagem = Nothing
                    imgRecuperar.Image = Image.FormFile("image.jpg")
                    imgRecuperar.Refresh()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub PlistaClientes()
        Dim dr As OleDbDataReader = Nothing
        Using con As OleDbConnection = getcommetion()
            Try
                con.Open()
                Dim sql As String = "SELECT nome.imagem FROM clientes WHERE=" & dgvClientes.CurrentRow().Cells(0).Value
                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                dr = cmd.ExecuteReader(CommandBehavior.SingleRow)
                If dr.HasRows Then
                    dr.Read()
                    txtNome.Text = dr.Item("nome")
                    If imgRecuperar.Image IsNot Nothing Then
                        imgRecuperar.Image.Dispose()
                    End If
                    Dim fsimagem As New FileStream("Imagem.jpj", FileMode.Create)
                    Dim blob As Byte() = DirectCast(dr.Item("image"), Byte())
                    fsimagem.Close()
                    fsimagem = Nothing

                    imgRecuperar.Image = Image.FormFile("image.jpg")
                    imgRecuperar.Refresh()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

End Class