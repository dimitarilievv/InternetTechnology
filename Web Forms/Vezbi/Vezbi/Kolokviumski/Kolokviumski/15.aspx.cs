using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kolokviumski
{
    public partial class _15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] items_title =
                {
                    "Album 1",
                    "Album 2",
                    "Album 3",
                    "Album 4",
                    "Album 5"
                };
                string[] items_price =
                {
                    "45","60","20","55","50"
                };
                // lbItems.DataSource = items_title;
                // lbItems.DataBind();
                for (var i = 0; i < items_title.Length; i++)
                {
                    itemTitle.Items.Add(new ListItem(items_title[i]));
                }
                for (var i = 0; i < items_price.Length; i++)
                {
                    itemPrice.Items.Add(new ListItem(items_price[i]));
                }

            }
        }
    }
}