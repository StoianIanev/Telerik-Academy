
// Task 6 - // Declare a boolean variable called isFemale and 
//          assign an appropriate value corresponding to your gender.

using System;

namespace TypeBool
{
    class TypeBool
    {
        static void Main()
        {
            bool isMale = true;

            Console.Write("Please enter your gender: ");
            string gender = Console.ReadLine();

            if (gender != "male")
            {
                isMale = false;
            }

            Console.WriteLine("You are male -> {0} ", isMale);

        }
    }
}
