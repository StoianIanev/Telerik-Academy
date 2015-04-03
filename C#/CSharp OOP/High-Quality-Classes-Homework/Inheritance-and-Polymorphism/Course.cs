using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private IList<Students> students;

        public Course(string name, string teacherName, IList<Students> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException("The name can not be null");
                }
                this.name = value;
            }
        }
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }
            set
            {
                if (value != null)
                {
                    this.teacherName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The name can not be null");
                }
                
            }

        }

        public IList<Students> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value != null )
                {
                    if (value.Count > 0)
                    {
                         this.students = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Course should have at least one student");
                    }
                   
                }
                else
                {
                    throw new ArgumentException("Students List can't be null");
                }
                
            }

        }

        private string GetStudentsAsString()
        {
            
            return "{ " + string.Join(", ", this.Students) + " }";
            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{ Name = ");
            result.Append(this.Name);

            result.Append("; Teacher = ");
            result.Append(this.TeacherName);

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            return result.ToString();
        }

    }
}
