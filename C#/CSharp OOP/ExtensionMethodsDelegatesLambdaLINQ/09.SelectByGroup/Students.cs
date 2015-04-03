
// Task 9- Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
//         Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.

using System;
using System.Text;
using System.Collections.Generic;

namespace _09.SelectByGroup
{
    public class Students
    {
        public string firstName;
        public string lastName;
        public string fn;
        public string tel;
        public string email;
        public List<int> marks;
        public int groupNumber;
        
        public Students(string fName,string lName, string fn, string tel, string email, int groupNum, params int[] inputMarks)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.fn = fn;
            this.tel = tel;
            this.Email = email;
            this.groupNumber = groupNum;
            this.marks = new List<int>(inputMarks);
        }

        public string FName
        {
            get { return this.firstName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty!");
                }
                this.firstName = value; 
            }
        }
        public string LName
        {
            get { return this.lastName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty!");
                }
                this.lastName = value; 
            }
        }
        public string FacultyNumber
        {
            get { return this.fn; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number can not be null or empty!");
                }
                this.fn = value; 
            }
        }
        public string Telephone
        {
            get { return this.tel; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Telephone number can not be null or empty!");
                }
                this.tel = value; 
            }
        }
        public string Email
        {
            get { return this.email; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can not be null or empty!");
                }
                this.email = value; 
            }
        }
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value < 1 )
                {
                    throw new ArgumentNullException("Group number must be > 0 !");
                }
                this.groupNumber = value; 
            }
        }
        public Group Group { get; set; }

        public List<int> Marks
        {
            get { return this.marks; }
           
        }
    }
}
