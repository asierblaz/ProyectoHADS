Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
        Dim alumnosOnline As New Collection
        Dim profesoresOnline As New Collection

        Application("alumOnline") = 0
        Application("profOnline") = 0

        Application("alumsOnline") = alumnosOnline
        Application("profesOnline") = profesoresOnline
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
        Application.Lock()
        If (Session("Rol") = "Alumno") Then
            Application("alumOnline") -= 1
            Application("alumsOnline").Remove(Session("Email"))
        ElseIf (Session("Rol") = "Profesor") Then
            Application("profOnline") -= 1
            Application("profesOnline").Remove(Session("Email"))
        End If
        Application.UnLock()
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
        Application.Lock()
        If (Session("Rol") = "Alumno") Then
            Application("alumOnline") -= 1
            Application("alumsOnline").Remove(Session("Email"))
        ElseIf (Session("Rol") = "Profesor") Then
            Application("profOnline") -= 1
            Application("profesOnline").Remove(Session("Email"))
        End If
        Application.UnLock()
    End Sub
End Class