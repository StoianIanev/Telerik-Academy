
// Task 10 - A marketing firm wants to keep record of its employees. 
// Each record would have the following characteristics – 
// first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
// Declare the variables needed to keep the information for a single employee 
// using appropriate data types and descriptive names.

using System;

namespace _10.KeepRecord
{
    class KeepRecord
    {
        static void Main( )
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your gender 'm' or 'f': ");
            char gender = char.Parse(Console.ReadLine()) ;
            Console.Write("Enter your ID number: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Information for person:");
            Console.WriteLine("Name: {0} {1}",firstName , lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: ",gender);
            Console.WriteLine("ID number: {0}",id);


        }
    }
}
