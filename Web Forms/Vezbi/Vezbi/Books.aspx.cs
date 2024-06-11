using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vezbi
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Dodadi_Click(object sender, EventArgs e)
        {
            Knigi.Items.Add(new ListItem(Ime.Text,Cena.Text));
        }

        protected void Izbrisi_Click(object sender, EventArgs e)
        {
            Knigi.Items.Remove(Knigi.SelectedItem);
            CenaLabela.Text = Knigi.SelectedValue;
        }

        protected void Knigi_SelectedIndexChanged(object sender, EventArgs e)
        {
            CenaLabela.Text = Knigi.SelectedValue;
        }
    }
}