//Create a basic Entity Framework Code-First app that creates a basic Student database and adds one student.

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var TPS = new StudentContext())
            {
                var studentAdd = new student() { FirstName = "Nathaniel", LastName = "Reister", Age = 19, SchoolYear = 12, GPA = 2.6 };
                TPS.Students.Add(studentAdd);
                TPS.SaveChanges();
            }
        }
    }

    public class student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int SchoolYear { get; set; }
        public double GPA { get; set; }
    }

    public class StudentContext : DbContext
    {
        //public StudentContext() : base("mySchoolDb")
        //{
        //    Database.SetInitializer<StudentContext>(new CreateDatabaseIfNotExists<StudentContext>());
        //}
        public DbSet<student> Students { get; set; }
    }
}
