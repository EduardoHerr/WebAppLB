<%@ Page Title="" Language="C#" MasterPageFile="~/plantilla.Master" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="LBWebApp.frmMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #prueba{
            width:100%;
            background-color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="checkbox" name="check" id="check" value="1" onchange="javascript:showContent()" />
    Mostrar Formulario
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                <div class="col" id="prueba">
                    xdxdxd
                </div>
                <div id="content" class="col" style="display:none;">
                    Hola Mundo
                </div>
                    </div>
            </div>

            <script type="text/javascript">
                function showContent() {
                    element = document.getElementById("content");
                    check = document.getElementById("check");
                    if (check.checked) {
                        element.style.display = 'block';
                    } else {
                        element.style.display = 'none';
                    }
                }
            </script>

        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
