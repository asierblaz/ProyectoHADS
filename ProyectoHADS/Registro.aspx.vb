Public Class Registro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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

        'EnviarMail.enviarEmail(emailtext.Text, valorAleatorio)
        ' MsgBox(valorAleatorio)

        EnviarMail.enviarEmail(emailtext.Text, cod, nombretext.Text)




    End Sub
End Class