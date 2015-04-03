
//Task 3- A company has name, address, phone number, fax number, web site and manager.
//        The manager has first name, last name, age and a phone number.
//        Write a program that reads the information about a company and 
//        its manager and prints them on the console.
 
using System;

namespace _03.CompanyInformation
{
    class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter the name of the company: ");
            string name = Console.ReadLine();
            Console.Write("Enter the address of the company: ");
            string adress = Console.ReadLine();
            Console.Write("Enter the phone number of the company: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the fax number of the company: ");
            string faxNum = Console.ReadLine();
            Console.Write("Enter the web site of the company: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter the firs name of manager of the company: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name of the manager of the company: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter the age of the manager: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the phone number of the manager: ");
            string phoneNum = Console.ReadLine();

            Console.WriteLine(" The name of company is {0}. His adress is {1}. Phone number of company is {2} the fax number is {3}. The web side of company is {4}. The first name of  manager is {5} the last name {6} and he is {7} old. His phone number is {8}", name, adress, phoneNumber, faxNum, webSite, firstName, lastName,age, phoneNum);

        }
    }
}
