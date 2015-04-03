
//Task 8- Write a program that, depending on the user's choice inputs int, double or string variable. 
//        If the variable is integer or double, increases it with 1. If the variable is string, 
//        appends "*" at its end. The program must show the value of that variable as a console output. 
//        Use switch statement.

using System;

namespace _08.UserInputType
{
    class UserInputType
    {
        static void Main()
        {
            Console.Write("Enter 1 for integer, 2 for double, and 3 for string: ");
            byte ch = byte.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("Enter your integer number: ");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine("Now your integer number is: {0}", i + 1);
                    break;
                case 2:
                    Console.Write("Enter your double number: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Now your double number is: {0}", d + 1);
                    break;
                case 3:
                    Console.Write("Enter your string: ");
                    string str = Console.ReadLine();
                    Console.WriteLine("Now your integer number is: {0}", str + '*' );
                    break;
                default:
                    Console.WriteLine("Your entered number is incorrectly!");
                    break;
            }

        }
    }
}
