<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="ProyectoHADS.TareasAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Tareas Alumno</title>
    <style type="text/css">
        body{
             font-family: Georgia, 'Times New Roman', Times, serif;
        }


        #h1{
            background-color: #f1f1f1
        }
    
    </style>
</head>
<body style="height: 720px">
    <form id="form1" runat="server">

      
    
    <div align="center">
        <div align="right" style="height: 33px">
         
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:Label ID="LabelConectado" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="#6600FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCerrarSesion" runat="server" Font-Bold="True" ForeColor="Black" Height="31px" Text="Cerrar Sesión" Width="165px" />
         
        </div>
        </br>
        <h1 id="h1">Alumnos <br /> Gestión de tareas Genéricas</h1>
        <p align="left" style="margin-left: 40px">
            
        <asp:DropDownList ID="ListAsignaturas" runat="server" Height="36px" Width="157px" AutoPostBack="True">
            </asp:DropDownList>
            
       
        <p align="left">
            
            &nbsp;<p align="left">
            
            &nbsp;<p align="left" style="margin-left: 40px">
            
            &nbsp;<p align="left">
            
            <asp:GridView ID="TablaTareas" runat="server">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Instanciar" />
                </Columns>
            </asp:GridView>
        <p align="left">
            
            &nbsp;<p align="left">
            
            &nbsp;</div>
    </p>
    </form>
</body>
</html>



