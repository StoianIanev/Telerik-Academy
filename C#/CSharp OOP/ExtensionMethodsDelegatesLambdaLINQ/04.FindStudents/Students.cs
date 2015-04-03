using System;

namespace _04.FindStudents
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public Students[] StudentsArr { get; set; }

        public Students(string firstName,string lastName,byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
