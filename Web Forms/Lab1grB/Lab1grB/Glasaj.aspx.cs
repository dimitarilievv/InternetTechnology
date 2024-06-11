using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1grB
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListBox1.Items.Add(new ListItem("Internet tehnologii", "Goce Armenski"));
                ListBox1.Items.Add(new ListItem("Internet", "Stefan Andonov"));
                ListBox1.Items.Add(new ListItem("Diskretna matematika", "Metodija Jancevski"));

                ListBox2.Items.Add(new ListItem("6"));
                ListBox2.Items.Add(new ListItem("5.5"));
                ListBox2.Items.Add(new ListItem("5"));
            }
            
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text=ListBox1.SelectedValue.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ListBox1.SelectedIndex>=0 && ListBox2.SelectedIndex >= 0)
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            ListBox1.Items.Add(PredmetTextBox.Text);
            ListBox2.Items.Add(KreditiTextBox.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
            ListBox2.Items.Remove(ListBox2.SelectedItem);
        }
    }
}