﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports AccesoDatos.accesodatosSQL
Imports Security.Security
Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()

    End Sub

    Protected Sub botonLogin_Click(sender As Object, e As EventArgs) Handles botonLogin.Click
        Dim email As String = emailLogin.Text
        Dim pass As String = passLogin.Text
        Dim tipo As String

        Dim usuario As SqlDataReader

        Dim md5Hash As MD5 = MD5.Create()
        Dim passHash As String = getMd5Hash(md5Hash, pass)
        If (login(email, passHash) = True) Then
            obtenerdatos(email)
            ' LabelAviso.Text ="Bienvenido al sistema " + email

            usuario = obtenerdatos(email)
            usuario.Read()
            tipo = usuario.Item("tipo")
            Session("Rol") = tipo
            Session("Email") = email
            Session("Nombre") = usuario.Item("nombre")

            Application.Lock()
            If (tipo = "Alumno") Then
                If Not Application("alumsOnline").Contains(Session("Email")) Then
                    Application("alumOnline") += 1
                    Application("alumsOnline").Add(Session("Email"), Session("Email"))
                End If
                MsgBox("Bienvenido al sistema de gestion de Alumnos " + usuario.Item("nombre"))
                System.Web.Security.FormsAuthentication.SetAuthCookie("alumno", False)
                Response.Redirect("Alumno/Alumno.aspx")
            ElseIf (email = "vadillo@ehu.es") Then
                If Not Application("profesOnline").Contains(Session("Email")) Then
                    Application("profOnline") += 1
                    Application("profesOnline").Add(Session("Email"), Session("Email"))
                End If
                System.Web.Security.FormsAuthentication.SetAuthCookie("vadillo@ehu.es", False)
                Response.Redirect("Profesor/Profesor.aspx")
            ElseIf (email = "admin@ehu.es") Then
                System.Web.Security.FormsAuthentication.SetAuthCookie("admin", False)
                Response.Redirect("Admin/Administracion.aspx")
            ElseIf (tipo = "Profesor") Then
                If Not Application("profesOnline").Contains(Session("Email")) Then
                    Application("profOnline") += 1
                    Application("profesOnline").Add(Session("Email"), Session("Email"))
                End If
                MsgBox("Bienvenido al sistema de gestion de Profesores " + usuario.Item("nombre"))
                System.Web.Security.FormsAuthentication.SetAuthCookie("profesor", False)
                Response.Redirect("Profesor/Profesor.aspx")
            End If
            Application.UnLock()
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