Imports MySql.Data.MySqlClient

Public Class AddProductsdao

    Public Shared cmd As MySqlCommand
    Public Shared dr As MySqlDataReader

    Public Shared Function addProductsDao()
        Dim con As MySqlConnection = DBConnection.getConnection()
        Dim query As String = "insert into "
        cmd = New MySqlCommand(query, con)
        cmd.ExecuteNonQuery()
    End Function
End Class
