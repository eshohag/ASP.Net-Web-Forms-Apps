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
    public partial class Update : System.Web.UI.Page
    {
        StudentManager aStudentManager=new StudentManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        private int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                Student aStudent = aStudentManager.GetIdWiseStudent(id);
                nameTextBox.Text = aStudent.Name;
                emailTextBox.Text = aStudent.Email;
                contactNumberTextBox1.Text = aStudent.ContactNo;

                List<Department> departments = aDepartmentManager.DepartmentList();
                DropDownList.DataSource = departments;
                DropDownList.DataTextField = "Code";
                DropDownList.DataValueField = "Id";
                DropDownList.DataBind();
            }
          
        }
        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent=new Student();
            aStudent.Id = id;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.ContactNo = contactNumberTextBox1.Text;
            aStudent.DepartmentId = Convert.ToInt32(DropDownList.SelectedValue);

           string message=aStudentManager.GetUpdate(aStudent);
            messageLabel.Text = message;
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void showAllStudentButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowAll.aspx");
        }

       
    }
}