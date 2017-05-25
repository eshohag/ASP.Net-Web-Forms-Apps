using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryManagementApp.BLL;
using CountryManagementApp.DAL.Model;

namespace CountryManagementApp
{
    public partial class EntryCity : System.Web.UI.Page
    {
        CountryManager aCountryManager = new CountryManager();
        CityManager aCityManager=new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Country> AllCountry = aCountryManager.GetCountryList();
                countryDropDownList.DataSource = AllCountry;
                countryDropDownList.DataTextField = "CountryName";
                countryDropDownList.DataBind();
                countryDropDownList.Items.Insert(0, new ListItem("--Select Country--", "0"));

                CityEntryShowGridView();
            }
          
        }

        private void CityEntryShowGridView()
        {
            CityEntryGridView.DataSource = aCityManager.GetAllCities();
            CityEntryGridView.DataBind();
        }

        protected void saveCityButton_Click(object sender, EventArgs e)
        {
            City aCity=new City();
            aCity.Country = countryDropDownList.SelectedItem.Text;
            aCity.CityName = nameTextBox.Text;
            aCity.CityAbout = CKEditor1.Text;
            aCity.NoOfDwellers = Convert.ToInt32(noOfDwellersTextBox.Text);
            aCity.Weather = weathersTextBox.Text;
            aCity.Location = locationTextBox.Text;
           
            messageLabel.Text = aCityManager.CitySave(aCity);

            CityEntryShowGridView();

            CKEditor1.Text = String.Empty;
            //countryDropDownList.Items.Clear(); 
            noOfDwellersTextBox.Text=String.Empty;
            weathersTextBox.Text=String.Empty;
            locationTextBox.Text=String.Empty;

        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void CityEntryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CityEntryGridView.PageIndex = e.NewPageIndex;

            CityEntryShowGridView();
        }
    }
}