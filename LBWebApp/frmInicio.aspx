<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" Inherits="LBWebApp.frmInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblInicio" runat="server" Text=""></asp:Label>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Inventario</asp:LinkButton>
        </div>
    </form>
</body>
</html>
