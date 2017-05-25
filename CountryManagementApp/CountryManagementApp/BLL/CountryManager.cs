using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryManagementApp.DAL.Gateway;
using CountryManagementApp.DAL.Model;

namespace CountryManagementApp.BLL
{
    public class CountryManager
    {
        CountryGateway aCountryGateway=new CountryGateway();
        public string CountrySave(Country aCountry)
        {     
            if (aCountryGateway.IsExistingCountry(aCountry.CountryName) == null)
            {
                if ( aCountry.CountryName.Length==0 ||aCountry.CountryName.Length == 0 || aCountry.CountryAbout.Length == 0 )
                {
                    return "Fill In the Balank";
                }
                else
                {
                    if (aCountry.CountryAbout.Length == 0)
                    {
                        return "Fill In the Balank About Text Field";
                    }
                    else
                    {
                        if (aCountryGateway.CountrySave(aCountry) > 0)
                        {
                            return "Successfully Saved";
                        }
                        else
                        {
                            return "Faild Save";
                        }  
                    }         
                }               
            }
            else
            {
                return aCountry.CountryName + " Has Already Entered  ";
            }
        }
        public List<Country> GetCountryList()
        {
            return aCountryGateway.GetCountryList();
        }

        public List<Country> GetAllCountriesBySearch(string name)
        {
            return aCountryGateway.GetAllCountriesBySearch(name);
        }
    }
}