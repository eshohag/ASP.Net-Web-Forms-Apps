using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryManagementApp.DAL.Gateway;
using CountryManagementApp.DAL.ViewModel_VM_;

namespace CountryManagementApp.BLL
{
    public class CitiesViewModelManager
    {
        CitiesViewModelGateway aCitiesViewModelGateway=new CitiesViewModelGateway();

        public List<CitiesViewModel> GetAllListVM(string cityName)
        {
            return aCitiesViewModelGateway.GetCityList(cityName);
        }

        public List<CitiesViewModel> GetCountryCityVms(string country)
        {
            return aCitiesViewModelGateway.GetCountryList(country);
        }

        public List<CitiesViewModel> GetAllCitiesVM()
        {
            return aCitiesViewModelGateway.GetAllCities();
        }
    }
}