using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName, IList<Students> students, string town)
            :base(courseName,teacherName,students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if(value == null)
                {
                     throw new ArgumentNullException("Town can not be null!");
                }
                this.town=value;
            }
        }
     
        public override string ToString()
        {
            string result = base.ToString() + string.Format("; Town = {0}", this.Town) + " }";
            return result;
          
        }
    }
}
