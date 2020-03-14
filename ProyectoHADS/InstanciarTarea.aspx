<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InstanciarTarea.aspx.vb" Inherits="ProyectoHADS.InstanciarTarea" %>

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

      
    
    <div align="center" id="divRight">
        <div align="right" style="height: 33px">
         
            <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;<asp:Label ID="LabelConectado" runat="server" Font-Overline="False" Font-Underline="True" ForeColor="#6600FF"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCerrarSesion" runat="server" Font-Bold="True" ForeColor="Black" Height="31px" Text="Cerrar Sesión" Width="165px" />
         
        </div>
        <h1 id="h1">Alumnos <br /> Instanciar Tareas Genérica </h1>
        <br />   
        <p align="left" style="margin-left: 40px">

            <asp:Label ID="LabelUsuario" runat="server" Text="Usuario"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxUsuario" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
        <p align="left" style="margin-left: 40px">
            <asp:Label ID="LabelTarea" runat="server" Text="Tarea"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBoxTarea" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
                <p align="left" style="margin-left: 40px">

            <asp:Label ID="LabelHorasEst" runat="server" Text="Horas Est."></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxHorasEst" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
               <p align="left" style="margin-left: 40px">

            <asp:Label ID="LabelHorasReales" runat="server" Text="Horas Reales"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBoxHorasReales" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValidadorHorasVacias" runat="server" ControlToValidate="TextBoxHorasReales" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="ValidadorHorasNúmero" runat="server" ControlToValidate="TextBoxHorasReales" ErrorMessage="Introduzca un número" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        </p>
            <asp:GridView ID="TablaTareas" runat="server">
            </asp:GridView>
            <p align="left" style="margin-left: 40px">

            <asp:Button ID="BotonCrearTarea" runat="server" Text="Crear Tarea" Height="47px" Width="160px"/>
        </p>
          <div align="left" style="margin-left: 40px">

        <asp:Label ID="LabelAviso" runat="server"></asp:Label>

              <br />
              <br />

          </div>
        <p>
            <asp:HyperLink ID="LinkAtras" runat="server" NavigateUrl="~/TareasAlumno.aspx">Página anterior</asp:HyperLink>
        </p>
     </div>
   
    </form>
</body>
</html>



