using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name, string teacherName, IList<Students> students, string lab)
            : base(name, teacherName, students)
        {
            
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
               return this.lab;
            }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Lab can not be null!");
                }
                this.lab = value;
            }
        }
      
        public override string ToString()
        {
            string result = base.ToString() + string.Format("; Lab = {0}", this.Lab) + " }";
            return result;
        }
    }
}
