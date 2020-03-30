Imports System.Data.SqlClient
Imports System.Xml
Public Class ExportarTareas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then

        Else
            cargarListaAsignaturas()
            cargarGridView()
            Session("dataset") = New DataSet
        End If
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
    End Sub

    Protected Sub BotonImportarTareas_Click(sender As Object, e As EventArgs) Handles BotonExportarTareas.Click
        Try
            Dim settings As XmlWriterSettings = New XmlWriterSettings()
            settings.Indent = True
            Using writer As XmlWriter = XmlWriter.Create(Server.MapPath("App_Data/" & asignaturasProfe.SelectedValue & ".xml"), settings)
                writer.WriteStartDocument()
                writer.WriteStartElement("tareas")
                Dim datosTareas = Session("dataset").Tables("Tareas")
                Dim row As DataRow
                For Each row In datosTareas.rows
                    writer.WriteStartElement("tarea")
                    writer.WriteElementString("codigo", row("Codigo"))
                    writer.WriteElementString("descripcion", row("Descripcion"))
                    writer.WriteElementString("hestimadas", row("HEstimadas"))
                    writer.WriteElementString("explotacion", row("Explotacion"))
                    writer.WriteElementString("tipotarea", row("TipoTarea"))
                    writer.WriteEndElement()
                Next
                writer.WriteEndDocument()
                mensaje.Text = "Las tareas se han exportado correctamente."
                mensaje.ForeColor = Drawing.Color.Green
            End Using
        Catch ex As Exception
            mensaje.Text = "No se han podido exportar las tareas."
            mensaje.ForeColor = Drawing.Color.Red
        End Try
    End Sub

    Protected Sub AsignaturasProfesor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles asignaturasProfe.SelectedIndexChanged
        cargarGridView()
    End Sub

    Private Sub cargarListaAsignaturas()
        Dim conexion As SqlConnection
        Dim dtpAsig As SqlDataAdapter
        Dim dstAsig As DataSet

        conexion = New SqlConnection("Data Source=hads.database.windows.net;Initial Catalog=Amigos;Persist Security Info=True;User ID=vadillo@ehu.es@hads;Password=curso19-20")
        dtpAsig = New SqlDataAdapter("SELECT DISTINCT GruposClase.codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE ProfesoresGrupo.email='" & Session("Email") & "'", conexion)
        dstAsig = New DataSet
        dtpAsig.Fill(dstAsig, "Asignaturas")
        asignaturasProfe.DataSource = dstAsig.Tables("Asignaturas")
        asignaturasProfe.DataValueField = "codigoasig"
        asignaturasProfe.DataBind()
    End Sub

    Private Sub cargarGridView()
        Dim conTareas As SqlConnection
        conTareas = New SqlConnection("Data Source=hads.database.windows.net;Initial Catalog=Amigos;Persist Security Info=True;User ID=vadillo@ehu.es@hads;Password=curso19-20")
        Dim dapTareas As New SqlDataAdapter()
        Dim dstTareas As New DataSet
        Dim tblTareas As New DataTable

        Dim asigSeleccionada As String
        asigSeleccionada = asignaturasProfe.SelectedValue

        dapTareas = New SqlDataAdapter("Select Codigo, Descripcion, HEstimadas, Explotacion, TipoTarea FROM TareasGenericas where Explotacion=1 and CodAsig='" & asigSeleccionada & "'", conTareas)
        Dim bldTareas As New SqlCommandBuilder(dapTareas)
        dapTareas.Fill(dstTareas, "Tareas")
        tblTareas = dstTareas.Tables("Tareas")
        TablaTareas.DataSource = tblTareas
        TablaTareas.DataBind()
        Session("dataset") = dstTareas
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Session("Rol") = ""
        Session("Email") = ""
        Session("Nombre") = ""
        Response.Redirect("Inicio.aspx")
    End Sub
End Class