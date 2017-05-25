using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentManagementApp.DAL.Model;
using StudentManagementApp.DAL.ViewModel;

namespace StudentManagementApp.DAL.Gateway
{
    public class StudentGateway:CommonGateway
    {
        public int Save(Student aStudent)
        {
            Query = "INSERT INTO Student VALUES('" + aStudent.Name + "','" + aStudent.RegNo + "','" + aStudent.Email +"','" + aStudent.ContactNo + "','" + aStudent.DepartmentId + "')";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected=Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Student IsExistStudent(string regNo)
        {
            Query = "SELECT * FROM Student WHERE RegNo='"+regNo+"'";
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Student aStudent = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aStudent=new Student();
                aStudent.Id = Convert.ToInt32(Reader["Id"]);
                aStudent.Name = Reader["Name"].ToString();
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.ContactNo = Reader["ContactNo"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
            }
            Reader.Close();
            Connection.Close();
            return aStudent;
        }

        public List<Student> ListOfStudents()
        {
            Query = "SELECT * FROM Student";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Student>aStudentList=new List<Student>();
            while (Reader.Read())
            {              
                Student aStudent = new Student();
                aStudent.Id = Convert.ToInt32(Reader["Id"]);
                aStudent.Name = Reader["Name"].ToString();
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.ContactNo = Reader["ContactNo"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);

                aStudentList.Add(aStudent);
            }
            Reader.Close();
            Connection.Close();
            return aStudentList;
        }
        public List<StudentVM> ListOfStudentsVM()
        {
            Query = "SELECT * FROM StudentWiseDepartment";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<StudentVM> aStudentList = new List<StudentVM>();
            while (Reader.Read())
            {
                StudentVM aStudent = new StudentVM();
                aStudent.Id = Convert.ToInt32(Reader["Id"]);
                aStudent.Name = Reader["Name"].ToString();
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.ContactNo = Reader["ContactNo"].ToString();
                aStudent.Code = Reader["Code"].ToString();
                aStudent.DepartmentName = Reader["DepartmentName"].ToString();

                aStudentList.Add(aStudent);
            }
            Reader.Close();
            Connection.Close();
            return aStudentList;
        }


        public int GetUpdate(Student aStudent)
        {
            Query = "UPDATE Student SET Name='" + aStudent.Name + "',Email='" + aStudent.Email + "',ContactNo='" + aStudent.ContactNo + "',DepartmentId='" + aStudent.DepartmentId + "' WHERE Id=" + aStudent.Id;
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public int GetDeleteRow(int id)
        {
            Query = "DELETE FROM Student WHERE Id=" + id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Student GetIdWiseStudent(int id)
        {
            Query = "SELECT * FROM Student WHERE Id=" + id;
            Command=new SqlCommand(Query,Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Student aStudent = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aStudent = new Student();            
                aStudent.Name = Reader["Name"].ToString();
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.ContactNo = Reader["ContactNo"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
            }
            Reader.Close();
            Connection.Close();
            return aStudent;
        }
    }
}