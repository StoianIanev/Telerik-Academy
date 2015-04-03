
// Task 5- Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name
//         and last name in descending order. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortedStudentsInDescendingOrder
{
    public class SortedStudents
    {
        static void Main()
        {

            Students[] studentArray = 
            {
                new Students("Gosho","Milchev"),
                new Students("Pesho","Peev"),
                new Students("Stoqn","Qnev"),
                new Students("Ana","Koleva"),
                new Students("Penka","Peeva"),
                new Students("Mariq","Daneva"),
                new Students("Ana","Georgieva")

            }; 

            // Lambda expressions
            var newStudentArray = studentArray.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var item in newStudentArray)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            // LINQ
            var students =
                from student in studentArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine();
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

        }
    }
}
