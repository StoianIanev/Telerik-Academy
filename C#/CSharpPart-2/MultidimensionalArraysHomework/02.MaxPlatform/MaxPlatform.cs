
//Task 2 - Write a program that reads a rectangular matrix of size N x M and 
//         finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

namespace _02.MaxPlatform
{
    class MaxPlatform
    {
        static void Main()
        {
          
            int[,] matrix = {
                                {0, 2, 4, 0, 9, 5},
                                {7, 1, 3, 3, 2, 1},
                                {1, 3, 9, 8, 5, 6},
                                {4, 6, 7, 9, 1, 0}
                            };

            int bestSum = 0;
            int sum = 0;
            int bestRow = 0;
            int bestCol = 0;
           

            for (int i = 0; i < matrix.GetLength(0)-2 ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-2 ; j++)
                {
                    for (int m = i; m < i+3; m++)
                    {
                        for (int p = j; p < j+3; p++)
                        {
                             sum +=  matrix[m,p];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = j;
                        bestCol = i;
                    }
                    sum = 0;
                }
            }

            for (int i = bestCol; i < bestCol + 3; i++)
            {
                for (int j = bestRow; j < bestRow + 3; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("The max sum is: {0}",bestSum);
        }
    }
}
