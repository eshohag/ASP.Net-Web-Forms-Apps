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
    public partial class SaveUI : System.Web.UI.Page
    {
        ItemsManager aItemsManager=new ItemsManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Item aItem=new Item();
            aItem.Code = codeTextBox.Text;
            aItem.Description = descriptionTextBox.Text;
            aItem.Quantity = Convert.ToInt32(quantityTextBox.Text);

            messageLabel.Text = aItemsManager.Save(aItem);
        }
    }
}