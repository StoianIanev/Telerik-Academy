
// Task 2- Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableTest
{
    class IEnumerableTest
    {
        static void Main()
        {
            List<int> list = new List<int>()
           {
               5, 8, 9, 10, 1
           };

            Console.WriteLine("Sum: {0}",list.Sum());
            Console.WriteLine("Product: {0}",list.Product());
            Console.WriteLine("Min: {0}",list.Min());
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Average: {0}",list.Average());
        }
    }
}
