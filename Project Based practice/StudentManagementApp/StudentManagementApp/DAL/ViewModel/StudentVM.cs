using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagementApp.DAL.ViewModel
{
    public class StudentVM
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }     
        public string ContactNo { get; set; }
        public string Code { get; set; }
        public string DepartmentName { get; set; }

    }
}