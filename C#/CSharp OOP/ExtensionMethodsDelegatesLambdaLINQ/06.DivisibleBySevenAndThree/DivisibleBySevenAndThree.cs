
// Task 6- Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//         Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _06.DivisibleBySevenAndThree
{
    class DivisibleBySevenAndThree
    {
        static void Main()
        {
            List<int> numbers = new List<int>()
                            {
                                5, 8, 6, 21, 3, 7, 42, 63
                            };

            int dividor = 21;

            // Extension methods 
            List<int> number = numbers.FindAll(x => (x % dividor) == 0);
            Console.Write("The numbers divisible by 7 and 3 are: ");
            foreach (var num in number)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // LINQ
            var nums =
                from numb in numbers
                where numb % dividor == 0
                select numb;

            Console.WriteLine();
            Console.Write("The numbers divisible by 7 and 3 are: ");
            foreach (var n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

        }
    }
}
