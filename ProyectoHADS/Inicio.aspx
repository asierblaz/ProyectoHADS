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
            <label>Email                </label><asp:TextBox ID="emailLogin" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="validadorEmail" runat="server" ControlToValidate="emailLogin" ErrorMessage="No es un email válido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <label>Contraseña</label><asp:TextBox ID="passLogin" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validadorPass" runat="server" ErrorMessage="*" ControlToValidate="passLogin" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="botonLogin" runat="server" Text="Login" />
            <asp:HyperLink ID="linkRegistro" runat="server" NavigateUrl="~/Registro.aspx">Registrarse</asp:HyperLink>
            <asp:HyperLink ID="linkContraseña" runat="server" NavigateUrl="~/CambiarPassword.aspx">Restablecer contraseña</asp:HyperLink>
        </div>
    </form>
</body>
</html>