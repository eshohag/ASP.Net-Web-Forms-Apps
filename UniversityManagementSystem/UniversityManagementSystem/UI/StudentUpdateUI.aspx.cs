using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityManagementSystem.BLL;
using UniversityManagementSystem.DAL.Model;

namespace UniversityManagementSystem.UI
{
    public partial class StudentUpdateUI : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;

            Student aStudent = aStudentManager.SearchStudent(regNo);

            if (aStudent == null)
            {
                nameTextBox.Text = String.Empty;
                emailTextBox.Text = String.Empty;
                contactNoTextBox.Text = String.Empty;
                departmentTextBox.Text = String.Empty;
                messageLabel.Text = "No student exist with this registration number";
            }
            else
            {
                messageLabel.Text = String.Empty;
                idHiddenField.Value = aStudent.Id.ToString();
                nameTextBox.Text = aStudent.Name;
                emailTextBox.Text = aStudent.Email;
                contactNoTextBox.Text = aStudent.ContactNo;
                //departmentTextBox.Text = aStudent.Department;
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = Convert.ToInt32(idHiddenField.Value);
            student.Name = nameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.ContactNo = contactNoTextBox.Text;
            //student.Department = departmentTextBox.Text;

            string message = aStudentManager.Update(student);

            messageLabel.Text = message;
        }
    }
}