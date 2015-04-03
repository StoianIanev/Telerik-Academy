
// Task 3- Write a method that finds all customers who have orders made in 1997 and shipped to Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace CreateDAO
{
    public class FindCustomers
    {
        public static void FindAllCustomers(string country,int year)
        {
            try
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    var orders = db.Orders.Where
                        (o => o.OrderDate.Value.Year == year &&
                            o.ShipCountry == country).GroupBy(o => o.Customer.ContactName);

                    foreach (var order in orders)
                    {
                        Console.WriteLine(order.Key);
                    }
                }
            }
            catch (DbEntityValidationException dbEvx)
            {

                Console.WriteLine(dbEvx.Message);
            }
        }
    }
}
