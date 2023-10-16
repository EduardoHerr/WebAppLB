<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="LBWebApp.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Inter&display=swap');

        * {
            margin: 0;
            padding: 0;
            font-family: 'Inter', sans-serif;
        }

        body {
            width: 100%;
            height: 100vh;
            background-image: url("../resources/svgbg.svg");
            display: flex;
            align-items: center;
            justify-content: center;
        }
        

        .formulario {
            background: rgba( 255, 255, 255, 0.25 );
            box-shadow: 0 8px 32px 0 rgba( 31, 38, 135, 0.37 );
            backdrop-filter: blur( 4px );
            -webkit-backdrop-filter: blur( 4px );
            border-radius: 10px;
            border: 1px solid rgba( 255, 255, 255, 0.18 );
            color: white;
            padding: 15px;
        }

        .txt {
            width: 100%;
            outline: none;
            border: none;
            height: 30px;
            border-radius: 10px;
            background: rgba( 0, 0, 0, 0.25 );
            text-align: center;
            color: white;
        }

            .txt:focus {
                border-bottom: solid 1px white;
            }

        .row {
            display: flex;
        }

        .column {
            flex: 50%;
        }
        .btningresar{
            background-color:#4f0354;
            padding:5px 10px;
            color: white;
            border-radius:5px;
            border:none;
            outline:none;
            width:75%;
            height:75%;
        }
        .btningresar:hover{
            background-color:#bc00d6;
            cursor:pointer;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="formulario">
            <center>
                <h1>Inicio de Sesión</h1>
            </center>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
            <br />
            <asp:TextBox ID="txtUser" CssClass="txt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
            <br />
            <asp:TextBox ID="txtClave" CssClass="txt" runat="server"></asp:TextBox>
            <br />
            <br />
            <div class="row">
                <div class="column">
                    <asp:LinkButton ID="lnkOlvido" runat="server">¿Olvido la contraseña?</asp:LinkButton>
                </div>
                <div class="column">
                    <asp:Button ID="btnIngreso" CssClass="btningresar" OnClick="btnIngreso_Click" runat="server" Text="Ingresar" />
                </div>
            </div>
            <br />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
