using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fiilmovi_zadaca
{
    public partial class Kategorii : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Komedija_Click(object sender, EventArgs e)
        {
            Response.Redirect("Filmovi.aspx?catId=0&name=Komedija");
        }

        protected void Akcija_Click(object sender, EventArgs e)
        {
            Response.Redirect("Filmovi.aspx?catId=1&name=Akcija");
        }

        protected void NaucnaFantastika_Click(object sender, EventArgs e)
        {
            Response.Redirect("Filmovi.aspx?catId=2&name=Naucna+fantasika");
        }
    }
}