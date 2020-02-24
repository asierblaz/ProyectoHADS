Imports System.Net.Mail
Imports System.Net.NetworkCredentials


Public Class EnviarMail
    Public Function enviarEmail(email As String, cod As String, nombre As String) As Boolean

        Try
            'Direccion de origen
            Dim from_address As New MailAddress("ablazquez012@ikasle.ehu.eus")
            'Direccion de destino
            Dim to_address As New MailAddress(email)
            'Password de la cuenta 
            Dim from_pass As String = "Hads2020"
            'objeto para el cliente smtp
            Dim smtp As New SmtpClient
            'Host en este caso el servidor de outlook
            '     smtp.Host = "smtp-mail.outlook.com"
            smtp.Host = "smtp.ehu.eus"

            'Puerto
            smtp.Port = 587
            'SSL Activado para que se manden correos de manera segura 
            smtp.EnableSsl = True
            'No usar credenciales por defecto ya que si no no funciona
            smtp.UseDefaultCredentials = False
            'Credenciales 
            smtp.Credentials = New System.Net.NetworkCredential(from_address.Address, from_pass)
            'Creamos el mensaje con los parametros de origen y destino 
            Dim message As New MailMessage(from_address, to_address)
            'Añadimos el asunto 
            message.Subject = "Confirmación Registro"
            'Concatenamos el cuerpo del mensaje a la plantilla
            'message.Body = "<html><head></head><body>" + "Estimado <u>" + nombre + "</u>, <br> Para finalizar su registro  " + "<a href='http://localhost:50322/Confirmar.aspx?email=" + email + "&cod=" + cod + "'>Haga Click Aqui</a></body></html>"
            'este es el mensaje para la nube
            message.Body = "<html><head></head><body>" + "Estimado <u>" + nombre + "</u>, <br> Para finalizar su registro  " + "<a href='http://hads2020g19.azurewebsites.net/Confirmar.aspx?email=" + email + "&cod=" + cod + "'>Haga Click Aqui</a></body></html>"
            'Definimos el cuerpo como html para poder escoger mejor como lo mandamos
            message.IsBodyHtml = True
            'Se envía el correo 
            smtp.Send(message)
        Catch e As Exception

            Return False

        End Try
        Return True
    End Function


End Class