using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace Kolokviumski
{
    public partial class Najava : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void NajavaKopce_Click(object sender, EventArgs e)
        {
            container.Visible = true;
        }

        protected void lstZanrovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstZanrovi.SelectedIndex == 0)
            {
                chkFilmovi.Items.Clear();
                chkFilmovi.Items.Add(new ListItem("Forrest Gump", "150"));
                chkFilmovi.Items.Add(new ListItem("Good will hunting", "130"));
                chkFilmovi.Items.Add(new ListItem("A beautiful mind", "100"));
            }
            else if (lstZanrovi.SelectedIndex == 1)
            {
                chkFilmovi.Items.Clear();
                chkFilmovi.Items.Add(new ListItem("Keeping up with the Joneses", "120"));
                chkFilmovi.Items.Add(new ListItem("Good will hunting", "130"));
                chkFilmovi.Items.Add(new ListItem("Ted2", "180"));
            }
            else
            {
                chkFilmovi.Items.Clear();
                chkFilmovi.Items.Add(new ListItem("Forrest Gump", "150"));
                chkFilmovi.Items.Add(new ListItem("Good will hunting", "130"));
                chkFilmovi.Items.Add(new ListItem("A beautiful mind", "100"));
            }

        }

        protected void Kupi_Click(object sender, EventArgs e)
        {
            //lblCena.Text=
            int cena = 0;
            for (int i = 0; i < chkFilmovi.Items.Count; i++)
            {
                if (chkFilmovi.Items[i].Selected)
                {
                    int kolicina = 0;
                    int film_cena = 0;

                    if (i == 0)
                    {
                        kolicina = Convert.ToInt32(txtKolichina1.Text);
                    }
                    else if (i == 1)
                    {
                        kolicina = Convert.ToInt32(txtKolichina2.Text);
                    }
                    else if (i == 2)
                    {
                        kolicina = Convert.ToInt32(txtKolichina3.Text);
                    }
                    film_cena = Convert.ToInt32(chkFilmovi.Items[i].Value);
                    cena += film_cena * kolicina;
                }
            }
            lblCena.Text = "Вкупнaта цена изнесува "+cena.ToString()+" МКД";
        }
    }
}