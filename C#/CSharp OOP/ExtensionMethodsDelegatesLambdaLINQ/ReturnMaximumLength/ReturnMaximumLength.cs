
// Task 17- Write a program to return the string with maximum length from an array of strings. Use LINQ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMaximumLength
{
    class ReturnMaximumLength
    {
        static void Main()
        {
            var array = new[] {"88","5555","peshoooooo","party","999"};

            var result =
                from arr in array
                orderby arr.Length descending
                select arr;

            Console.WriteLine(result.First());

        }
    }
}
