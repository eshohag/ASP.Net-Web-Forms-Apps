using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiagnosticCenterBillManagementSystemApp
{
    public partial class TestSetupUI : System.Web.UI.Page
    {
        Manager manager=new Manager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadTypeNameDropdownList();
            }
            ShowTestNameList();
        }

        protected void saveButtonTestSetup_Click(object sender, EventArgs e)
        {
            Tests aTests = new Tests();
            if (testNameTextBox.Text != "" && feeTextBox.Text != "")
            {
                aTests.TypeId = Convert.ToInt32(typeNameDropDownList.SelectedItem.Value);
                aTests.TestName = testNameTextBox.Text;
                aTests.Fee = Convert.ToInt32(feeTextBox.Text);
                messageLabel.Text = manager.SaveTestSetup(aTests);
                feeTextBox.Text = String.Empty;
                testNameTextBox.Text = String.Empty;
                ShowTestNameList();
            }
            else
            {
                feeTextBox.Text = String.Empty;
                testNameTextBox.Text = String.Empty;
                messageLabel.Text = "Plz give valid input";
            }
        }
        private void LoadTypeNameDropdownList()
        {
            List<Types> aType = manager.LoadTypeNameDropdownList();

            typeNameDropDownList.DataTextField = "TypeName";
            typeNameDropDownList.DataValueField = "Id";
            typeNameDropDownList.DataSource = aType;
            typeNameDropDownList.DataBind();
        }


        private void ShowTestNameList()
        {
            List<TestView> testView = manager.GetAllTestNames();

            testNameGridView.DataSource = testView;
            testNameGridView.DataBind();
        }
    }
}