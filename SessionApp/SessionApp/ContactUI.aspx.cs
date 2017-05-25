using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionApp
{
    public partial class ContactUI : System.Web.UI.Page
    {
        private Contact aContact;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goToHomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomeUI.aspx");
        }

        protected void showInformationButton_Click(object sender, EventArgs e)
        {
            if (Session["Contact"] == null)
            {
                nameLabel.Text = "Empty Session";
            }
            else
            {
                aContact = (Contact)Session["Contact"];
                string name = aContact.Name;
                string email = aContact.Email;
                string cell = aContact.CellNumber;

                nameLabel.Text = name;
                emaiLabel.Text = email;
                cellphoneLabel.Text = cell;
            }
          
        }

        protected void clearSessionButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            ////Session.RemoveAll();
            //Session.Contents.Clear();
           //// Session["userid"] = null;  only one seaaion null korte ei waya
            //Session.RemoveAt(0);
        }
    }
}