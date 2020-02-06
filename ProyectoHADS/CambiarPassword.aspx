<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CambiarPassword.aspx.vb" Inherits="ProyectoHADS.CambiarPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Introduce el email"></asp:Label>
        <asp:TextBox ID="emailRestablecer" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="emailNoVacio" runat="server" ControlToValidate="emailRestablecer" Display="Dynamic" ErrorMessage="El campo no puede estar vacio" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="validadorEmail" runat="server" ControlToValidate="emailRestablecer" Display="Dynamic" ErrorMessage="No es un email válido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Restablecer contraseña" />
        </div>
    </form>
</body>
</html>
