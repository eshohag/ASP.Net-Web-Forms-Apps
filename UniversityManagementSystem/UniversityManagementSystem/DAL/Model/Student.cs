﻿namespace UniversityManagementSystem.DAL.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public int DepartmentId { get; set; }
    }
}