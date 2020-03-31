Imports System.Data.SqlClient
Imports AccesoDatos.accesodatosSQL
Imports System.Xml

Public Class ImportarTareasXMLDocument
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then

        Else
            cargarListaAsignaturas()
            mostrarXML()
        End If
        Label1.Text = Session("Nombre")
        LabelConectado.Text = Session("Email")
    End Sub

    Protected Sub BotonImportarTareas_Click(sender As Object, e As EventArgs) Handles BotonImportarTareas.Click
        importarDocumentoXML()
    End Sub

    Protected Sub asignaturasProfe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles asignaturasProfe.SelectedIndexChanged
        mostrarXML()
        MensajeRespuesta.Text = ""
    End Sub

    Private Sub mostrarXML()
        If My.Computer.FileSystem.FileExists(Server.MapPath("App_Data/" & asignaturasProfe.SelectedValue & ".xml")) Then
            Xml1.DocumentSource = Server.MapPath("App_Data/" & asignaturasProfe.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
        End If
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

    Private Sub importarDocumentoXML()
        Try
            If My.Computer.FileSystem.FileExists(Server.MapPath("App_Data/" & asignaturasProfe.SelectedValue & ".xml")) Then
                conectar()

                Dim docXML As New XmlDocument
                docXML.Load(Server.MapPath("App_Data/" & asignaturasProfe.SelectedValue & ".xml"))

                Dim conexion As SqlConnection
                Dim dtpAsig As SqlDataAdapter
                Dim dstAsig As DataSet

                conexion = New SqlConnection("Data Source=hads.database.windows.net;Initial Catalog=Amigos;Persist Security Info=True;User ID=vadillo@ehu.es@hads;Password=curso19-20")
                dtpAsig = New SqlDataAdapter("SELECT * FROM TareasGenericas", conexion)
                dstAsig = New DataSet
                dtpAsig.Fill(dstAsig, "Tareas")
                Dim tabla As DataTable = dstAsig.Tables("Tareas")

                Dim tareas As XmlNodeList
                tareas = docXML.GetElementsByTagName("tarea")

                Dim builderAsignaturas As New SqlCommandBuilder(dtpAsig)

                Dim codigo As XmlNodeList = docXML.SelectNodes("/tareas/tarea/@codigo")
                Dim desc As XmlNodeList = docXML.SelectNodes("/tareas/tarea/descripcion")
                Dim hEstimadas As XmlNodeList = docXML.SelectNodes("/tareas/tarea/hestimadas")
                Dim explotacion As XmlNodeList = docXML.SelectNodes("/tareas/tarea/explotacion")
                Dim tipoTarea As XmlNodeList = docXML.SelectNodes("/tareas/tarea/tipotarea")

                Dim i As Integer
                For i = 0 To tareas.Count - 1
                    Dim row As DataRow = tabla.NewRow()
                    row("Codigo") = codigo(i).InnerText
                    row("Descripcion") = desc(i).InnerText
                    row("CodAsig") = asignaturasProfe.SelectedValue
                    row("HEstimadas") = hEstimadas(i).InnerText
                    row("Explotacion") = explotacion(i).InnerText
                    row("TipoTarea") = tipoTarea(i).InnerText
                    tabla.Rows.Add(row)
                Next

                dtpAsig.Update(dstAsig, "Tareas")
                dstAsig.AcceptChanges()
                MensajeRespuesta.Text = "Las tareas se han añadido correctamente."
                MensajeRespuesta.ForeColor = Drawing.Color.Green
                cerrarconexion()
            Else
                MensajeRespuesta.Text = "No existe el archivo XML a cargar."
                MensajeRespuesta.ForeColor = Drawing.Color.Red
            End If

        Catch ex As Exception
            MensajeRespuesta.Text = "Hay tareas repetidas."
            MensajeRespuesta.ForeColor = Drawing.Color.Red
        End Try
        mostrarXML()
    End Sub

    Protected Sub ButtonCerrarSesion_Click(sender As Object, e As EventArgs) Handles ButtonCerrarSesion.Click
        Session("Rol") = ""
        Session("Email") = ""
        Session("Nombre") = ""
        System.Web.Security.FormsAuthentication.SignOut()
        Response.Redirect("../Inicio.aspx")

    End Sub
End Class