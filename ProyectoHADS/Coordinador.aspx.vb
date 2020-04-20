Public Class Coordinador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Response.Redirect("../CerrarSesion.aspx")
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropAsignaturas.SelectedIndexChanged
        Dim fun As New HorasMedia
        horasMediaLabel.Text = fun.calcularHoras(dropAsignaturas.SelectedValue)
    End Sub
End Class