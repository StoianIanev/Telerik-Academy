
//Task 11- Write a program that reads from the console a positive integer number N (N < 20) 
//         and outputs a matrix like the following: 
//         N = 3         N = 4 

//         1 2 3          1 2 3 4
//         2 3 4          2 3 4 5 
//         3 4 5          3 4 5 6
//                        4 5 6 7

using System;

namespace _11.Matrix
{
    class Matrix
    {
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    Console.Write(row + " ");
                    for (int col = 1; col < n; col++)
                    {
                        Console.Write(col + row + " ");

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
