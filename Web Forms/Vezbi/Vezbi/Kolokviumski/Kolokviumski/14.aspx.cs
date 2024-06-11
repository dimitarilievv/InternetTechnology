using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kolokviumski
{
    public partial class _14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DeleteItem_Click(object sender, EventArgs e)
        {
            lbTitle.Items.RemoveAt(Convert.ToInt32(tbIndex.Text));
            lbPrice.Items.RemoveAt(Convert.ToInt32(tbIndex.Text));
        }
    }
}