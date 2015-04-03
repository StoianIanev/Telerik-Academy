
//Task 3- Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace _03.ComparesTwoCharArrays
{
    class ComparesTwoCharArrays
    {
        static void Main()
        {
            Console.Write("Enter the length of first array: ");
            int firstArrayLen = int.Parse(Console.ReadLine());
            char[] firstArr = new char[firstArrayLen];
            Console.Write("Enter the length of second array: ");
            int secondArrayLen = int.Parse(Console.ReadLine());
            char[] secondArr = new char[secondArrayLen];
           

            for (int i = 1; i < Math.Min(firstArrayLen,secondArrayLen); i++)
            {
                Console.WriteLine("Enter {0} (type char) element of first array: ",i);
                firstArr[i] = char.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter {0} (type char) element of second array: ", i);
                secondArr[i] = char.Parse(Console.ReadLine());

                if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine("Second array is first");
                    break;
                }
                if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine("First array is first");
                    break;
                }
                
            }

            if (firstArrayLen > secondArrayLen)
            {
                Console.WriteLine("The second array is first.");

            }
            else if (firstArrayLen < secondArrayLen)
            {
                Console.WriteLine("The first array is earlier.");
            }
            else
            {
                Console.WriteLine("The two arrays are the same.");
            }

        }

    }
}
