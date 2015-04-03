
//Task 2- Write a program that reads two arrays from the console 
//        and compares them element by element.

using System;

namespace _02.ComparingTheElementsOfArray
{
    class ComparingElements
    {
        static void Main()
        {
            Console.WriteLine("Enter equal lengths");
            Console.Write("Enter the length of first array: ");
            int len1 = int.Parse(Console.ReadLine());
            int[] firstArr = new int [len1]; 
            Console.Write("Enter the length of second array: ");
            int len2 = int.Parse(Console.ReadLine());
            int[] secondArr = new int[len2];
            bool equal = true;

            if (firstArr.Length > secondArr.Length)
            {
                Console.WriteLine("The first array have bigger length => the two arrays are not equal!");
            }
            else if (secondArr.Length > firstArr.Length)
            {
                Console.WriteLine("The second array have bigger length => the two arrays are not equal!");

            }
            else
            {
                EnterArray(firstArr, secondArr);
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] != secondArr[i])
                    {
                        equal = false;
                        break;
                    }
                }

                Console.WriteLine("Are the both arrays equal? {0}", equal);
            }

        }
        static void EnterArray(int[] firstArray, int[] secondArray)
        {
            Console.Write("Enter the elements of the first array: ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the elements of the first array: ");
            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }

        }

    }
}
