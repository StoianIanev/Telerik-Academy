using System;

namespace _03.StudentArray
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Students[] StudentsArr { get; set; }

        public Students(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
