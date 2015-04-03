
// Courses (Name, Description, Materials, etc.)
// StudentsInCourses (many-to-many relationship)

namespace StudentsSystem.Model
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homework;
        public Course()
        {
            this.students = new HashSet<Student>();
            this.homework = new HashSet<Homework>();
        }
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Materials { get; set; }

        public virtual ICollection<Homework> Homework 
        {
            get { return this.homework; }
            set { this.homework = value; }
        }


        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set{this.students = value;}
        }

        
    }
}
