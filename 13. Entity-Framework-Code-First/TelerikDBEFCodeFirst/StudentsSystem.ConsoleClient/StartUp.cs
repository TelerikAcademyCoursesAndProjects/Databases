using System;
using StudentSystem.Data;
using StudentSystem.Models;

namespace StudentsSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            using (var db = new StudentDbContext())
            {
                var course = new Course { Name = "Kurs", Description = "Some description", Materials = "Razni materiali" };

                var homework = new Homework { Content = "Nqma sadarjanie ama karai", TimeSent = DateTime.Now };

                var student = new Student
                {
                    Name = "Haralampi Lampev",
                    Number = 1313,
                };

                db.Courses.Add(course);
                db.Homeworks.Add(homework);
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
