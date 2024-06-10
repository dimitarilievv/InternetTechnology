using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kolokviumski
{
    public partial class _24__2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] comedy =
                {
                    "Superbad",
                    "The Hangover",
                    "Anchorman: The Legend of Ron Burgundy",
                    "Bridesmaids",
                    "Dumb and Dumber"
                };
                string[] action =
                {
                    "21 Jump Street",
                    "Deadpool",
                    "Hot Fuzz",
                    "Rush Hour",
                    "Men in Black"
                };
                string[] science =
                 {
                    "Men in Black",
                    "Guardians of the Galaxy",
                    "Spaceballs",
                    "Galaxy Quest",
                    "The Hitchhiker's Guide to the Galaxy"
                };

                Name.Text = Request.QueryString.Get("name");
                switch (Convert.ToInt32(Request.QueryString.Get("catId")))
                {
                    case 1:
                        Titles.DataSource= comedy;
                        break;
                    case 2:
                        Titles.DataSource = action;
                        break;
                    case 3:
                        Titles.DataSource = science;
                        break;
                }
                Titles.DataBind();
            }
        }
    }
}