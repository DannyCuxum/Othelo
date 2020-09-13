<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OpcionesTipoPartida.aspx.cs" Inherits="WebApplicationOthelo.OpcionesTipoPartida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Opciones De partida</title>
     <style>
        body {
            background-image:url('https://cutewallpaper.org/21/fondos-de-pantalla-para-pc-4k/Los-Mejores-100-Wallpapers-para-PC-Fondos-de-Pantalla.jpg');
	        position: center;
        }
         .auto-style1 {
             color: #FFFFFF;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto;border: solid white">
                <tr>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style1">
                        OPCIONES DE PARTIDAS</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;
                        <asp:Button ID="ButtonPc" runat="server" Height="33px" OnClick="ButtonPc_Click" Text="1 VS PC" Width="147px" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>

                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;
                        <asp:Button ID="ButtonVs" runat="server" Height="34px" OnClick="ButtonVs_Click" Text="1 VS 2" Width="148px" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>

                        &nbsp;</td>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
&nbsp;&nbsp;
                        <asp:Button ID="ButtonTorneo" runat="server" Height="36px" Text="TORNEO" Width="145px" />
                        <br />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
