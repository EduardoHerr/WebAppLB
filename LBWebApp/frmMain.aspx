<%@ Page Title="" Language="C#" MasterPageFile="~/plantilla.Master" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="LBWebApp.frmMain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="checkbox" class="form-check-input" name="check" id="check" value="1" onchange="javascript:showContent()" />
    Mostrar Formulario
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
                <div class="row">
                <div class="col" id="prueba">
                    <asp:GridView ID="GridView1" AutoGenerateColumns="false" CssClass="table" runat="server">
                        <Columns>
                            <asp:TemplateField HeaderText="Nombre">
                                <ItemTemplate>
                                    <asp:Label ID="lblnombre" runat="server" Text='<%#Eval("prodNombre") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Codigo">
                                <ItemTemplate>
                                    <asp:Label ID="lblcodigo" runat="server" Text=<%#Eval("prodCodigo") %>></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Descripcion">
                                <ItemTemplate>
                                    <asp:Label ID="lbldescripcion" runat="server" Text=<%#Eval("prodDescripcion") %>></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Marca">
                                <ItemTemplate>
                                    <asp:Label ID="lblmarca" runat="server" Text=<%#Eval("prodMarca") %>></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
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
