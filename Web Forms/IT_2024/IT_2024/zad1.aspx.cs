using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_2024
{
    public partial class zad1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumbitDestinationClick(object sender, EventArgs e)
        {
           // var selectedDestination = Destinations.SelectedItem;
            var allDestinations = Destinations.Items;
            foreach (ListItem dest in allDestinations)
            {
                if (dest != null)
                {
                    if (dest.Selected)
                        SelectedDestinationLabel.Text += "Селектираната дестинација е: " + dest.Text + " и растојанието до Скопје е: " + dest.Value + " km" + "<br/>";
                }
                else
                {
                    SelectedDestinationLabel.Text = "Немате селектирано!";
                }  

            }
           
       
        }
    }
}