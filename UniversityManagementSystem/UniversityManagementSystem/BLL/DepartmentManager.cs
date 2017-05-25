using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.DAL.Gateway;
using UniversityManagementSystem.DAL.Model;

namespace UniversityManagementSystem.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public List<Department> GetAllDepartments()
        {
            return aDepartmentGateway.GetAllDepartments();
        }
    }
}