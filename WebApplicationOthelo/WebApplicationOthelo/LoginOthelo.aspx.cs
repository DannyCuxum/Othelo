using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationOthelo
{
    public partial class LoginOthelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelErrorMessage.Visible = false;

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-SF8NTQGS;initial Catalog=LoginOthelo;integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM UsuarioJugador WHERE Usuario=@username AND pasword=@pasword";
                SqlCommand sqlcmd = new SqlCommand(query, sqlCon);
                sqlcmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@pasword", txtPasword.Text.Trim());
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = txtUserName.Text.Trim();
                    Session.Abandon();
                    Response.Redirect("OpcionesTipoPartida.aspx");
                }
                else
                {
                    LabelErrorMessage.Visible = true;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("RegistroUsuario.aspx");

        }
    }
}