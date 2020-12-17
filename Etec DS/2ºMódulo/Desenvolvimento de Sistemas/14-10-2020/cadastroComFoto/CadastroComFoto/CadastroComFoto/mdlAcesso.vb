Imports System.Data.OleDb

Module mdlAcesso
    Public Function getcommetion()
        Dim sql As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bin\Debug\bdClientes.mdb"
        Return New OleDbConnection(sql)
    End Function
End Module
