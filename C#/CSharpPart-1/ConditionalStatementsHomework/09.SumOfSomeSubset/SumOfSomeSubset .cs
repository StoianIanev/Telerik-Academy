
//Task 9- We are given 5 integer numbers. Write a program that checks if the sum 
//        of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

namespace _09.SumOfSomeSubset
{
    class Program
    {
        static void Main()
        {
            int s = 0;
            int[] arr = new int [5];
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter your five numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i <= arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    sum = arr[i] + (arr[j]+ arr[j+1]);
                    s = sum;
                    
                    if (s == 0)
                    {
                        count++;
                       int[] array = {arr[i],arr[j],arr[j+1]};
                       Console.WriteLine("The sum of {0} is: 0 ",string.Join(",",array));
                       
                    }

                    s = 0;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Not subset with sum 0!");
            }
            
            
           

        }
    }
}
