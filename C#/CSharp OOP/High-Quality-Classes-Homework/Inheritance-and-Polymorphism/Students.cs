using System;

namespace InheritanceAndPolymorphism
{
    public class Students
    {
        private string name;

        public Students(string name)
        {
            this.name = name;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                     throw new ArgumentNullException("The name of student cannot be null!");
                }
                this.name = value;
            }
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
