using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fiilmovi_zadaca
{
    public partial class Filmovi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] komedii =
                {
                    "Superbad",
                    "The Hangover",
                    "Anchorman: The Legend of Ron Burgundy",
                    "Bridesmaids",
                    "Dumb and Dumber"
                };
                string[] komedii_c =
                {
                    "50","55","60","100","35"
                };
                string[] akcii =
             {
                    "Superbad",
                    "The Hangover",
                    "Anchorman: The Legend of Ron Burgundy",
                    "Bridesmaids",
                    "Dumb and Dumber"
                };
                string[] akcii_c =
                {
                    "50","55","60","100","35"
                };
                string[] naucna =
             {
                    "Superbad",
                    "The Hangover",
                    "Anchorman: The Legend of Ron Burgundy",
                    "Bridesmaids",
                    "Dumb and Dumber"
                };
                string[] naucna_c =
                {
                    "50","55","60","100","35"
                };

                Kategorija.Text = Request.QueryString.Get("name");
                switch (Convert.ToInt32(Request.QueryString.Get("catId")))
                {
                    case 0:
                        Naslovi.DataSource= komedii;
                        Ceni.DataSource = komedii_c;
                        break; 
                    case 1:
                        Naslovi.DataSource = akcii;
                        Ceni.DataSource = akcii_c;
                        break;
                    case 2:
                        Naslovi.DataSource = naucna;
                        Ceni.DataSource = naucna_c;
                        break;
                };
                Naslovi.DataBind();
                Ceni.DataBind();

            }
        }

        protected void VratiSe_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kategorii.aspx");
        }

        protected void Naslovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ceni.SelectedIndex = Naslovi.SelectedIndex;
            if (ViewState["total"] == null)
            {
                ViewState["total"] = 1;
            }
            else
            {
                ViewState["total"] = Convert.ToInt32(ViewState["total"]) + 1;
            }
            Total.Text = ViewState["total"].ToString();
        }

        protected void Dodadi_Click(object sender, EventArgs e)
        {
            ArrayList lista;
            if (Session["kosnica"] == null)
            {
                lista=new ArrayList();
            }
            else
            {
                lista = (ArrayList)Session["kosnica"];
            }
            lista.Add(new ListItem(Naslovi.SelectedItem.Text,Ceni.SelectedItem.Text));
            Kosnicka.DataTextField = "Text";
            Kosnicka.DataValueField= "Value";
            Kosnicka.DataSource = lista;
            Kosnicka.DataBind();
            Session["kosnica"] = lista;
        }

        protected void PlatiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plakjanje.aspx");
        }
    }
}