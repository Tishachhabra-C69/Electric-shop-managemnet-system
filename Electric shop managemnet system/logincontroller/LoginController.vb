Public Class LoginController
    Public Shared Function loginController(user As String, pass As String) As Boolean

        'Dim dao As LoginDao()
        Dim res As Boolean = LoginDao.logindao(user, pass)

        Return res
    End Function
End Class
