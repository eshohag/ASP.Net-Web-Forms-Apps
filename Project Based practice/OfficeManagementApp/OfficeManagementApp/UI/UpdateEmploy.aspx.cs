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
    public partial class UpdateEmploy : System.Web.UI.Page
    {
        ManagerEmployee aManagerEmployee=new ManagerEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTextBox.Text);
            Employee message = aManagerEmployee.GetSearchEmployee(id);
           
            if (message!= null)
            {
                nameTextBox.Text = message.Name;
                positionTextBox.Text = message.Position;
                salaryTextBox.Text = message.Salary;
                joiningdateTextBox.Text = message.JoiningDate;
                 messageLabel.Text =String.Empty;
            }          
            else
            {
                nameTextBox.Text = String.Empty;
                positionTextBox.Text = String.Empty;
                salaryTextBox.Text = String.Empty;
                joiningdateTextBox.Text = String.Empty;
                messageLabel.Text = "Faild Search";
            }      
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.EmployeeID = Convert.ToInt32(idTextBox.Text);
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Position = positionTextBox.Text;
            aEmployee.Salary = salaryTextBox.Text;
            aEmployee.JoiningDate = joiningdateTextBox.Text;


            messageLabel.Text = aManagerEmployee.Update(aEmployee);
         
            nameTextBox.Text=String.Empty;
            positionTextBox.Text=String.Empty;
            salaryTextBox.Text=String.Empty;
            joiningdateTextBox.Text=String.Empty; 
            idTextBox.Text=String.Empty;
        }
    }
}