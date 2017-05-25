using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApp.DAL.Gateway;
using StudentManagementApp.DAL.Model;

namespace StudentManagementApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway=new DepartmentGateway();

        public List<Department> DepartmentList()
        {
            return aDepartmentGateway.departmentList();
        } 
    }
}