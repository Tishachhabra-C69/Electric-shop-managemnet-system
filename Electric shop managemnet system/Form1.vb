Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String



        username = TextBox1.Text
        password = TextBox2.Text

        Dim res As Boolean = LoginController.loginController(username, password)
        If (res = True) Then
            MessageBox.Show("logged in sucessfully")
            Me.Visible = False
            Form2.Visible = True

        Else
            MessageBox.Show("cannot login due to incorrect id or password.")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Username"
        Label2.Text = "Password"
        Label3.Text = "Admin LogIn Page"

        Button1.Text = "Log In"


    End Sub
End Class
