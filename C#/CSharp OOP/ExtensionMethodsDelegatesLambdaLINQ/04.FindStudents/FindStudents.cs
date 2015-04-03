
// Task 4- Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FindStudents
{
    class FindStudents
    {
        static void Main()
        {
            Students[] studentsArray = {
                                           new Students("Pesho","Milchev",18),
                                           new Students("Mitko","Radev",16),
                                           new Students("Gosho","Todorov",26),
                                           new Students("Penka","Peeva",20),
                                           new Students("Mariq","Daneva",19),
                                           new Students("Ana","Georgieva",15)

                                       };

            var students =
                from sudent in studentsArray
                where sudent.Age <= 26 && sudent.Age >= 18
                select sudent;

            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Age);
            }

        }
    }
}
