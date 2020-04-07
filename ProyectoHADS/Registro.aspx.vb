Imports System.Security.Cryptography
Imports AccesoDatos.accesodatosSQL
Imports Security.Security



Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EnviarMail As New EnviarMail.EnviarMail

        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(10000, 99999)
        Dim cod As String
        cod = valorAleatorio.ToString()

        Dim email, nombre, apellidos, tipo, pass As String
        email = emailtext.Text
        nombre = nombretext.Text
        apellidos = apellidostext.Text
        pass = passwordtext.Text

        If RadioButton1.Checked Then
            tipo = "Alumno"
        Else
            tipo = "Profesor"
        End If

        If (pass = password2text.Text) Then
            Dim md5Hash As MD5 = MD5.Create()
            Dim passHash As String = getMd5Hash(md5Hash, pass)
            labprueba.Text = insertar(email, nombre, apellidos, valorAleatorio, False, tipo, passHash, 0)
            EnviarMail.enviarEmail(email, cod, nombre)

        Else
            errorpass.Text = "Las constraseñas no coinciden"

        End If
    End Sub



    Private Sub Registro_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()

    End Sub

End Class