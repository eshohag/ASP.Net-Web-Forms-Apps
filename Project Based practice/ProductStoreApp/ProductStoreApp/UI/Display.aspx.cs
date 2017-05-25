using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductStoreApp.BLL;
using ProductStoreApp.DAL.Model;

namespace ProductStoreApp.UI
{
    public partial class Display : System.Web.UI.Page
    {
        ItemsManager aItemsManager=new ItemsManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Item> AllProduct = aItemsManager.GetAllProduct();
            showGridView.DataSource = AllProduct;
            showGridView.DataBind();

            int totalQuantity = 0;
            foreach (var Product in AllProduct)
            {
                totalQuantity += Product.Quantity;
            }
            totalQuantityTextBox.Text = totalQuantity.ToString();

            //double total = AllProduct.Sum(Quantity => Quantity.Quantity);
            //totalQuantityTextBox.Text = total.ToString();




        }
    }
}