using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FinalSubmission
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new StudentDB())
            {

                var newStudent = new Student { Name = "Tyler" };
                db.Students.Add(newStudent);
                db.SaveChanges();

                var query = from x in db.Students
                            orderby x.Name
                            select x;

                Console.WriteLine("All students in the db");

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadLine();
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
  
    }

    public class StudentDB : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
