using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kolokviumski
{
    public partial class _24 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Komedija_Click(object sender, EventArgs e)
        {
            Response.Redirect("24.2.aspx/?catId=1&name=comedy");
        }

        protected void Akcija_Click(object sender, EventArgs e)
        {
            Response.Redirect("24.2.aspx/?catId=2&name=action");
        }

        protected void NaucnaFantastika_Click(object sender, EventArgs e)
        {
            Response.Redirect("24.2.aspx/?catId=3&name=science_fiction");
        }
    }
}