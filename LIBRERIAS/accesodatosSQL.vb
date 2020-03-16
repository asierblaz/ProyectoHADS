
Imports System.Data.SqlClient

Public Class accesodatosSQL
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Public Shared Function conectar() As String
        Try
            ' conexion.ConnectionString = “Data Source=tcp:hadsg19.database.windows.net,1433;Initial Catalog=HADS-19;Persist Security Info=True;User ID=ablazquez012@ikasle.ehu.eus@hadsg19;Password=Hads2020"
            conexion.ConnectionString = “Data Source=tcp:hads.database.windows.net, 1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=vadillo@ehu.es@hads;Password=curso19-20;MultipleActiveResultSets=True;"
            ' hemos añadido esta linea de codigo para poder hacer datareader anidados MultipleActiveResultSets=True
            conexion.Open()

        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function

    Public Shared Sub cerrarconexion()
        conexion.Close()

    End Sub

    Public Shared Function insertar(ByVal email As String, ByVal nombre As String, ByVal apellidos As String, ByVal numconfir As Integer, ByVal confirmado As Boolean, ByVal tipo As String, ByVal pass As String, ByVal codpass As Integer) As String

        Dim st = "insert into Usuarios (email,nombre,apellidos,numconfir,confirmado,tipo,pass,codpass ) values ('" & email & "','" & nombre & "','" & apellidos & "','" & numconfir & "','" & confirmado & "','" & tipo & "','" & pass & "' ,'" & codpass & "')"
        Dim numregs As Integer
        If emailExiste(email) = False Then
            comando = New SqlCommand(st, conexion)
            Try
                numregs = comando.ExecuteNonQuery()
            Catch ex As Exception
                Return ex.Message
            End Try
            Return ("Para finalizar su registro revise su correo electronico, habra recibido un mensaje para confirmar su cuenta.")
        Else
            Return ("El email ya está registrado.")
        End If
    End Function


    Public Shared Function login(ByVal email As String, ByVal pass As String) As Boolean
        Dim st = "select count(*) from Usuarios where email ='" & email & "' and pass='" & pass & "' and confirmado = 'True'"
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function emailExiste(ByVal email As String) As Boolean
        Dim st = "select count(*) from Usuarios where email ='" & email & "'"
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function confirmarUsuario(ByVal email As String, cod As Integer) As String

        Dim st = "update Usuarios set confirmado='True' Where (email='" & email & "' and numconfir='" & cod & "')"

        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        numregs = comando.ExecuteNonQuery()

        If numregs = 1 Then
            Return "Enhorabuena su registro se ha completado con exito"
        Else
            Return "Desgraciadamente no hemos podido confirmar su correo electronico, intentelo de nuevo"
        End If
    End Function

    Public Shared Function insertcodpass(ByVal email As String, cod As Integer) As String

        Dim st = "update Usuarios set codpass='" & cod & "' Where (email='" & email & "')"

        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        numregs = comando.ExecuteNonQuery()

        If numregs = 1 Then
            Return "Revise su email para modificar la contraseña"
        Else
            Return "Error"
        End If
    End Function


    Public Shared Function modificarContrasena(ByVal email As String, cod As Integer, ByVal pass As String) As String

        Dim st = "update Usuarios set pass='" & pass & "' Where (email='" & email & "' and codpass='" & cod & "')"

        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        numregs = comando.ExecuteNonQuery()

        If numregs = 1 Then
            Return "Enhorabuena su contraseña se ha modificado con exito"
        Else
            Return "Desgraciadamente no hemos podido modificar su contraseña, intentelo de nuevo"
        End If
    End Function

    Public Shared Function obtenerdatos(ByVal email) As SqlDataReader
        Dim st = "select * from Usuarios WHERE email='" & email & "' "
        comando = New SqlCommand(st, conexion)

        Return (comando.ExecuteReader())

    End Function

    Public Shared Function insertarTareasEstudiante(ByVal email As String, ByVal codAsig As String, ByVal HEstimadas As Integer, ByVal HReales As Integer) As String

        Dim st = "insert into EstudiantesTareas values ('" & email & "','" & codAsig & "','" & HEstimadas & "','" & HReales & "')"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return ("Tarea insertada correctamente.")
    End Function

    Public Shared Function insertarTareasProfesor(ByVal codigo As String, ByVal Descripcion As String, ByVal codAsig As String, ByVal HEstimadas As Integer, ByVal TipoTareas As String) As String

        Dim st = "insert into TareasGenericas values ('" & codigo & "','" & Descripcion & "','" & codAsig & "','" & HEstimadas & "','1','" & TipoTareas & "')"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return ("Tarea insertada correctamente.")
    End Function
End Class
