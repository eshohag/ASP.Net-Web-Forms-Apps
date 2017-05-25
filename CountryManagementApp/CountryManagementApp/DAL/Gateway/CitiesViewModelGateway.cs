using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryManagementApp.DAL.Model;
using CountryManagementApp.DAL.ViewModel_VM_;

namespace CountryManagementApp.DAL.Gateway
{
    public class CitiesViewModelGateway:CommonGateway
    {
        public List<CitiesViewModel> GetCityList(string cityName)
        {
            Query = "SELECT * FROM CitiesViewModel WHERE CityName LIKE '%"+@cityName+"%'";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.Add("cityName", SqlDbType.VarChar);
            Command.Parameters["cityName"].Value = cityName;
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<CitiesViewModel> CityList = new List<CitiesViewModel>();
            while (Reader.Read())
            {
                CitiesViewModel aCitiesViewModel = new CitiesViewModel();
                aCitiesViewModel.CityName = Reader["CityName"].ToString();
                aCitiesViewModel.CityAbout = Reader["CityAbout"].ToString();
                aCitiesViewModel.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aCitiesViewModel.Location = Reader["Location"].ToString();
                aCitiesViewModel.Weather = Reader["weather"].ToString();
                aCitiesViewModel.CountryName = Reader["CountryName"].ToString();
                aCitiesViewModel.AboutCountry = Reader["CountryAbout"].ToString();
                CityList.Add(aCitiesViewModel);
            }
            Reader.Close();
            Connection.Close();
            return CityList;
        }

        public List<CitiesViewModel> GetCountryList(string country)
        {
            Query = "SELECT * FROM CitiesViewModel WHERE CountryName=@country";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.Add("country", SqlDbType.VarChar);
            Command.Parameters["country"].Value = country;
            Connection.Open();
            Reader = Command.ExecuteReader();

            List<CitiesViewModel> CountryList = new List<CitiesViewModel>();
            while (Reader.Read())
            {
                CitiesViewModel aCountry = new CitiesViewModel();
                aCountry.CityName = Reader["CityName"].ToString();
                aCountry.CityAbout = Reader["CityAbout"].ToString();
                aCountry.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aCountry.Location = Reader["Location"].ToString();
                aCountry.Weather = Reader["Weather"].ToString();
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.AboutCountry = Reader["CountryAbout"].ToString();
                CountryList.Add(aCountry);
            }
            Reader.Close();
            Connection.Close();
            return CountryList;
        }

        public List<CitiesViewModel> GetAllCities()
        {
            Query = "SELECT * FROM CitiesViewModel ORDER BY CityName ASC";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<CitiesViewModel> CountryList = new List<CitiesViewModel>();
            while (Reader.Read())
            {             
                CitiesViewModel aCountry = new CitiesViewModel();
                aCountry.CityName = Reader["CityName"].ToString();
                aCountry.CityAbout = Reader["CityAbout"].ToString();
                aCountry.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aCountry.Location = Reader["Location"].ToString();
                aCountry.Weather = Reader["Weather"].ToString();
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.AboutCountry = Reader["CountryAbout"].ToString();              
                CountryList.Add(aCountry);
            }
            Reader.Close();
            Connection.Close();
            return CountryList;
        }
    }
}