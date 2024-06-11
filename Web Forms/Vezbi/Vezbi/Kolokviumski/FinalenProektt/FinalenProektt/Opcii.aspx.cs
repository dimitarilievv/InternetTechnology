using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalenProektt
{
    public partial class Opcii : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbKoli.Text = "Welcome "+Session["username"].ToString()+" ,choose a car!";
            }
        }

        protected void bmw_Click(object sender, EventArgs e)
        {
            Response.Redirect("Koli.aspx?catId=0&name=Bmw");
        }

        protected void audi_Click(object sender, EventArgs e)
        {
            Response.Redirect("Koli.aspx?catId=1&name=Audi");
        }

        protected void mercedes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Koli.aspx?catId=2&name=Mercedes");
        }
    }
}