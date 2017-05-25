using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementApp.BLL;
using StudentManagementApp.DAL.Model;

namespace StudentManagementApp.UI
{
    public partial class UpdateWithSearch : System.Web.UI.Page
    {
        StudentManager aStudentManager=new StudentManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDropDownListValue();
            }
        }

        private void GetDropDownListValue()
        {
            List<Department> departments = aDepartmentManager.DepartmentList();
            DropDownList.DataSource = departments;
            DropDownList.DataTextField = "Code";
            DropDownList.DataValueField = "Id";
            DropDownList.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;
            Student aStudent = aStudentManager.GetSearchRegNo(regNo);
            if (aStudent != null)
            {
                messageLabel.Text=String.Empty;

                nameTextBox.Text = aStudent.Name;
                emailTextBox.Text = aStudent.Email;
                contactNoTextBox.Text = aStudent.ContactNo;
                //deptNameTextBox.Text = aStudent.DepartmentId.ToString();
                idHiddenField.Value = aStudent.Id.ToString();
            }
            else
            {
                GetClearTextBox();
                messageLabel.Text = "Not Found registration Number";
            }
        }

        private void GetClearTextBox()
        {
            nameTextBox.Text = String.Empty;
            emailTextBox.Text = String.Empty;
            contactNoTextBox.Text = String.Empty;
          
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Id= Convert.ToInt32(idHiddenField.Value);
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.ContactNo = contactNoTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(DropDownList.SelectedValue);

            string message = aStudentManager.GetUpdate(aStudent);
            GetClearTextBox();
            messageLabel.Text = message;                   
        }
    }
}