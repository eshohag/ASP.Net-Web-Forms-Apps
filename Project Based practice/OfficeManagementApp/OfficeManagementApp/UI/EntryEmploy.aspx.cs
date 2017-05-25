using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeManagementApp.BLL;
using OfficeManagementApp.DAL.Model;

namespace OfficeManagementApp.UI
{
    public partial class EntryEmploy : System.Web.UI.Page
    {
        ManagerEmployee aManagerEmployee=new ManagerEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee=new Employee();
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Position = positionTextBox.Text;
            aEmployee.Salary = salaryTextBox.Text;
            aEmployee.JoiningDate = joiningdateTextBox.Text;
            //messageLabel.Text =aManagerEmployee.Save(aEmployee);
            if (aManagerEmployee.Save(aEmployee) > 0)
            {
                messageLabel.Text = "Successfully Saved";
                nameTextBox.Text = String.Empty;
                positionTextBox.Text = String.Empty;
                salaryTextBox.Text = String.Empty;
                joiningdateTextBox.Text = String.Empty;
            }
            else
            {
                messageLabel.Text = "Faild Save";
            }
        }
    }
}