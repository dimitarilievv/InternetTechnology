using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalenProektt
{
    public partial class Koli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                ArrayList list;
                if (Session["cart"] != null)
                {
                    list = (ArrayList)Session["cart"];
                    cart.DataSource = list;
                    cart.DataBind();
                }
                carName.Text = Request.QueryString["name"];

                string[] bmwModels =
                {
                    "BMW 3 Series",
                    "BMW 5 Series",
                    "BMW X5"
                };
                string[] bmwPrice =
                {
                    "100000",
                    "200000",
                    "150000"
                };
                string[] audiModels =
                {
                    "Audi A4",
                    "Audi Q5",
                    "Audi A6"
                };
                string[] audiPrice =
               {
                    "120000",
                    "250000",
                    "150000"
                };
                string[] mercedesModels =
                {
                    "Mercedes-Benz C-Class",
                    "Mercedes-Benz E-Class",
                    "Mercedes-Benz GLE-Class"
                };
                string[] mercedesPrice =
               {
                    "220000",
                    "150000",
                    "90000"
                };

                int index = Convert.ToInt32(Request.QueryString["catId"]);
                if (index == 0)
                {
                    modelCar.DataSource= bmwModels;
                    priceCar.DataSource = bmwPrice;

                }
                else if(index == 1)
                {
                    modelCar.DataSource = audiModels;
                    priceCar.DataSource = audiPrice;
                }
                else if (index == 2)
                {
                    modelCar.DataSource = mercedesModels;
                    priceCar.DataSource = mercedesPrice;
                }

                modelCar.DataBind();
                priceCar.DataBind();
            }
        }

        protected void modelCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceCar.SelectedIndex = modelCar.SelectedIndex;
            if (ViewState["counter"] == null)
            {
                ViewState["counter"] = 1;
                total.Text = ViewState["counter"].ToString();
            }
            else
            {
                ViewState["counter"] = Convert.ToInt32(ViewState["counter"])+1;
                total.Text = ViewState["counter"].ToString();
            }
        }

        protected void addModel_Click(object sender, EventArgs e)
        {
            ArrayList list;
            cart.Visible = true;
            if (Session["cart"] == null)
            {
                list=new ArrayList();
            }
            else
            {
                list = (ArrayList)Session["cart"];
            }
            list.Add(new ListItem(modelCar.SelectedItem.Text,priceCar.SelectedItem.Text));
            cart.DataSource= list;
            cart.DataBind();
            Session["cart"] = list;
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Opcii.aspx");
        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}