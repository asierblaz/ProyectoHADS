Public Class TareasProfesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Response.Redirect("../CerrarSesion.aspx")
    End Sub

    Protected Sub BotonInsertarTarea_Click(sender As Object, e As EventArgs) Handles BotonInsertarTarea.Click
        Response.Redirect("InsertarTarea.aspx")
    End Sub

    Protected Sub AsignaturasProfesor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AsignaturasProfesor.SelectedIndexChanged
        labelCargando.Text = "Cargando tareas..."
        Threading.Thread.Sleep(3000)
        labelCargando.Text = ""
    End Sub
End Class