Public Class Alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
        cargarAjax()
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Response.Redirect("../CerrarSesion.aspx")
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Protected Sub cargarAjax()
        Dim alumnosConectados As New Integer
        Dim profesoresConectados As New Integer

        alumnosC.Items.Clear()
        profesoresC.Items.Clear()

        If Application("alumOnline") = 0 Then
            alumnosConectados = 0
        Else
            alumnosConectados = Application("alumOnline")
            alumnosC.DataSource = Application("alumsOnline")
            alumnosC.DataBind()
        End If

        If Application("profOnline") = 0 Then
            profesoresConectados = 0
        Else
            profesoresConectados = Application("profOnline")
            profesoresC.DataSource = Application("profesOnline")
            profesoresC.DataBind()
        End If
        textoConectados.Text = "Hay un total de " + alumnosConectados.ToString + " alumnos y " + profesoresConectados.ToString + " profesores online."
    End Sub

    Protected Sub alumnosC_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class