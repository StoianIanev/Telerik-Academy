
// Task 14 - A bank account has a holder name (first name, middle name and last name), 
// available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers 
// associated with the account. Declare the variables needed to keep the information 
// for a single bank account using the appropriate data types and descriptive names.

using System;

namespace _14.BankAccount
{
    class BankAccount
    {
        static void Main()
        {
            Console.Write("Please enter you first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter you middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Please enter last name: ");
            string lastName = Console.ReadLine();
            
            decimal balanceOfMoney = 20000m;
            string bankName = "PostBank";

            string iBan = "BGN07FFUU87003456735671";
            string bicCode = "BIC43562";

            ulong creditCard1 = 4346709612345976 ;
            ulong creditCard2= 1526709612345976;
            ulong creditCard3 = 1116709612345976;

            Console.WriteLine("Information for person:");
            Console.WriteLine();
            Console.WriteLine("Name:{0} {1} {2}",firstName,middleName,lastName);
            Console.WriteLine();
            Console.WriteLine("Your bank is: {0}",bankName);
            Console.WriteLine();
            Console.WriteLine("Available bank balance: {0}lv",balanceOfMoney);
            Console.WriteLine();
            Console.WriteLine("iBan: {0}",iBan);
            Console.WriteLine();
            Console.WriteLine("BIC code: {0}",bicCode);
            Console.WriteLine();
            Console.WriteLine("The number of your first credit card is: {0}", creditCard1);
            Console.WriteLine();
            Console.WriteLine("The number of your second credit card is: {0}", creditCard2);
            Console.WriteLine();
            Console.WriteLine("The number of your third credit card is: {0}", creditCard3);




        }
    }
}
