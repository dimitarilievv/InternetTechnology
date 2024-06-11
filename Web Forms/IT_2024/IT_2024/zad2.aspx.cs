using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IT_2024
{
    public partial class zad2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitResults_Click(object sender, EventArgs e)
        {
            var name = CurrencyName.Text;
            var value= CurrencyValue.Text;
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(value))
            {
                allCurrencies.Items.Add(new ListItem(name, value));
                CurrencyName.Text = "";
                CurrencyValue.Text = "";

                Counter.Text=allCurrencies.Items.Count.ToString();
            }
        }

        protected void RemoveItem_Click(object sender, EventArgs e)
        {
            var selectedItem = allCurrencies.SelectedItem;
            if(selectedItem != null)
            {
                allCurrencies.Items.Remove(selectedItem);
                Counter.Text = allCurrencies.Items.Count.ToString();
            }
        }
    }
}