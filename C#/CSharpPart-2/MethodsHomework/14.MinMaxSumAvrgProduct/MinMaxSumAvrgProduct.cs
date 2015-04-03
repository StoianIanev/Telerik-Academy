
//Task 14- Write methods to calculate minimum, maximum, average, sum and 
//         product of given set of integer numbers. Use variable number of arguments.

using System;

namespace _14.MinMaxSumAvrgProduct
{
    class MinMaxSumAvrgProduct
    {

        static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i <= arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i <= arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        static double FindAverage(int[] arr)
        {
            double sum = 0;
         
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return  sum / arr.Length;
        }
        static int FindSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        static int FindProduct(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }

            return product;
        }
        static void Main()
        {
            Console.Write("How numbers you will enter: ");
            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter your numbers: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The max number in your numbers is: {0}", FindMax(arr));
            Console.WriteLine("The min number in your numbers is: {0}", FindMin(arr));
            Console.WriteLine("The average of your numbers is: {0}", FindAverage(arr));
            Console.WriteLine("The sum of your numbers is: {0}", FindSum(arr));
            Console.WriteLine("The product of your numbers is: {0}", FindProduct(arr));
         

        }
    }
}
