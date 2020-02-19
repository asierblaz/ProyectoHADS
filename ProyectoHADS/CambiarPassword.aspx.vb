Imports AccesoDatos.accesodatosSQL
Public Class CambiarPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EmailContrasena As New EmailContrasena.EmailContrasena
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(10000, 99999)
        Dim cod As String
        cod = valorAleatorio.ToString()
        Dim email As String = emailRestablecer.Text

        If (emailExiste(email) = True) Then
            LabelAviso.Text = insertcodpass(email, valorAleatorio)
            EmailContrasena.emailContrasena(email, cod)
        Else
            LabelAviso.Text = "El email introducido no existe"

        End If

    End Sub

    Private Sub CambiarPassword_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
End Class