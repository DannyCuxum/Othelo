using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationOthelo
{
    public partial class OpcionesTipoPartida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPc_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonVs_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("TableroJuego.aspx");
        }
    }
}