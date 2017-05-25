using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using FriendCircleInformation.DAL.Model;

namespace FriendCircleInformation.DAL.Gateway
{
    public class PersonGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["PersonInformation"].ConnectionString;
        public int Save(Person aPerson)
        {
            SqlConnection connection=new SqlConnection(connectionString);
            string insertQuery = "INSERT INTO Information VALUES('" + aPerson.Name + "','" + aPerson.BloodGroup + "','" + aPerson.Email + "','" + aPerson.MobileNo + "','" + aPerson.Location + "')";
            SqlCommand command=new SqlCommand(insertQuery,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Person> GetPersonList()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string selectQuery = "SELECT * FROM Information";
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Person> PersonList = new List<Person>();

            while (reader.Read())
            {
                //int id = (int)reader["ID"];
                //string name = reader["Name"].ToString();
                //string bloodGroup = reader["BloodGroup"].ToString();
                //string email = reader["Email"].ToString();
                //string mobileNo = reader["MobileNo"].ToString();
                //string location = reader["Location"].ToString();

                Person aPersonLoad = new Person();
                aPersonLoad.Name = reader["Name"].ToString();
                aPersonLoad.BloodGroup = reader["BloodGroup"].ToString();
                aPersonLoad.Email = reader["Email"].ToString();
                aPersonLoad.MobileNo = reader["MobileNo"].ToString();
                aPersonLoad.Location = reader["Location"].ToString();
                aPersonLoad.Id =(int)reader["ID"];

                PersonList.Add(aPersonLoad);
            }
            reader.Close();
            connection.Close();
            return PersonList;
        }
    }
}