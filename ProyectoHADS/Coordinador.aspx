<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Coordinador.aspx.vb" Inherits="ProyectoHADS.Coordinador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>Coordinador</title>
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
        <h1 id="h1">Coordinador<br /> Dedicación Media
        </h1>
     </div>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <div>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="dropAsignaturas" runat="server" DataSourceID="Asignaturas" DataTextField="codigo" DataValueField="codigo" AutoPostBack="True">
                    </asp:DropDownList>
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Horas de media en la asignatura seleccionada:"></asp:Label>
                    <asp:Label ID="horasMediaLabel" runat="server"></asp:Label>
                    <asp:SqlDataSource ID="Asignaturas" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT DISTINCT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>               
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
