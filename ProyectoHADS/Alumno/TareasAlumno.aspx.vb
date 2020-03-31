Imports System.Data.SqlClient
Imports AccesoDatos.accesodatosSQL
Public Class TareasAlumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarListaAsignaturas()
        If Page.IsPostBack Then

        Else
            cargarGridView()
        End If
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

    Protected Sub ListAsignaturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListAsignaturas.SelectedIndexChanged
        cargarGridView()
    End Sub

    Private Sub cargarGridView()
        Dim conTareas As SqlConnection
        conTareas = New SqlConnection("Data Source=hads.database.windows.net;Initial Catalog=Amigos;Persist Security Info=True;User ID=vadillo@ehu.es@hads;Password=curso19-20")
        Dim dapTareas As New SqlDataAdapter()
        Dim dstTareas As New DataSet
        Dim tblTareas As New DataTable

        Dim asigSeleccionada As String
        asigSeleccionada = ListAsignaturas.SelectedValue

        dapTareas = New SqlDataAdapter("Select Codigo, Descripcion, HEstimadas, TipoTarea FROM TareasGenericas where Explotacion=1 and CodAsig='" & asigSeleccionada & "'", conTareas)
        Dim bldTareas As New SqlCommandBuilder(dapTareas)
        dapTareas.Fill(dstTareas, "Tareas")
        tblTareas = dstTareas.Tables("Tareas")
        TablaTareas.DataSource = tblTareas
        TablaTareas.DataBind()
    End Sub

    Private Sub cargarListaAsignaturas()
        Dim conString As SqlConnection
        Dim dtpAsig As SqlDataAdapter
        Dim dstAsig As DataSet

        If Page.IsPostBack Then

        Else
            conString = New SqlConnection("Data Source=hads.database.windows.net;Initial Catalog=Amigos;Persist Security Info=True;User ID=vadillo@ehu.es@hads;Password=curso19-20")
            dtpAsig = New SqlDataAdapter("SELECT DISTINCT GruposClase.codigoasig FROM GruposClase CROSS JOIN EstudiantesGrupo WHERE EstudiantesGrupo.email ='" & Session("Email") & "'", conString)
            dstAsig = New DataSet()
            dtpAsig.Fill(dstAsig, "ListaAsignaturas")
            ListAsignaturas.DataSource = dstAsig.Tables("ListaAsignaturas")
            ListAsignaturas.DataValueField = "codigoasig"
            ListAsignaturas.DataBind()
        End If
    End Sub
    Protected Sub TablaTareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TablaTareas.SelectedIndexChanged
        Session("CodTarea") = TablaTareas.SelectedRow.Cells(1).Text
        Session("HEstimadas") = TablaTareas.SelectedRow.Cells(3).Text 'la columna de esa fila 
        Response.Redirect("InstanciarTarea.aspx")
    End Sub
End Class