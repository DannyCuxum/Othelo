<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginOthelo.aspx.cs" Inherits="WebApplicationOthelo.LoginOthelo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login Principal</title>
    <style>
        body {
            background-image:url('https://cutewallpaper.org/21/fondos-de-pantalla-para-pc-4k/Los-Mejores-100-Wallpapers-para-PC-Fondos-de-Pantalla.jpg');
	        position: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table style="margin:auto;border: solid white">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Username" ForeColor="white" ></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Pasword" ForeColor="white" ></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPasword" runat="server" textMode="Password" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td>

                        <asp:Button ID="Button1" runat="server" Height="23px" OnClick="Button1_Click" Text="Registrarse" Width="92px" />

                    </td>
                    <td>
                        <asp:Label ID="LabelErrorMessage" runat="server" Text="UserName Error Credential" ForeColor="red"></asp:Label>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
