
//Task 17- Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//         and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.CalculateDateAfterTime
{
    class CalculateDateAfterTime
    {
        static void Main()
        {
            try
            {
               Console.Write("Enter date {d.MM.yyy hh:mm:ss}: ");
               string start = Console.ReadLine();
               DateTime date = DateTime.ParseExact(start, "d.MM.yyyy hh:mm:ss",CultureInfo.InvariantCulture);
               date = date.AddHours(6.5);
               Console.WriteLine("After 6 hours and 30 minutes will be: {0}", date);

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date! Please enter correct date {d.MM.yyyy}!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Please provide a date. The date cannot be null!");
            }
           

        }
    }
}
