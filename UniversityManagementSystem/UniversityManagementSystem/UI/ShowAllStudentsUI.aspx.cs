using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityManagementSystem.BLL;
using UniversityManagementSystem.DAL.Model;
using UniversityManagementSystem.DAL.ViewModel;

namespace UniversityManagementSystem.UI
{
    public partial class ShowAllStudentsUI : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateStudentsGridView();
        }

        protected void deleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton deleteButton = sender as LinkButton;

            DataControlFieldCell cell = deleteButton.Parent as DataControlFieldCell;

            GridViewRow selectedRow = cell.Parent as GridViewRow;

            HiddenField selectedHiddenField = selectedRow.FindControl("idHiddenField") as HiddenField;

            int id = Convert.ToInt32(selectedHiddenField.Value);

            string message = aStudentManager.Delete(id);

            Response.Write(message);

            PopulateStudentsGridView();
        }

        protected void updateLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton updateButton = sender as LinkButton;

            DataControlFieldCell cell = updateButton.Parent as DataControlFieldCell;

            GridViewRow selectedRow = cell.Parent as GridViewRow;

            HiddenField selectedHiddenField = selectedRow.FindControl("idHiddenField") as HiddenField;

            int id = Convert.ToInt32(selectedHiddenField.Value);

            Response.Redirect("UpdateUI.aspx?id=" + id);
        }

        private void PopulateStudentsGridView()
        {
            List<StudentViewModel> students = aStudentManager.GetAllStudents();

            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }
    }
}