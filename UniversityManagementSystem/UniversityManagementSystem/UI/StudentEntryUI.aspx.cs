using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagementSystem.BLL;
using UniversityManagementSystem.DAL.Model;

namespace UniversityManagementSystem.UI
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Department> departments = aDepartmentManager.GetAllDepartments();

                departmentDropDownList.DataSource = departments;
                departmentDropDownList.DataTextField = "Code";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }
        }
        
        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.ContactNo = contactNoTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);

            messageLabel.Text = aStudentManager.Save(aStudent);
        }
    }
}