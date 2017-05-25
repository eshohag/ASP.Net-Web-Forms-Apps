using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeManagementApp.BLL;
using OfficeManagementApp.DAL.Model;

namespace OfficeManagementApp.UI
{
    public partial class ShowAllEmployee : System.Web.UI.Page
    {
        ManagerEmployee aManagerEmployee=new ManagerEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> aEmployees = aManagerEmployee.ShowAllEmployee();
            //showAllGridView.DataSource = aManagerEmployee.ShowAllEmployee();
            showAllGridView.DataSource = aEmployees;
            showAllGridView.DataBind();
        }     
    }
}