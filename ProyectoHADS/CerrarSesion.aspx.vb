Public Class CerrarSesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If (Session("Rol") = "Alumno") Then
            Application("alumOnline") -= 1
            Application("alumsOnline").Remove(Session("Email"))
        ElseIf (Session("Rol") = "Profesor") Then
            Application("profOnline") -= 1
            Application("profesOnline").Remove(Session("Email"))
        End If
        Session("Rol") = ""
        Session("Email") = ""
        Session("Nombre") = ""
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("Inicio.aspx")
    End Sub
End Class