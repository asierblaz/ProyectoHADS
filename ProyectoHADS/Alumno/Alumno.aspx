﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Alumno.aspx.vb" Inherits="ProyectoHADS.Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Tareas Alumno</title>
    <style type="text/css">
        body{
             font-family: Georgia, 'Times New Roman', Times, serif;
        }
        ul {
            list-style-type: none;
            margin: 0;
            padding: 0;
            width: 20%;
            background-color: #e1fae5;
            position: fixed;
            height: 100%;
        }
        li a {
            align-content:center;
            display: inline-block;
            color: #000;
            padding: 8px 16px;
            height: 18px;
            margin-top: 5px;
        }
        div p{
            text-align:center;
            font-weight: bold;
            font-family:serif;
            font-size: 25px;
            margin-top: 45px;
            margin-bottom: 35px;
        }
        #form1 {
            height: 650px;
        }
    </style>
</head>
<body style="height: 720px">
    <form id="form1" runat="server">
         
      <ul>
          <li></li>
          <li></li>
          <li></li>
          <li></li>
          <li></li>
          <li><b><a href='TareasAlumno.aspx' id="tareasGenericas">Tareas Genéricas</a></b></li>
 
      </ul>
    
    <div align="center" style="height: 577px; width: 1207px; float:right; margin-left: 7px;" id="divRight">
        <div align="right" style="height: 33px">
         
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:Label ID="LabelConectado" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="#6600FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCerrarSesion" runat="server" Font-Bold="True" ForeColor="Black" Height="31px" Text="Cerrar Sesión" Width="165px" />
         
        </div>
        </br>
        <div align="left">
        
           </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        </br>
        </br>
        <h1>Gestión Web de Tareas-Dedicación</h1>
        <h1>Alumno</h1>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        </br>
        <p>
            &nbsp;</p>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <b>
                <asp:Label ID="textoConectados" runat="server"></asp:Label>
                <asp:Timer ID="Timer1" runat="server" Interval="4000">
                </asp:Timer>
                <asp:ListBox ID="alumnosC" runat="server"></asp:ListBox>
                <asp:ListBox ID="profesoresC" runat="server"></asp:ListBox>
                </b>
            </ContentTemplate>
        </asp:UpdatePanel>
        <p>
            &nbsp;</p>
     </div>
   
    </form>
</body>
</html>



