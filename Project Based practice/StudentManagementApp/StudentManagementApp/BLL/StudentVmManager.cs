using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApp.DAL.Gateway;
using StudentManagementApp.DAL.Model;
using StudentManagementApp.DAL.ViewModel;

namespace StudentManagementApp.BLL
{
    public class StudentVmManager
    {
        StudentGateway aStudentGateway=new StudentGateway();

        public List<StudentVM> GetListOfStudentVms()
        {
            return aStudentGateway.ListOfStudentsVM();
        }
    }
}