<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertarTarea.aspx.vb" Inherits="ProyectoHADS.InsertarTarea" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Gestión de Tareas Profesor</title>
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
        <h1 id="h1">Profesor <br /> Insertar Tarea</h1>
     </div>
        <p style="margin-left: 40px">
            <asp:Label ID="LabelCodigo" runat="server" Text="Código"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextCodigo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextCodigo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="LabelDescripcion" runat="server" Text="Descripción"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextDescripcion" runat="server" Height="63px" Width="753px"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="LabelAsignaturas" runat="server" Text="Asignaturas"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Asignaturas" runat="server" DataSourceID="AsignaturasProf" DataTextField="codigoasig" DataValueField="codigoasig">
            </asp:DropDownList>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="LabelHorasEstimadas" runat="server" Text="Horas Estimadas"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextHorasEstimadas" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextHorasEstimadas" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="ValidadorHorasNúmero" runat="server" ControlToValidate="TextHorasEstimadas" ErrorMessage="Introduzca un número" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
        </p>
        <p style="margin-left: 40px">
            <asp:Label ID="LabelTipoTarea" runat="server" Text="Tipo Tarea"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="TipoTareas" runat="server" DataSourceID="TiposTareas" DataTextField="TipoTarea" DataValueField="TipoTarea">
            </asp:DropDownList>
        </p>
        <div style="margin-left: 40px">
            <asp:Button ID="BotonAñadir" runat="server" Height="42px" Text="Añadir tarea" Width="143px" />
            <br />
            <br />
            <asp:Label ID="LabelAviso" runat="server"></asp:Label>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Profesor/TareasProfesor.aspx">Ver Tareas</asp:HyperLink>
        </p>
        <asp:SqlDataSource ID="TiposTareas" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT DISTINCT [TipoTarea] FROM [TareasGenericas]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="AsignaturasProf" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="SELECT DISTINCT GruposClase.codigoasig FROM GruposClase INNER JOIN ProfesoresGrupo ON GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (ProfesoresGrupo.email = @email)">
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="Email" />
                </SelectParameters>
        </asp:SqlDataSource>
   
    </form>
</body>
</html>



