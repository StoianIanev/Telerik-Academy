namespace StudentSystem.Date
{
    using System;

    using System.Data.Entity;

    using StudentsSystem.Model;

    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
            :base("StudSystem")
        {
        }

        public IDbSet<Student> Students { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Homework> Homeworks { get; set; }
    }
}
