using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class TestTypeSetupUI : System.Web.UI.Page
    {
        Manager manager=new Manager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowTypeNameList();
        }

        protected void saveButtonTestTypeSetup_Click1(object sender, EventArgs e)
        {
            Types aType = new Types();
            aType.TypeName = typeNameTextBox.Text;
            if (typeNameTextBox.Text!=String.Empty)
            {         
                messageLabel.Text="   ";
                messageLabel.Text = manager.SaveTypeSetup(aType);
                messageLabel.ForeColor = System.Drawing.Color.Red;
                
            }
            else
            {
             
                messageLabel.ForeColor = System.Drawing.Color.Red;
                messageLabel.Text = "Plz enter type name";

            }
            ShowTypeNameList();
        }
        public void ShowTypeNameList()
        {
            List<Types> aTypes = manager.GetAllTypeNames();

            typeNameGridView.DataSource = aTypes;
            typeNameGridView.DataBind();
        }
    }
}