using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gRUPAv
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kopce_Click(object sender, EventArgs e)
        {
            ListItem l=new ListItem(ime.Text, email.Text);
            if (!istiMailovi.Items.Contains(l))
            {
                istiMailovi.Items.Add(l);
                Session["email"] = email.Text;
                Session["ime"] = ime.Text;
                Response.Redirect("Glasaj.aspx");
            }
            else
            {
                veke.Text = "Veke ste glasale!";
            }
            

            
            
            
        }
    }
}