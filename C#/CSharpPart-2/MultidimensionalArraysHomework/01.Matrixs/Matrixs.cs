
//Task 1- Write a program that fills and prints a matrix of size (n, n) 
//        as shown below: (examples for n = 4)

//                   1 5  9 13 
//                   2 6 10 14
//                   3 7 11 15
//                   4 8 12 16

using System;

namespace _01.Matrixs
{
    class Matrixs
    {
        static void PrintArray(int[,] matrix,int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int currentValue = 1;

            // a)


            for (int col = 0; col < n; col++)
            {

                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = currentValue;
                    currentValue++;
                }


            }
            Console.WriteLine("A:");
            PrintArray(matrix, n);

            //  b)

            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = currentValue;
                        currentValue++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = currentValue;
                        currentValue++;
                    }
                }


            }
            Console.WriteLine("B: ");
            PrintArray(matrix, n);

            // c

            int r = n - 1;
            int c = 0;
            int StartRow = n - 1;
            int StartCol = 0;
            matrix[r, c] = 1;

            while (currentValue < n * n)
            {
                
                if (r == (n - 1) && c < (n - 1))
                {
                    StartRow--;
                    StartCol = 0;
                    r = StartRow;       
                    c = StartCol;       
                    currentValue++;
                    matrix[r, c] = currentValue;

                   
                    while (r < (n - 1) && c < (n - 1))
                    {
                        r++;    
                        c++;    
                        currentValue++;
                        matrix[r, c] = currentValue;
                    }
                }
                
                if (r <= (n - 1) && c == (n - 1))
                {
                    StartRow = 0;
                    StartCol++;
                    r = StartRow;   
                    c = StartCol;   
                    currentValue++;       
                    matrix[r, c] = currentValue;

                    
                    while (c < (n - 1))
                    {
                        r++;    
                        c++;    
                        currentValue++;
                        matrix[r, c] = currentValue;
                    }
                }
            }
            Console.WriteLine("C: ");
            PrintArray(matrix, n);

        }
    }
}
