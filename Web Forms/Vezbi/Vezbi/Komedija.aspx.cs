using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vezbi
{
    public partial class Komedija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Filmovi.Items.Add(new ListItem("This is Spinal Tap"));
                Filmovi.Items.Add(new ListItem("Airplane!"));
                Filmovi.Items.Add(new ListItem("Annie Hall!"));
                Filmovi.Items.Add(new ListItem("Duck Soup"));

                Ceni.Items.Add("200");
                Ceni.Items.Add("500");
                Ceni.Items.Add("300");
                Ceni.Items.Add("700");

                Session["ListBoxItems"] = Kosnica.Items;
            }
           
        }

        protected void Filmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ceni.SelectedIndex = Filmovi.SelectedIndex;
        }

        protected void Dodadi_Click(object sender, EventArgs e)
        {
            Kosnica.Items.Add(new ListItem(Filmovi.SelectedValue.ToString()));
        }
    }
}