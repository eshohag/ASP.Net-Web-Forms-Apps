using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystem.DAL.ViewModel
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string DepartmentName { get; set; }
    }
}