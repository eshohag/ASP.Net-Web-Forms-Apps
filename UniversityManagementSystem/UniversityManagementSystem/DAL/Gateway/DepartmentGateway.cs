using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityManagementSystem.DAL.Model;

namespace UniversityManagementSystem.DAL.Gateway
{
    public class DepartmentGateway : Gateway
    {
        public List<Department> GetAllDepartments()
        {
            Query = "SELECT * FROM Departments";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while (Reader.Read())
            {
                Department department = new Department();

                department.Id = Convert.ToInt32(Reader["Id"]);
                department.Code = Reader["Code"].ToString();
                department.Name = Reader["Name"].ToString();

                departments.Add(department);
            }

            Reader.Close();
            Connection.Close();

            return departments;
        }
    }
}