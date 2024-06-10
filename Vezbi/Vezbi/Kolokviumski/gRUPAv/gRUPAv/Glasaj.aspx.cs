using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gRUPAv
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbPredmeti.Items.Add(new ListItem("Internet Tehnologii","Prof d-r Goce Armenski"));
                lbPredmeti.Items.Add(new ListItem("Internet", "Prof d-r Metodija Janceski"));
                lbPredmeti.Items.Add(new ListItem("Digitalna Elektronika", "Prof d-r Saso Gramatikov"));

                lbKrediti.Items.Add(new ListItem("6"));
                lbKrediti.Items.Add(new ListItem("5.5"));
                lbKrediti.Items.Add(new ListItem("5"));
            }

        }

        protected void kopce_Click(object sender, EventArgs e)
        {
            Response.Redirect("UspeshnoGlasanje.aspx");
            List<string> mails = (List<string>)Session["Mail"];
            string thisMail = (String)Session["ThisMail"];
            if (mails == null || !mails.Contains(thisMail))
            {
                mails = new List<string>();
                mails.Add(thisMail);
                Session["Mail"] = mails;
                Response.Redirect("Glasaj.aspx");

            }
            else
            {
                lblProfesor.Text = "Vekje imate glasano";
                Task.Delay(5000);
                Response.Redirect("Lab1_V.aspx");
            }

        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;
            lblProfesor.Text=lbPredmeti.SelectedValue;
            Session["predmet"]=lbPredmeti.SelectedItem;
        }

        protected void Dodadi_Click(object sender, EventArgs e)
        {
            lbPredmeti.Items.Add(predmet.Text);
            lbKrediti.Items.Add(krediti.Text);
        }

        protected void Izbrisi_Click(object sender, EventArgs e)
        {
            lbPredmeti.Items.Remove(lbPredmeti.SelectedItem);
            lbKrediti.Items.Remove(lbKrediti.SelectedItem);
            predmet.Text = "";
            krediti.Text = "";
        }
    }
}