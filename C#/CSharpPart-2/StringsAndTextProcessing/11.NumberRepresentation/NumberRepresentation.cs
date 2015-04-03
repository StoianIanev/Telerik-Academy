
// Task 11- Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberRepresentation
{
    class NumberRepresentation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15:F}",num);
            Console.WriteLine("{0,15:X}",num);
            Console.WriteLine("{0,15:P}", num);
            Console.WriteLine("{0,15:C}", num);
            Console.WriteLine("{0,15:E}", num);
           
        }
    }
}
