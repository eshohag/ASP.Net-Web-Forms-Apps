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
    public partial class IndexUI : System.Web.UI.Page
    {
        StudentManager aStudentManager=new StudentManager();
        DepartmentManager aDepartmentManager=new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = aDepartmentManager.DepartmentList();
                deptDropDownList.DataSource = departments;
                deptDropDownList.DataTextField = "Code";
                deptDropDownList.DataValueField = "Id";
                deptDropDownList.DataBind();
            }
           

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.Name = nameTextBox.Text;
            aStudent.RegNo = regNoTextBox3.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.ContactNo = contactNumberTextBox1.Text;
            aStudent.DepartmentId = Convert.ToInt32(deptDropDownList.SelectedValue);         

            string message = aStudentManager.Save(aStudent);
            messageLabel.Text = message;
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAll.aspx");
        }

        protected void showAllStudentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAll.aspx");
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}