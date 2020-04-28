Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports AccesoDatos.accesodatosSQL

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)>
<ToolboxItem(False)>
Public Class HorasMedia
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function calcularHoras(asignatura As String) As String
        conectar()
        Dim st = "SELECT AVG(HReales) FROM EstudiantesTareas INNER JOIN TareasGenericas on EstudiantesTareas.CodTarea=TareasGenericas.Codigo and TareasGenericas.CodAsig='" & asignatura & "'"
        Dim comand As New SqlCommand(st, conexion)
        Dim hMedia = comand.ExecuteScalar()
        cerrarconexion()
        If hMedia Is DBNull.Value Then
            Return 0
        End If
        Return hMedia
    End Function
End Class