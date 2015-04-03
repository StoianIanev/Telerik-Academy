
// Students (with Id, Name, Number, etc.)
// StudentsInCourses (many-to-many relationship)

namespace StudentsSystem.Model
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homework;
        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homework = new HashSet<Homework>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Age { get; set; }

        public virtual ICollection<Homework> Homework
        {
            get { return this.homework; }
            set { this.homework = value; }
        }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
       
    }
}
