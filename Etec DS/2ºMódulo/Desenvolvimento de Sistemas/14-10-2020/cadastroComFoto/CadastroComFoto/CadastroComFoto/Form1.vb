Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        PGravaClientes()
    End Sub

    Private Sub btnConsult_Click(sender As Object, e As EventArgs) Handles btnConsult.Click
        fmrListaClientes1.ShowDialog()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        PCarregarImagem()
    End Sub

    Dim strImgName As String
    Private Sub PGravaClientes()
        Using con As OleDbConnection() = getcommetion()
            Try
                con.Open()
                If strImgName <> "" Then
                    Dim fs As FileStream
                    fs = New FileStream(strImgName, FileMode.Open, FileAccess.Read)
                    Dim picByte As Byte() = New Byte(fs.Length - 1) {}

                    fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
                    Dim sql As String = "INSERT INTO clientes(nome, [imagem]) values (?,?)"
                    Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                    cmd.Parameters.Add(New OleDbParameter("@nome", txtNome.Text))
                    cmd.Parameters.Add(New OleDbParameter("@imagem", OleDbType.Binary, picByte.Length)).Value = picByte
                    cmd.ExecuteNonQuery()
                    MsgBox("Imagem Gravada com sucesso.", MsgBoxStyle.Information)
                    txtNome.Text = ""
                    imgRecuperar.Image = Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub PCarregaImagem()
        Dim openfd As New OpenFileDialog

        Try
            openfd.Filter = "Imagens (*.jpg;* .bmp;*.gif|*.jpg;*.bmp;*gif"
            If openfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                strImgName = openfd.FileName

                imgRecuperar.Image = New System.Drawing.Bitmap(srtImgName)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
