﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioFinal.aspx.cs" Inherits="WebApplicationOthelo.FormularioFinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prueba Tablero</title>
    <style>
        body {
            background-image:url('https://cutewallpaper.org/21/fondos-de-pantalla-para-pc-4k/Los-Mejores-100-Wallpapers-para-PC-Fondos-de-Pantalla.jpg');
	        position: center;
        }
         .auto-style2 {
            width: 1011px;
            height: 410px;
        }
        .auto-style3 {
            color: #FFFFFF;
        }
    </style>
</head>
<body style="height: 406px">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" ForeColor="White" Text="A"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">&nbsp; B&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; C&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; D&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; F&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; G&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; H</span><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">1</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnA1" runat="server" BackColor="Green" OnClick="BtnA1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB1" runat="server" BackColor="Green" OnClick="BtnB1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC1" runat="server" BackColor="Green" OnClick="BtnC1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnD1" runat="server" BackColor="Green" OnClick="BtnD1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnE1" runat="server" BackColor="Green" OnClick="BtnE1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnF1" runat="server" BackColor="Green" OnClick="BtnF1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnG1" runat="server" BackColor="Green" OnClick="BtnG1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH1" runat="server" BackColor="Green" OnClick="BtnH1_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">2&nbsp;&nbsp; </span>&nbsp;&nbsp;
            <asp:Button ID="BtnA2" runat="server" BackColor="Green" OnClick="BtnA2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB2" runat="server" BackColor="Green" OnClick="BtnB2_Click" style="height: 26px" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC2" runat="server" BackColor="Green" OnClick="BtnC2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnD2" runat="server" BackColor="Green" OnClick="BtnD2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnE2" runat="server" BackColor="Green" OnClick="BtnE2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnF2" runat="server" BackColor="Green" OnClick="BtnF2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnG2" runat="server" BackColor="Green" OnClick="BtnG2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH2" runat="server" BackColor="Green" OnClick="BtnH2_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">3 </span>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnA3" runat="server" BackColor="Green" OnClick="BtnA3_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB3" runat="server" BackColor="Green" OnClick="BtnB3_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC3" runat="server" BackColor="Green" OnClick="BtnC3_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnD3" runat="server" BackColor="Green" OnClick="BtnD3_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnE3" runat="server" BackColor="Green" OnClick="BtnE3_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnF3" runat="server" BackColor="Green" OnClick="BtnF3_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnG3" runat="server" BackColor="Green" OnClick="BtnG3_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH3" runat="server" BackColor="Green" OnClick="BtnH3_Click" Text="&quot;&quot;" Width="69px" Enabled="False" style="height: 26px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">4 </span>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnA4" runat="server" BackColor="Green" OnClick="BtnA4_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB4" runat="server" BackColor="Green" OnClick="BtnB4_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC4" runat="server" BackColor="Green" OnClick="BtnC4_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnD4" runat="server" BackColor="White" Enabled="False" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnE4" runat="server" BackColor="Black" Enabled="False" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnF4" runat="server" BackColor="Green" OnClick="BtnF4_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnG4" runat="server" BackColor="Green" OnClick="BtnG4_Click" Text="&quot;&quot;" Width="69px" Enabled="False" style="height: 26px" />
&nbsp;<asp:Button ID="BtnH4" runat="server" BackColor="Green" OnClick="BtnH4_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">5</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnA5" runat="server" BackColor="Green" OnClick="BtnA5_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB5" runat="server" BackColor="Green" OnClick="BtnB5_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC5" runat="server" BackColor="Green" OnClick="BtnC5_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnD5" runat="server" BackColor="Black" Enabled="False" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnE5" runat="server" BackColor="White" Enabled="False" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnF5" runat="server" BackColor="Green" OnClick="BtnF5_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnG5" runat="server" BackColor="Green" OnClick="BtnG5_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH5" runat="server" BackColor="Green" OnClick="BtnH5_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">6&nbsp;&nbsp; </span>&nbsp;&nbsp;
            <asp:Button ID="BtnA6" runat="server" BackColor="Green" OnClick="BtnA6_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB6" runat="server" BackColor="Green" OnClick="BtnB6_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC6" runat="server" BackColor="Green" OnClick="BtnC6_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnD6" runat="server" BackColor="Green" OnClick="BtnD6_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnE6" runat="server" BackColor="Green" OnClick="BtnE6_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnF6" runat="server" BackColor="Green" OnClick="BtnF6_Click" Text="&quot;&quot;" Width="69px" />
&nbsp;<asp:Button ID="BtnG6" runat="server" BackColor="Green" OnClick="BtnG6_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH6" runat="server" BackColor="Green" OnClick="BtnH6_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" ForeColor="White" Text="Elije Tu Partida"></asp:Label>
            <asp:DropDownList ID="DdlPartida" runat="server">
            </asp:DropDownList>
            &nbsp;<asp:Label ID="llGu" runat="server" ForeColor="White" Text=" &quot;&quot;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">7</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnA7" runat="server" BackColor="Green" OnClick="BtnA7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB7" runat="server" BackColor="Green" OnClick="BtnB7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC7" runat="server" BackColor="Green" OnClick="BtnC7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnD7" runat="server" BackColor="Green" OnClick="BtnD7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnE7" runat="server" BackColor="Green" OnClick="BtnE7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnF7" runat="server" BackColor="Green" OnClick="BtnF7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnG7" runat="server" BackColor="Green" OnClick="BtnG7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH7" runat="server" BackColor="Green" OnClick="BtnH7_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style3">8 </span>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnA8" runat="server" BackColor="Green" OnClick="BtnA8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnB8" runat="server" BackColor="Green" OnClick="BtnB8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnC8" runat="server" BackColor="Green" OnClick="BtnC8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnD8" runat="server" BackColor="Green" OnClick="BtnD8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnE8" runat="server" BackColor="Green" OnClick="BtnE8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnF8" runat="server" BackColor="Green" OnClick="BtnF8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnG8" runat="server" BackColor="Green" OnClick="BtnG8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
&nbsp;<asp:Button ID="BtnH8" runat="server" BackColor="Green" OnClick="BtnH8_Click" Text="&quot;&quot;" Width="69px" Enabled="False" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" ForeColor="White" Text="Turno del Jugador: "></asp:Label>
            <asp:Label ID="Label3" runat="server" ForeColor="White" Text="&quot; &quot;"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Valor de la ficha: "></asp:Label>
&nbsp;
            <asp:Label ID="LbMostraVa" runat="server" ForeColor="White" Text="&quot; &quot;"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Coloque ruta xml" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxCarga" runat="server" Visible="False"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Partida valida: "></asp:Label>
            <asp:Label ID="LabelValida" runat="server" ForeColor="White" Text="&quot;&quot;"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonGuardar" runat="server" OnClick="ButtonGuardar_Click" Text="Guardar Partida" />
&nbsp;&nbsp;
            <asp:Button ID="ButtonCargar" runat="server" OnClick="ButtonCargar_Click" Text="Cargar Partida" style="height: 26px" Visible="False" />
&nbsp;
            <asp:Button ID="ButtonSalir" runat="server" OnClick="ButtonSalir_Click" Text="Salir" Width="80px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cargar Partida" />
            &nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" ForeColor="White" Text="Tiempo J1: "></asp:Label>
            <asp:Label ID="LblT1" runat="server" ForeColor="White" Text="&quot;0&quot;"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label10" runat="server" ForeColor="White" Text="Tiempo J2 :"></asp:Label>
            <asp:Label ID="LblT2" runat="server" ForeColor="White" Text="&quot;0&quot;"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:ScriptManager ID="SM1" runat="server" />
        <asp:Timer ID="Timer1" OnTick="Timer1_tick" runat="server" Interval="1000" ></asp:Timer>
        <asp:UpdatePanel ID="upPanel" runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" />
            </Triggers>
        <ContentTemplate>
            Tiempo: <asp:Label ID="lbltiempo" runat="server" ForeColor="White"></asp:Label>
            <br />
          <asp:Label ID="LabelT2" runat="server" ForeColor="White" Text="Tiempo de jugada: "></asp:Label>
          <asp:Label ID="LabelT1" runat="server" Text="Label" ForeColor="White"></asp:Label>
        </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
