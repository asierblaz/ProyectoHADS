Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
        MsgBox(Session("HEstimadas") + " " + Session("CodTarea"))
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Session("Rol") = ""
        Session("Email") = ""
        Session("Nombre") = ""
        Response.Redirect("Inicio.aspx")
    End Sub
End Class