<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registro.aspx.vb" Inherits="ProyectoHADS.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <t1>
            REGISTRAR USUARIO </t1>
        </div>
        <p>
            <div>
                Email &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="emailtext" runat="server"></asp:TextBox>
                
                                <asp:RequiredFieldValidator ID="obliEmail" runat="server" ControlToValidate="emailtext" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="emailformato" runat="server" ErrorMessage="El formato de email no es valido" ForeColor="Red" ControlToValidate="emailtext" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div>
                Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="nombretext" runat="server"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="obliNombre" runat="server" ControlToValidate="nombretext" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
            <div>
                Apellidos &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="apellidostext" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="obliApellido" runat="server" ControlToValidate="apellidostext" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

            </div>
            <div>
                Password &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <asp:TextBox ID="passwordtext" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="obliPass" runat="server" ControlToValidate="passwordtext" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

            </div>
            <div>
                Repita Passsword&nbsp; &nbsp;&nbsp;            
                <asp:TextBox ID="password2text" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="obliRepPass" runat="server" ControlToValidate="password2text" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>

            </div>
            <br />

            <div>
                Rol&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Alumno" GroupName="rol" />&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Profesor" GroupName="rol" />
                <br />
                <br />
            </div>






            &nbsp;
        <asp:Button ID="Button1" runat="server" Height="36px" Text="Registrarse" Width="188px" />
        </p>
    </form>
</body>
</html>
