using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using OfficeManagementApp.DAL.Model;

namespace OfficeManagementApp.DAL.Gateway
{
    public class EmployeeGateway
    {
        private string connectionString =WebConfigurationManager.ConnectionStrings["OfficeManagementDB"].ConnectionString;
       
        public int Save(Employee aEmployee)
        {
            SqlConnection connection =new SqlConnection(connectionString);
            string query = "INSERT INTO Employee VALUES('" + aEmployee.Name + "','" + aEmployee.Position + "','" +aEmployee.Salary + "','" + aEmployee.JoiningDate + "')";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Employee> ShowAllEmployee()
        {
            SqlConnection connection =new SqlConnection(connectionString);
            string query = "SELECT * FROM Employee";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Employee> listEmployee=new List<Employee>();
            while (reader.Read())
            {
                Employee aEmployeeList=new Employee();
                aEmployeeList.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                aEmployeeList.Name = reader["Name"].ToString();
                aEmployeeList.Position = reader["Position"].ToString();
                aEmployeeList.Salary = reader["Salary"].ToString();
                aEmployeeList.JoiningDate = reader["JoiningDate"].ToString();

                listEmployee.Add(aEmployeeList);
            }
            reader.Close();
            connection.Close();
            return listEmployee;
        }

        public Employee SearchEmployee(int idNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Employee WHERE EmployeeID='"+idNo+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader reader= command.ExecuteReader();

            Employee aEmployee = null;

            if (reader.HasRows)
            {
                reader.Read();
                aEmployee = new Employee();
                aEmployee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                aEmployee.Name = reader["Name"].ToString();
                aEmployee.Position = reader["Position"].ToString();
                aEmployee.Salary = reader["Salary"].ToString();
                aEmployee.JoiningDate = reader["JoiningDate"].ToString();

            }

            reader.Close();
            connection.Close();
            return aEmployee;
        }


        public int Update(Employee aEmployee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "UPDATE Employee SET Name='" + aEmployee.Name + "',Position='" + aEmployee.Position +
                           "',Salary='" + aEmployee.Salary + "',JoiningDate='" + aEmployee.JoiningDate + "' WHERE EmployeeID='"+aEmployee.EmployeeID+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}