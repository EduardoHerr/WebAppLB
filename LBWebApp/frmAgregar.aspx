<%@ Page Title="" Language="C#" MasterPageFile="~/plantilla.Master" AutoEventWireup="true" CodeBehind="frmAgregar.aspx.cs" Inherits="LBWebApp.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .contenedor {
            margin: 5px 45px 0 45px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="contenedor">
        <h1> <asp:Label ID="lblAviso" runat="server" Text=""></asp:Label></h1>
        <asp:LinkButton ID="lnkInsertar" OnClick="lnkInsertar_Click" runat="server">Volver a Insertar un Producto</asp:LinkButton>
        <div class="row">
            <div class="col">
                <div class="row">
                    <div class="col">
                        <div class="mb-3 row">
                            <asp:Label ID="lblNombre" CssClass="col-sm-2 col-form-label" runat="server" Text="Nombre"></asp:Label>
                            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="col">
                        <div class="mb-3 row">
                            <asp:Label ID="lblCodigo" CssClass="col-sm-2 col-form-label" runat="server" Text="Codigo"></asp:Label>
                            <asp:TextBox ID="txtCodigo" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <div class="mb-3 row">
                                <asp:Label ID="lblDescripcion" CssClass="col-sm-2 col-form-label" runat="server" Text="Descripcion"></asp:Label>
                                <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col">
                            <div class="mb-3 row">
                                <asp:Label ID="lblMarca" CssClass="col-sm-2 col-form-label" runat="server" Text="Marca"></asp:Label>
                                <asp:TextBox ID="txtMarca" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>
                        </div>

                    </div>

                    <div class="row">
                        <div class="col">
                            <asp:Button ID="btnEnviar" runat="server" CssClass="btn btn-success" Text="Enviar" OnClick="btnEnviar_Click" />
                        </div>
                        <div class="col">
                            <div class="mensaje">
                            <asp:Label ID="lblMensaje" runat="server" Text="Hola Mundo"></asp:Label>
                                </div>
                        </div>
                    </div>
                </div>
            </div>
        
        <div class="col">
            <div>
                <asp:GridView ID="gdata1" CssClass="table"  OnRowCommand="gdata1_RowCommand" AutoGenerateColumns="false" runat="server">
                    <Columns>
                        <asp:TemplateField HeaderText="Nombre">
                            <ItemTemplate>
                                <asp:Label ID="lblNombre" runat="server" Text='<%#Eval("prodNombre")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Codigo">
                            <ItemTemplate>
                                <asp:Label ID="lblCodigo" runat="server" Text='<%#Eval("prodCodigo")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:Label ID="lblDescripcion" runat="server" Text='<%#Eval("prodDescripcion")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Marca">
                            <ItemTemplate>
                                <asp:Label ID="lblMarca" runat="server" Text='<%#Eval("prodMarca")%>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Acciones">
                            <ItemTemplate>
                                
                                <asp:LinkButton ID="lnkEditar" CommandName="Editar" CommandArgument='<%#Eval("idProducto")%>' CssClass="btn btn-warning"  runat="server">Editar</asp:LinkButton>
                                <asp:LinkButton ID="lnkEliminar" CssClass="btn btn-danger" runat="server">Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>

            </div>
    </div>
</asp:Content>
