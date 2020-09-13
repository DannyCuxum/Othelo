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
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clear();

            }

        }
        
        protected void btnSumit_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtCorreo.Text == "" || txtApellido.Text=="" || txtUsuario.Text=="" || txtPasword.Text=="" )
                lblErrorMessage.Text = "Favor de llenar los campos";
            else
            {
               
                    using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-SF8NTQGS;initial Catalog=LoginOthelo;integrated Security=True;"))
                    {
                    
                        SqlCommand sqlcmd = new SqlCommand("CreacionUsuarioNuevo", sqlCon);

                        sqlCon.Open();
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@pasword", txtPasword.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@Nombres", txtNombres.Text.Trim());

                        sqlcmd.Parameters.AddWithValue("@Apellidos", txtApellido.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@FechaNacimiento", txtFecha.Text.Trim()+"-"+DropDownListMes.SelectedValue+"-"+ DropDownListDia.SelectedValue);

                        sqlcmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());

                        sqlcmd.Parameters.AddWithValue("@Pais", DropDownListPais.SelectedValue);
                        sqlcmd.ExecuteNonQuery();
                        clear();
                        lblSuccesMessage.Text = "Suscrito";




                    
                }
            }
        }

        void clear()
        {
            txtUsuario.Text = txtPasword.Text = txtNombres.Text = txtApellido.Text = txtCorreo.Text = txtFecha.Text="";
            lblSuccesMessage.Text = lblErrorMessage.Text = "";
        }

        protected void btnLogut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginOthelo.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}