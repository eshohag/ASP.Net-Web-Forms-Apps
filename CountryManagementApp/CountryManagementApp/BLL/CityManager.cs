using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryManagementApp.DAL.Gateway;
using CountryManagementApp.DAL.Model;

namespace CountryManagementApp.BLL
{
    public class CityManager
    {
        CityGateway aCityGateway=new CityGateway();
        public string CitySave(City aCity)
        {
            if (aCity.CityName.Length == 0 || aCity.CityAbout.Length == 0 || aCity.Location.Length==0||aCity.Weather.Length==0)
            {
                return "Fill in the Blank";
            }
            else
            {
                if (aCityGateway.IsExistingCity(aCity.CityName) == null)
                {

                    if (aCityGateway.CitySave(aCity) > 0)
                    {
                        return "Successfully Saved City Information";
                    }
                    else
                    {
                        return "faild Save City";
                    }
                }
                else
                {
                    return "Already Entered Your City " + aCity.CityName;
                }  
            }                          
        }

        public List<City> GetAllCities()
        {
            return aCityGateway.GetCityList();
        } 
       
    }
}