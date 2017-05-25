using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using UniversityManagementSystem.DAL.Model;
using UniversityManagementSystem.DAL.ViewModel;

namespace UniversityManagementSystem.DAL.Gateway
{
    public class StudentGateway : Gateway
    {
        public int Save(Student aStudent)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;

            Query = "INSERT INTO Students (RegNo, Name, Contact, Email, DepartmentId) VALUES('" + aStudent.RegNo + "', '" + aStudent.Name + "', '" + aStudent.ContactNo + "', '" + aStudent.Email + "', '" + aStudent.DepartmentId + "')";

            Command = new SqlCommand(Query, Connection);
            //command.CommandText = query;
            //command.Connection = connection;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }

        public Student IsRegNoExist(string regNo)
        {
            //SqlConnection connection = new SqlConnection(connectionString);

            Query = "SELECT * FROM Students WHERE RegNo='" + regNo + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            Student aStudent = null;

            if (Reader.HasRows)
            {
                Reader.Read();
                aStudent = new Student();
                aStudent.Id = Convert.ToInt32(Reader["Id"]);
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.Name = Reader["Name"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.ContactNo = Reader["Contact"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
            }

            Reader.Close();
            Connection.Close();
            return aStudent;
        }

        public List<StudentViewModel> GetAllStudents()
        {
            //SqlConnection connection = new SqlConnection(connectionString);

            Query = "SELECT * FROM StudentWiseDepartment";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<StudentViewModel> students = new List<StudentViewModel>();

            while (Reader.Read())
            {
                StudentViewModel student = new StudentViewModel();

                student.StudentId = Convert.ToInt32(Reader["StudentId"]);
                student.RegNo = Reader["RegNo"].ToString();
                student.StudentName = Reader["StudentName"].ToString();
                student.Email = Reader["Email"].ToString();
                student.Contact = Reader["Contact"].ToString();
                student.DepartmentName = Reader["DeptName"].ToString();

                students.Add(student);
            }

            Reader.Close();
            Connection.Close();

            return students;
        }

        public int Update(Student student)
        {
            Query = "UPDATE Students SET Name='" + student.Name + "', Email='" + student.Email + "', Contact='" + student.ContactNo + "', DepartmentId='" + student.DepartmentId + "' WHERE Id=" + student.Id;

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();

            return rowAffected;
        }

        public int Delete(int id)
        {
            Query = "DELETE FROM Students WHERE Id=" + id;

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();

            return rowAffected;
        }

        public Student GetStudentById(int id)
        {
            Query = "SELECT * FROM Students WHERE Id="+id;

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            Student aStudent = null;

            if (Reader.HasRows)
            {
                Reader.Read();
                aStudent = new Student();
                aStudent.Id = Convert.ToInt32(Reader["Id"]);
                aStudent.RegNo = Reader["RegNo"].ToString();
                aStudent.Name = Reader["Name"].ToString();
                aStudent.Email = Reader["Email"].ToString();
                aStudent.ContactNo = Reader["Contact"].ToString();
                aStudent.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
            }

            Reader.Close();
            Connection.Close();
            return aStudent;
        }
    }
}