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
    public partial class Show_All : System.Web.UI.Page
    {
        StudentManager aStudentManager=new StudentManager();
        DepartmentManager aDepartmentManager = new DepartmentManager();
        StudentVmManager aStudentVmManager=new StudentVmManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowGridView();
            ShowViewModelGrideView();
        }

        private void ShowViewModelGrideView()
        {
            GridViewVMStudent.DataSource = aStudentVmManager.GetListOfStudentVms();
            GridViewVMStudent.DataBind();
        }

        private void ShowGridView()
        {
            showAllStudentGridView.DataSource = aStudentManager.aStudentOfList();
            showAllStudentGridView.DataBind();
        }

        protected void deleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton aDeleteLinkButton=sender as LinkButton;
            DataControlFieldCell cell=aDeleteLinkButton.Parent as DataControlFieldCell;
            GridViewRow selectRow=cell.Parent as GridViewRow;
            HiddenField selectedHiddenField=selectRow.FindControl("idHiddenField") as HiddenField;
            int id = Convert.ToInt32(selectedHiddenField.Value);
            string rowAffected=aStudentManager.GetDeleteRow(id);
            ShowGridView();
            ShowViewModelGrideView();
            messageLabel.Text = rowAffected;

        }
         protected void updateLinkButton_Click(object sender, EventArgs e)
        {
             LinkButton updateButton=sender as LinkButton;
             DataControlFieldCell cell=updateButton.Parent as DataControlFieldCell;
             GridViewRow selectedRow=cell.Parent as GridViewRow;
             HiddenField selecteHiddenField=selectedRow.FindControl("idHiddenField") as HiddenField;
             int id = Convert.ToInt32(selecteHiddenField.Value);
             Response.Redirect("Update.aspx?id="+id);
          
        }

        
    }
}