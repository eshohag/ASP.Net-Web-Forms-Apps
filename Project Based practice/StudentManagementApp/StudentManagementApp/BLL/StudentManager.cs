using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentManagementApp.DAL.Gateway;
using StudentManagementApp.DAL.Model;

namespace StudentManagementApp.BLL
{
    public class StudentManager
    {
        StudentGateway aStudentGateway=new StudentGateway();

        public string Save(Student aStudent)
        {
            if (aStudent.RegNo.Length == 10 )
            {
                if (aStudentGateway.IsExistStudent(aStudent.RegNo) == null)
                {
                    if (aStudentGateway.Save(aStudent) > 0)
                    {
                        return "Save Successfully";
                    }
                    else
                    {
                        return "Failed Save";
                    }
                }
                else
                {
                    return "Already Entered Your Registration Number";
                }
              
            }
            else
            {
                return "Registration Number is Exact 10 digit long";
            }
           
        }

        public List<Student> aStudentOfList()
        {
            return aStudentGateway.ListOfStudents();
        }

        public Student GetSearchRegNo(string regNo)
        {
            return aStudentGateway.IsExistStudent(regNo);
        }

        public string GetUpdate(Student aStudent)
        {
            int message= aStudentGateway.GetUpdate(aStudent);
            if (message > 0)
            {
                return "Update is Successfully Saved";
            }
            else
            {
                return "Update Failed";
            }
        }

        public string GetDeleteRow(int id)
        {
            int rowAffected = aStudentGateway.GetDeleteRow(id);
            if (rowAffected > 0)
            {
                return "Successfully Delete Row";
            }
            else
            {
                return "Failed Delete Row";
            }
        }

        public Student GetIdWiseStudent(int id)
        {
            return aStudentGateway.GetIdWiseStudent(id);
        }
    }
}