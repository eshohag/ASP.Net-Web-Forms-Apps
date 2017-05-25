using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryManagementApp.DAL.Model;

namespace CountryManagementApp.DAL.Gateway
{
    public class CountryGateway:CommonGateway
    {
        public int CountrySave(Country aCountry)
        {
            Query = "INSERT INTO Country(CountryName, CountryAbout,TotalCity,TotalDwellers)  VALUES (@CountryName,@CountryAbout,@TotalCity,@TotalDwellers)";
            Command=new SqlCommand(Query,Connection);
            
            Command.Parameters.Clear();
            Command.Parameters.Add("CountryName", SqlDbType.VarChar);
            Command.Parameters["CountryName"].Value = aCountry.CountryName;
            Command.Parameters.Add("CountryAbout", SqlDbType.VarChar);
            Command.Parameters["CountryAbout"].Value = aCountry.CountryAbout;
            Command.Parameters.Add("TotalCity", SqlDbType.Int);
            Command.Parameters["TotalCity"].Value = 0;
            Command.Parameters.Add("TotalDwellers", SqlDbType.BigInt);
            Command.Parameters["TotalDwellers"].Value = 0;
            ////Command.Parameters.AddWithValue("@TotalCity", 0);
            ////Command.Parameters.AddWithValue("@TotalDwellers", 0);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public Country IsExistingCountry(string countryName)
        {
            Query = "SELECT * FROM Country WHERE CountryName=@countryName";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.Add("countryName", SqlDbType.VarChar);
            Command.Parameters["countryName"].Value = countryName;
            Connection.Open();
            Reader = Command.ExecuteReader();
            Country aCountry = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aCountry = new Country();
                aCountry.Id = Convert.ToInt32(Reader["Id"]);
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.CountryAbout = Reader["CountryAbout"].ToString();


            }

            Reader.Close();
            Connection.Close();
            return aCountry;
        }

        public List<Country> GetCountryList()
        {
            Query = "SELECT * FROM Country ORDER BY CountryName ASC";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Country> CountryList = new List<Country>();
            while (Reader.Read())
            {
                Country aCountry = new Country();
                aCountry = new Country();
                aCountry.Id = Convert.ToInt32(Reader["Id"]);
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.CountryAbout = Reader["CountryAbout"].ToString();
                aCountry.TotalCity = Convert.ToInt32(Reader["TotalCity"]);
                aCountry.TotalDwellers = Convert.ToInt32(Reader["TotalDwellers"]);
                CountryList.Add(aCountry);
            }
            Reader.Close();
            Connection.Close();
            return CountryList;
        }

        public List<Country> GetAllCountriesBySearch(string name)
        {
            Query = "SELECT * FROM Country WHERE CountryName LIKE '%" + @name + "%'";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.Add("name", SqlDbType.VarChar);
            Command.Parameters["name"].Value = name;
            
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Country> CountryList = new List<Country>();
            while (Reader.Read())
            {
                Country aCountry = new Country();
                aCountry = new Country();
                aCountry.Id = Convert.ToInt32(Reader["Id"]);
                aCountry.CountryName = Reader["CountryName"].ToString();
                aCountry.CountryAbout = Reader["CountryAbout"].ToString();
                aCountry.TotalCity = Convert.ToInt32(Reader["TotalCity"]);
                aCountry.TotalDwellers = Convert.ToInt32(Reader["TotalDwellers"]);
                CountryList.Add(aCountry);
            }
            Reader.Close();
            Connection.Close();
            return CountryList;
        }
    }
}