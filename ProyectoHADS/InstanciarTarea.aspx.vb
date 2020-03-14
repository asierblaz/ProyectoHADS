Imports AccesoDatos.accesodatosSQL
Imports System.Data.SqlClient

Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
        TextBoxUsuario.Text = Session("Email")
        TextBoxTarea.Text = Session("CodTarea")
        TextBoxHorasEst.Text = Session("HEstimadas")
        cargarGridView()
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Session("Rol") = ""
        Session("Email") = ""
        Session("Nombre") = ""
        Response.Redirect("Inicio.aspx")
    End Sub

    Protected Sub BotonCrearTarea_Click(sender As Object, e As EventArgs) Handles BotonCrearTarea.Click
        Dim HEstimadas As Integer = Integer.Parse(Session("HEstimadas"))
        Dim HReales As Integer = Integer.Parse(TextBoxHorasReales.Text)
        LabelAviso.Text = insertarTareasEstudiante(Session("Email"), Session("CodTarea"), HEstimadas, HReales)
        cargarGridView()
    End Sub

    Private Sub InstanciarTarea_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Private Sub cargarGridView()
        Dim conTareas As SqlConnection
        conTareas = New SqlConnection("Data Source=hads.database.windows.net;Initial Catalog=Amigos;Persist Security Info=True;User ID=vadillo@ehu.es@hads;Password=curso19-20")
        Dim dapTareas As New SqlDataAdapter()
        Dim dstTareas As New DataSet
        Dim tblTareas As New DataTable


        dapTareas = New SqlDataAdapter("Select * FROM EstudiantesTareas where email='" & Session("Email") & "'", conTareas)
        Dim bldTareas As New SqlCommandBuilder(dapTareas)
        dapTareas.Fill(dstTareas, "Tareas")
        tblTareas = dstTareas.Tables("Tareas")
        TablaTareas.DataSource = tblTareas
        TablaTareas.DataBind()
    End Sub
End Class