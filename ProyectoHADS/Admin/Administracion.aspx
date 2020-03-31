<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Administracion.aspx.vb" Inherits="ProyectoHADS.Administracion" %>

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
         
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCerrarSesion" runat="server" Font-Bold="True" ForeColor="Black" Height="31px" Text="Cerrar Sesión" Width="165px" />
         
        </div>
        </br>
        <h1 id="h1">Administrador <br /> Gestión de Usuarios</h1>
        <p align="left" style="margin-left: 40px">
            
            &nbsp;<p align="left">
            
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="email" DataSourceID="Usuarios">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
                    <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                    <asp:CheckBoxField DataField="confirmado" HeaderText="confirmado" SortExpression="confirmado" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="Usuarios" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT [email], [nombre], [apellidos], [tipo], [confirmado] FROM [Usuarios]" DeleteCommand="DELETE FROM [Usuarios] WHERE [email] = @email" InsertCommand="INSERT INTO [Usuarios] ([email], [nombre], [apellidos], [tipo], [confirmado]) VALUES (@email, @nombre, @apellidos, @tipo, @confirmado)" UpdateCommand="UPDATE [Usuarios] SET [nombre] = @nombre, [apellidos] = @apellidos, [tipo] = @tipo, [confirmado] = @confirmado WHERE [email] = @email">
                <DeleteParameters>
                    <asp:Parameter Name="email" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="apellidos" Type="String" />
                    <asp:Parameter Name="tipo" Type="String" />
                    <asp:Parameter Name="confirmado" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="apellidos" Type="String" />
                    <asp:Parameter Name="tipo" Type="String" />
                    <asp:Parameter Name="confirmado" Type="Boolean" />
                    <asp:Parameter Name="email" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
        <p align="left">
            
            &nbsp;<p align="left" style="margin-left: 40px">
            
            &nbsp;<p align="left">
            
            &nbsp;<p align="left">
            
            &nbsp;<p align="left">
            
            &nbsp;</div>
    </p>
    </form>
</body>
</html>




