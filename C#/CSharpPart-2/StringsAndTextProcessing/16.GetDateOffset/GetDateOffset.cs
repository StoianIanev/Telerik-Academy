
//Task 16- Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//         Example:
//         Enter the first date: 27.02.2006
//         Enter the second date: 3.03.2006
//         Distance: 4 days

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _16.GetDateOffset
{
    class GetDateOffset
    {
        private static DateTime ParseDate(string start)
        {
            DateTime date = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
            return date;
        }
        static void Main()
        {
            try
            {
                Console.Write("Enter first date {d.MM.yyy}: ");
                string start = Console.ReadLine();
                DateTime firstDate = ParseDate(start);

                Console.Write("Enter second date: ");
                string end = Console.ReadLine();
                DateTime secondDate = ParseDate(end);

                Console.WriteLine("Dictance {0} day/s", (secondDate - firstDate).TotalDays);

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
