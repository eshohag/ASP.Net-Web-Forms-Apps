using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeManagementApp.DAL.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public string JoiningDate { get; set; }
        
    }
}