<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAgregar.aspx.cs" Inherits="LBWebApp.frmAgregar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:Label ID="lblCodigo" runat="server" Text="Codigo"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
            <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
