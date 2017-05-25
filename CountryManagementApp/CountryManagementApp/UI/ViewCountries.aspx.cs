using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryManagementApp.BLL;
using CountryManagementApp.DAL.Model;
using CountryManagementApp.DAL.ViewModel_VM_;

namespace CountryManagementApp
{
    public partial class ViewCountries : System.Web.UI.Page
    {
        
        CountryManager aCountryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllCountriesInfo();
            }
        }

        private void GetAllCountriesInfo()
        {
            ViewCountriesGridView.DataSource = aCountryManager.GetCountryList();
            ViewCountriesGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = countryNameTextBox.Text;
            List<Country> all = aCountryManager.GetAllCountriesBySearch(name);
            if (all.Count == 0)
            {
                messageLabel.Text = "Not Found";
            }
            else
            {
                messageLabel.Text = String.Empty;
                ViewCountriesGridView.DataSource = all;
                ViewCountriesGridView.DataBind();
            }
        }

        protected void ViewCountriesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ViewCountriesGridView.PageIndex = e.NewPageIndex;
            GetAllCountriesInfo();
        }
    }
}