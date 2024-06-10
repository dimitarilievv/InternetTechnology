using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fiilmovi_zadaca
{
    public partial class Plakjanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Kosnica.DataTextField = "Text";
                Kosnica.DataValueField= "Value";
                Kosnica.DataSource = (ArrayList)Session["kosnica"];
                Kosnica.DataBind();
                int totalValue = 0;
                foreach(ListItem i in Kosnica.Items)
                {
                    totalValue += Convert.ToInt32(i.Value);
                }
                Kupi.Text="Kupi ($"+totalValue.ToString()+")";
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Filmovi.aspx");
        }

        protected void Kupi_Click(object sender, EventArgs e)
        {

        }
    }
}