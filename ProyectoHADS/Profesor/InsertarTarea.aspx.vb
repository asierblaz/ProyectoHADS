Imports AccesoDatos.accesodatosSQL
Public Class InsertarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Session("Rol") = ""
        Session("Email") = ""
        Session("Nombre") = ""
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("../Inicio.aspx")

    End Sub

    Protected Sub BotonAñadir_Click(sender As Object, e As EventArgs) Handles BotonAñadir.Click

        Dim hestimadas As Integer = Integer.Parse(TextHorasEstimadas.Text)
        LabelAviso.Text = insertarTareasProfesor(TextCodigo.Text, TextDescripcion.Text, Asignaturas.SelectedValue, hestimadas, TipoTareas.SelectedValue)
    End Sub

    Private Sub InsertarTarea_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
End Class