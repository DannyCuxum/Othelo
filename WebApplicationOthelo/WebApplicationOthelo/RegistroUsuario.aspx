<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroUsuario.aspx.cs" Inherits="WebApplicationOthelo.RegistroUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Nuevo Usuario</title>
    <style>
        body {
            background-image:url('https://cutewallpaper.org/21/fondos-de-pantalla-para-pc-4k/Los-Mejores-100-Wallpapers-para-PC-Fondos-de-Pantalla.jpg');
	        position: center;
        }
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
        <tr>
            <td>
            <asp:Label Text="Usuario" runat="server" ForeColor="white"/>
            </td>
            <td colspan="2">
            <asp:textbox ID="txtUsuario" runat="server" />
            </td>
        </tr>

          <tr>
            <td>
            <asp:Label Text="Pasword" runat="server" ForeColor="white" />
            </td>
            <td colspan="2">
            <asp:textbox ID="txtPasword" runat="server" />
            </td>
        </tr>

          <tr>
            <td>
            <asp:Label Text="Nombres" runat="server" ForeColor="white"/>
            </td>
            <td colspan="2">
            <asp:textbox ID="txtNombres" runat="server" />
            </td>
        </tr>

          <tr>
            <td>
            <asp:Label Text="Apellido" runat="server"  ForeColor="white"/>
            </td>
            <td colspan="2">
            <asp:textbox ID="txtApellido" runat="server" />
            </td>
        </tr>

          <tr>
            <td>
            <asp:Label Text="Fecha de nacimiento" runat="server" ForeColor="white"/>
            </td>
            <td colspan="2">

            <asp:textbox ID="txtFecha" runat="server" Height="16px" Width="47px" />
                <asp:DropDownList ID="DropDownListDia" runat="server" Height="32px" Width="46px" CssClass="auto-style1">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>

                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>

                <asp:DropDownList ID="DropDownListMes" runat="server" Height="16px" Width="47px">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                    <asp:ListItem>4</asp:ListItem>
                    <asp:ListItem>5</asp:ListItem>
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>

            </td>
        </tr>
           <tr>
                <td  colspan="3">
                    <hr />

            </td>
           </tr>
          <tr>
            <td>
            <asp:Label Text="Pais" runat="server" ForeColor="white"/>
            </td>
            <td colspan="2">
                <asp:DropDownList ID="DropDownListPais" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="16px" Width="132px">
                    <asp:ListItem>GUA</asp:ListItem>
                    <asp:ListItem>UGA</asp:ListItem>
                    <asp:ListItem>ARE</asp:ListItem>
                    <asp:ListItem>GBR</asp:ListItem>
                    <asp:ListItem>USA</asp:ListItem>
                    <asp:ListItem>UMI</asp:ListItem>
                    <asp:ListItem>URY</asp:ListItem>
                    <asp:ListItem>VUT</asp:ListItem>
                    <asp:ListItem>VAT</asp:ListItem>
                    <asp:ListItem>VEN</asp:ListItem>
                    <asp:ListItem>VNM</asp:ListItem>
                    <asp:ListItem>WLF</asp:ListItem>
                     <asp:ListItem>ESH</asp:ListItem>
                    <asp:ListItem>YEM</asp:ListItem>
                    <asp:ListItem>ZMB</asp:ListItem>
                    <asp:ListItem>ZWE</asp:ListItem>
                    <asp:ListItem>AFG</asp:ListItem>
                    <asp:ListItem>ALA</asp:ListItem>
                    <asp:ListItem>ALB</asp:ListItem>
                    <asp:ListItem>DZA</asp:ListItem>
                    <asp:ListItem>ASM</asp:ListItem>
                    <asp:ListItem>AND</asp:ListItem>
                    <asp:ListItem>AGO</asp:ListItem>
                    <asp:ListItem>AIA</asp:ListItem>

                    <asp:ListItem>ATA</asp:ListItem>
                    <asp:ListItem>ATG</asp:ListItem>
                     <asp:ListItem>ARG</asp:ListItem>
                    <asp:ListItem>ARM</asp:ListItem>
                    <asp:ListItem>AUS</asp:ListItem>
                    <asp:ListItem>AUT</asp:ListItem>
                    <asp:ListItem>AZE</asp:ListItem>
                    <asp:ListItem>BHS</asp:ListItem>
                    <asp:ListItem>BHR</asp:ListItem>
                    <asp:ListItem>BEN</asp:ListItem>
                    <asp:ListItem>BOL</asp:ListItem>
                    <asp:ListItem>BES</asp:ListItem>
                    <asp:ListItem>BRA</asp:ListItem>
                    <asp:ListItem>CMR</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

          <tr>
            <td>
            <asp:Label Text="Correo" runat="server" ForeColor="white"/>
            </td>
            <td colspan="2">
            <asp:textbox ID="txtCorreo" runat="server" />
            </td>
        </tr>
                <tr>
            <td></td>
            <td colspan="3">
                <asp:Button ID="btnSumit" runat="server" Text="Guardar" OnClick="btnSumit_Click" />
            </td>
        </tr>
         <tr>
            <td></td>
            <td colspan="2">
                <asp:label ID="lblSuccesMessage" runat="server" Text="" ForeColor="Green" />
            </td>
        </tr>
         <tr>
            <td></td>
            <td colspan="2">
                <asp:label ID="lblErrorMessage" runat="server" Text="" ForeColor="red" />
            </td>
        </tr>
       <tr> 
            <td colspan="3">
                <asp:Button ID="btnLogut" runat="server" Text="SALIR" OnClick="btnLogut_Click" />
            </td>

        </tr>
    </table>
        </div>
    </form>
</body>
</html>
