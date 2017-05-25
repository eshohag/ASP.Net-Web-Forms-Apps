using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionApp
{
    public partial class HomeUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Contact aContact=new Contact();
            aContact.Name = nameTextBox.Text;
            aContact.Email = emailNumberTextBox.Text;
            aContact.CellNumber = cellNumberTextBox.Text;
            Session["Contact"] = aContact;
        }

        protected void goToNextPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUI.aspx");
        }
    }
}