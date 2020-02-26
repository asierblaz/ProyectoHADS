Imports AccesoDatos.accesodatosSQL
Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()

    End Sub

    Protected Sub botonLogin_Click(sender As Object, e As EventArgs) Handles botonLogin.Click
        Dim email As String = emailLogin.Text
        Dim pass As String = passLogin.Text

        If (login(email, pass) = True) Then
            ' LabelAviso.Text ="Bienvenido al sistema " + email
            MsgBox("Bienvenido al sistema " + email)

        ElseIf (emailExiste(email) = False) Then
            LabelAviso.Text = "El usuario no estra registrado en el sistema"

        Else
            LabelAviso.Text = "Los datos introducidos son incorrectos"

        End If

    End Sub

    Private Sub botonLogin_Load(sender As Object, e As EventArgs) Handles botonLogin.Load

    End Sub

    Private Sub Inicio_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
End Class