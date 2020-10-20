<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cronometro.aspx.cs" Inherits="WebApplicationOthelo.Cronometro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
            </asp:Timer>
            <asp:Button ID="Button1" runat="server" Text="Button" />

        </div>
    </form>
</body>
</html>
