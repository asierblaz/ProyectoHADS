Imports AccesoDatos.accesodatosSQL

Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()
        labprueba.Text = result


    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim EnviarMail As New EnviarMail.EnviarMail

        Dim numAleatorio As New Random()
        Dim valorAleatorio As Integer = numAleatorio.Next(10000, 99999)
        Dim cod As String
        cod = valorAleatorio.ToString()

        EnviarMail.enviarEmail(emailtext.Text, cod, nombretext.Text)


    End Sub

    Private Sub Registro_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim email, nombre, apellidos, tipo, pass As String
        email = emailtext.Text
        nombre = nombretext.Text
        apellidos = apellidostext.Text
        pass = passwordtext.Text
        tipo = "Alumno"
        If (pass = password2text.Text) Then
            labprueba.Text = insertar(email, nombre, apellidos, 1, False, tipo, pass, 0)
        Else
            labprueba.Text = "Las constraseñas no coinciden"

        End If
    End Sub
End Class