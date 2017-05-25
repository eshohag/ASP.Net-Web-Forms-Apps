using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryManagementApp.BLL;
using CountryManagementApp.DAL.Model;

namespace CountryManagementApp
{
    public partial class EntryCountry : System.Web.UI.Page
    {
        CountryManager aCountryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridViewShow();             
            }
        }
      
      

        private void GridViewShow()
        {
            CountryEntryGridView.DataSource = aCountryManager.GetCountryList();
            CountryEntryGridView.DataBind();
        }

        protected void saveCountryButton_Click(object sender, EventArgs e)
        {
            Country aCountry=new Country();
            aCountry.CountryName = nameTextBox.Text;
            aCountry.CountryAbout = CKEditorControl1.Text;

            messageLabel.Text = aCountryManager.CountrySave(aCountry);
            GridViewShow();


            nameTextBox.Text=String.Empty;
            CKEditorControl1.Text=String.Empty;

        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void CountryEntryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CountryEntryGridView.PageIndex = e.NewPageIndex;
            GridViewShow();
        }

    }
}