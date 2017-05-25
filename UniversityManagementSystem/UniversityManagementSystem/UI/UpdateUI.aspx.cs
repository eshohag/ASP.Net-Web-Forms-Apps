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
    public partial class UpdateUI : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                Student student = aStudentManager.GetStudentById(id);

                if (student != null)
                {
                    LoadFormWithStudent(student);
                }
            }
        }

        private void LoadFormWithStudent(Student student)
        {
            idHiddenField.Value = student.Id.ToString();
            regNoTextBox.Text = student.RegNo;
            nameTextBox.Text = student.Name;
            emailTextBox.Text = student.Email;
            contactNoTextBox.Text = student.ContactNo;
            //departmentTextBox.Text = student.Department;
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if (idHiddenField.Value != "")
            {
                student.Id = Convert.ToInt32(idHiddenField.Value);
            }
            student.Name = nameTextBox.Text;
            student.Email = emailTextBox.Text;
            student.ContactNo = contactNoTextBox.Text;
            //student.Department = departmentTextBox.Text;

            string message = aStudentManager.Update(student);

            messageLabel.Text = message;
        }
    }
}