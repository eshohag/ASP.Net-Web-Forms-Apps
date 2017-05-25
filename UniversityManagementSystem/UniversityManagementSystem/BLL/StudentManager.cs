using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagementSystem.DAL.Gateway;
using UniversityManagementSystem.DAL.Model;
using UniversityManagementSystem.DAL.ViewModel;

namespace UniversityManagementSystem.BLL
{
    public class StudentManager
    {
        StudentGateway aStudentGateway = new StudentGateway();

        public string Save(Student aStudent)
        {
            if (aStudent.RegNo.Length >= 6)
            {
                if (aStudentGateway.IsRegNoExist(aStudent.RegNo) != null)
                {
                    return "Registration number already exists";
                }
                else
                {
                    if (aStudentGateway.Save(aStudent) > 0)
                    {
                        return "Saved successfully";
                    }
                    else
                    {
                        return "Save failed";
                    }
                }
            }
            else
            {
                return "Registration number must be atleast 6 characters long";
            }
        }

        public List<StudentViewModel> GetAllStudents()
        {
            return aStudentGateway.GetAllStudents();
        }

        public Student SearchStudent(string regNo)
        {
            return aStudentGateway.IsRegNoExist(regNo);
        }

        public string Update(Student student)
        {
            int rowAffected = aStudentGateway.Update(student);

            if (rowAffected > 0)
            {
                return "Update successful";
            }
            else
            {
                return "Update failed";
            }
        }

        public string Delete(int id)
        {
            int rowAffected = aStudentGateway.Delete(id);

            if (rowAffected > 0)
            {
                return "Delete successful";
            }
            return "Delete failed";
        }

        public Student GetStudentById(int id)
        {
            return aStudentGateway.GetStudentById(id);
        }
    }
}