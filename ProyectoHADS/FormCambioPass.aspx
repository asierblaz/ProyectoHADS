<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormCambioPass.aspx.vb" Inherits="ProyectoHADS.FormCambioPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            MODIFICAR CONTRASEÑA<br />
            <br />
            Introduzca su nueva contraseña:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="passwordtext" runat="server" TextMode="Password"></asp:TextBox>
                            <br />
            <br />
            Repita su contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="pass2text" runat="server" TextMode="Password"></asp:TextBox>
                            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="34px" Text="Modificar" Width="127px" />
        </div>
    <p>
        <asp:Label ID="errorpass" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
    <a id="link" href="Inicio.aspx" style="display:inline-block;height:40px;width:471px;Z-INDEX: 102; LEFT: 141px; POSITION: absolute; TOP: 299px">Haz click aqui para identificarte en el sistema</a>
</body>
</html>

