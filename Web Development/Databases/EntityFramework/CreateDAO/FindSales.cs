
// Task 5- Write a method that finds all the sales by specified region and period (start / end dates).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace CreateDAO
{
    class FindSales
    {
        public static void FindAllSales(string region, DateTime startDate, DateTime endDate)
        {
            try
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    var sales =
                        from sale in db.Orders
                        where sale.ShipRegion == region &&
                        sale.OrderDate > startDate &&
                        sale.OrderDate < endDate
                        select sale;

                    foreach (var s in sales)
                    {
                        Console.WriteLine("ID: {0}  Date: {1} Region: {2}",s.OrderID,s.OrderDate,s.ShipRegion);
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
