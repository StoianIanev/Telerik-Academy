
// Task 3- Write a method that from a given array of students finds all students 
//         whose first name is before its last name alphabetically. Use LINQ query operators.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentArray
{
    class StudentArray
    {
        static void Main()
        {
            Students[] studentArray = 
            {
                new Students("Gosho","Milchev"),
                new Students("Pesho","Peev"),
                new Students("Stoqn","Qnev"),
                new Students("Ana","Koleva")
            };

            var students =
                from student in studentArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (Students item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}
