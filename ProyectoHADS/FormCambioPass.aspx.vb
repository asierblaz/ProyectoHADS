Imports AccesoDatos.accesodatosSQL

Public Class FormCambioPass
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()




    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = Request.QueryString("email")
        Dim cod As String = Request.QueryString("cod")
        Dim codint As Integer = Integer.Parse(cod)

        Dim pass As String = passwordtext.Text
        If (pass = pass2text.Text) Then
            Label1.Text = modificarContrasena(email, codint, pass)
        Else
            errorpass.Text = "Las constraseñas no coinciden"
        End If


    End Sub

    Private Sub Button1_Unload(sender As Object, e As EventArgs) Handles Button1.Unload
        cerrarconexion()
    End Sub
End Class