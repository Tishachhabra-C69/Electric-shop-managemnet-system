

Imports MySql.Data.MySqlClient

Public Class DBConnection
    Public Shared con As MySqlConnection
    Public Shared Function getConnection() As MySqlConnection
        con = New MySqlConnection
        con.ConnectionString = "server = localhost;user = root; password = root; database = electric_shop_management_system"
        Try
            ' MessageBox.Show("Reached here.")
            con.Open()
            ' MessageBox.Show("connection is created.")
        Catch ex As Exception
            ' MessageBox.Show("can't create connection ..")
        End Try
        Return con
    End Function
End Class
