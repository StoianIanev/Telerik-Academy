using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsSystem.Model;
using StudentSystem.Date;

namespace _02.StudentSystem.Client
{
    public class StudentSystemClient
    {
        public static void Main()
        {
            var db = new StudentSystemDbContext();
             
            var student = new Student()
                    {
                        FirstName = "Pesho",
                        LastName = "Goshov",
                        Age = 20,
                        Number = 24
                    };

            db.Students.Add(student);

            //-----------------------

            var course = new Course()
            {
                Name = "CSharp",
                Description = null,
                Materials = null
            };

            student.Courses.Add(course);

            //----------------------

            var homework = new Homework()
            {
                Course = course,
                Content = "Good",
                TimeSent = DateTime.Now

            };
            student.Homework.Add(homework);
            db.SaveChanges();

            // ---------------------------
            // Print result

            var printStudent = db.Students.First();
            Console.WriteLine("ID: {0} \nFirst Name: {1} \nLast Name: {2} \nAge: {3} \nNumber: {4}", printStudent.Id, printStudent.FirstName, printStudent.LastName, printStudent.Age, printStudent.Number);

            var printCourse = db.Courses.First();
            Console.WriteLine("\nName: {0} \nDescription: {1} \nMaterials: {2}", printCourse.Name, printCourse.Description, printCourse.Materials);

            var printHomework = db.Homeworks.First();
            Console.WriteLine("\nContent: {0} \nTimeSent: {1}", printHomework.Content, printHomework.TimeSent);
        }
     
    }
}
