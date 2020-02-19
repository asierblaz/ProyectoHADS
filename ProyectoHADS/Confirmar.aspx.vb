Imports AccesoDatos.accesodatosSQL

Public Class Confirmar
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()

        Dim email As String = Request.QueryString("email")
        Dim cod As String = Request.QueryString("cod")
        Dim codint As Integer = Integer.Parse(cod)
        Dim mensaje As String
        mensaje = confirmarUsuario(email, codint)
        Label1.Text = mensaje
    End Sub


    Private Sub Confirmar_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
End Class