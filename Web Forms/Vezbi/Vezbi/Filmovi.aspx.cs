using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vezbi
{
    public partial class Filmovi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Retrieve ListBox items from session variable
                ListItemCollection items = (ListItemCollection)Session["ListBoxItems"];

                // Populate ListBox2 with the same items
                foreach (ListItem item in items)
                {
                    ListBox2.Items.Add(item);
                }
            }
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}