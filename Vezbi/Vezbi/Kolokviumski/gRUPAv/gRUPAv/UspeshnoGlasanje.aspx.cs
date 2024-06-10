using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gRUPAv
{
    public partial class _UspeshnoGlasanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             email.Text = Session["email"].ToString();
             ime.Text = Session["ime"].ToString();
            predmet.Text = Session["predmet"].ToString();

        }
    }
}