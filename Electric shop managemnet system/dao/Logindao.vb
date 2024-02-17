
Imports MySql.Data.MySqlClient

Public Class LoginDao
    Public Shared con As MySqlConnection
    Public Shared cmd As MySqlCommand
    Public Shared dr As MySqlDataReader

    Public Shared Function logindao(username As String, password As String) As Boolean
        Dim db As New DBConnection
        con = DBConnection.getConnection()
        cmd = New MySqlCommand()
        cmd = New MySqlCommand("select * from admin_creds where admin_id = '" + username + "'", con)
        dr = cmd.ExecuteReader

        While dr.Read
            If username.Equals(dr(0)) And password.Equals(dr(1)) Then
                Return True
            End If
        End While
        Return False
    End Function
End Class
