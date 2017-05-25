using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryManagementApp.DAL.Model;

namespace CountryManagementApp.DAL.Gateway
{
    public class CityGateway:CommonGateway
    {
        public int CitySave(City aCity)
        {
            Query = "INSERT INTO City(Country, CityName, CityAbout,NoOfDwellers,Weather,Location) VALUES(@Country,@CityName,@CityAbout,@NoOfDwellers,@Weather,@Location)";
            Command = new SqlCommand(Query, Connection);

            Command.Parameters.Clear();
            Command.Parameters.Add("Country", SqlDbType.VarChar);
            Command.Parameters["Country"].Value = aCity.Country;

            Command.Parameters.Add("CityName", SqlDbType.VarChar);
            Command.Parameters["CityName"].Value = aCity.CityName;

            Command.Parameters.Add("CityAbout", SqlDbType.VarChar);
            Command.Parameters["CityAbout"].Value = aCity.CityAbout;

            Command.Parameters.Add("NoOfDwellers", SqlDbType.VarChar);
            Command.Parameters["NoOfDwellers"].Value = aCity.NoOfDwellers;

            Command.Parameters.Add("Weather", SqlDbType.VarChar);
            Command.Parameters["Weather"].Value = aCity.Weather;

            Command.Parameters.Add("Location", SqlDbType.VarChar);
            Command.Parameters["Location"].Value = aCity.Location;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            TotalCityAndDwellers(aCity);

            return rowAffected;
        }
        public void TotalCityAndDwellers(City aCity)
        {
            Query = "UPDATE Country SET TotalCity = TotalCity + '" + 1 + "', TotalDwellers = TotalDwellers +@TotalDwellers where CountryName = @CountryName";
            Command = new SqlCommand(Query, Connection);
           
            Command.Parameters.Add("TotalDwellers", SqlDbType.BigInt);
            Command.Parameters["TotalDwellers"].Value = aCity.NoOfDwellers;

            Command.Parameters.Add("CountryName", SqlDbType.VarChar);
            Command.Parameters["CountryName"].Value = aCity.Country;
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        public List<City> GetCityList()
        {
            Query = "SELECT * FROM City ORDER BY CityName ASC";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<City> CityList = new List<City>();
            while (Reader.Read())
            {
                City aCity = new City();
                aCity.Id = Convert.ToInt32(Reader["Id"]);
                aCity.CityName = Reader["CityName"].ToString();
                aCity.CityAbout = Reader["CityAbout"].ToString();
                aCity.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aCity.Country = Reader["Country"].ToString();
                aCity.Weather = Reader["Weather"].ToString();
                aCity.Location = Reader["Location"].ToString();
                CityList.Add(aCity);
            }
            Reader.Close();
            Connection.Close();
            return CityList;
        }
        public City IsExistingCity(string cityName)
        {
            Query = "SELECT * FROM City WHERE CityName=@cityName";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.Add("cityName", SqlDbType.VarChar);
            Command.Parameters["cityName"].Value = cityName;
            Connection.Open();
            Reader = Command.ExecuteReader();
            City aCity = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aCity = new City();              
                aCity.Id = Convert.ToInt32(Reader["Id"]);
                aCity.CityName = Reader["CityName"].ToString();
                aCity.CityAbout = Reader["CityAbout"].ToString();
                aCity.NoOfDwellers = Convert.ToInt32(Reader["NoOfDwellers"]);
                aCity.Country = Reader["Country"].ToString();
                aCity.Weather = Reader["Weather"].ToString();
                aCity.Location = Reader["Location"].ToString();             
            }

            Reader.Close();
            Connection.Close();
            return aCity;
        }
    }
}