<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ImportarTareasXMLDocument.aspx.vb" Inherits="ProyectoHADS.ImportarTareasXMLDocument" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Profesor Importar Tareas Genericas</title>
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

      
    
    <div align="center" id="divRight">
        <div align="right" style="height: 33px">
         
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:Label ID="LabelConectado" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="#6600FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCerrarSesion" runat="server" Font-Bold="True" ForeColor="Black" Height="31px" Text="Cerrar Sesión" Width="165px" />
         
        </div>
        </br>
        <h1 id="h1">Profesor <br /> Importar Tareas Genéricas</h1>
        <p>
            <asp:DropDownList ID="asignaturasProfe" runat="server" AutoPostBack="True" Height="39px" Width="124px">
            </asp:DropDownList>
            <asp:Button ID="BotonImportarTareas" runat="server" Text="Importar (XMLD)" Height="34px" Width="171px" />
        </p>
        <p>
            <asp:Label ID="MensajeRespuesta" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Xml ID="Xml1" runat="server"></asp:Xml>
        </p>
     </div>
   
    </form>
</body>
</html>



