using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentManagementApp.DAL.Model;

namespace StudentManagementApp.DAL.Gateway
{
    public class DepartmentGateway:CommonGateway
    {
        public List<Department> departmentList()
        {
            Query = "SELECT * FROM Department";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader=Command.ExecuteReader();
            List<Department>departmentList=new List<Department>();
            while (Reader.Read())
            {
                Department aDepartment=new Department();
                aDepartment.Id = Convert.ToInt32(Reader["Id"]);
                aDepartment.Code = Reader["Code"].ToString();
                aDepartment.Name = Reader["Name"].ToString();

                departmentList.Add(aDepartment);
            }
            Reader.Close();
            Connection.Close();
            return departmentList;
        } 
    }
}