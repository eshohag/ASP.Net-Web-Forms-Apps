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
    public partial class ViewCities : System.Web.UI.Page
    {

        CountryManager aCountryManager = new CountryManager();
        CitiesViewModelManager aCitiesViewModelManager=new CitiesViewModelManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {         
                List<Country> AllCountry = aCountryManager.GetCountryList();
                CountryDropDownList.DataSource = AllCountry;
                CountryDropDownList.DataTextField = "CountryName";
                CountryDropDownList.DataBind();
                CountryDropDownList.Items.Insert(0, new ListItem("--Select Country--", "0"));

                GetAllCountries();
            }
        }

        private void GetAllCountries()
        {
            CountryEntryGridView.DataSource = aCitiesViewModelManager.GetAllCitiesVM();
            CountryEntryGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (cityNameRadioButton.Checked)
            {
                messageLabel.Text = String.Empty;
                string cityName = cityNameTextBox.Text;
                List<CitiesViewModel> GetCity = aCitiesViewModelManager.GetAllListVM(cityName);
                if (GetCity.Count == 0)
                {
                    messageLabel.Text = "Not Found Any City";
                }
                else
                {
                    CountryEntryGridView.DataSource = GetCity;
                    CountryEntryGridView.DataBind();
                }                              
            }

            else if (countryRadioButton.Checked)
            {
                messageLabel.Text = String.Empty;
                string Country = CountryDropDownList.SelectedItem.Text;
                List<CitiesViewModel> AllCountry= aCitiesViewModelManager.GetCountryCityVms(Country);
                if (AllCountry.Count == 0)
                {
                    messageLabel.Text = "Not Found Any Country";
                }
                else
                {
                    CountryEntryGridView.DataSource = AllCountry;
                    CountryEntryGridView.DataBind(); 
                }              
            }
            else
            {
                messageLabel.Text = "Please Checked ";
            }
        }

        protected void CountryEntryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CountryEntryGridView.PageIndex = e.NewPageIndex;
            GetAllCountries();
        }

         
    }
}