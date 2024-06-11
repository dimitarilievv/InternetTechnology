using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalenProektt
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cart"] != null)
                {
                    int vkupno = 0;
                    ArrayList list;
                    list = (ArrayList)Session["cart"];
                    cart1.DataSource = list;
                    cart1.DataBind();
                    foreach (ListItem i in list)
                    {
                        vkupno += Convert.ToInt32(i.Value);
                    }
                    total.Text = vkupno.ToString();
                }
            }
          
        }


        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Koli.aspx");
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            
            cart1.Items.Remove(cart1.SelectedItem);
        }
    }
}