<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="ProyectoHADS.Inicio" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="INICIO APLICACIÓN HADS"></asp:Label>
            <label>
            <br />
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="emailLogin" runat="server"></asp:TextBox>
            </label>
            <asp:RegularExpressionValidator ID="validadorEmail" runat="server" ControlToValidate="emailLogin" ErrorMessage="No es un email válido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <label>Contraseña&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label><asp:TextBox ID="passLogin" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validadorPass" runat="server" ErrorMessage="*" ControlToValidate="passLogin" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="botonLogin" runat="server" Text="Login" Height="36px" Width="158px" />
            <br />
            <br />
            <asp:Label ID="LabelAviso" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="linkRegistro" runat="server" NavigateUrl="~/Registro.aspx">Registrarse</asp:HyperLink>
            &nbsp;&nbsp;
            <asp:HyperLink ID="linkContraseña" runat="server" NavigateUrl="~/CambiarPassword.aspx">Restablecer contraseña</asp:HyperLink>
        </div>
    </form>
</body>
</html>