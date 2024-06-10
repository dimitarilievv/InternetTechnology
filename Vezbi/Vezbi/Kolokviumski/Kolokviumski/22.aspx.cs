using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kolokviumski
{
    public partial class _22 : System.Web.UI.Page
    {
        public static List<ListItem> items=new List<ListItem>();    
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            items.Add(new ListItem(TextBox1.Text, TextBox2.Text));
            showItems();
        }
        private void showItems()
        {
            if(ListBox1 != null)
            {
                foreach (ListItem item in items)
                {
                    ListBox1.Items.Add(item);
                }
            }
            
        }
    }
}