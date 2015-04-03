
// Task 4- Implement previous by using native SQL query and executing it through the DbContext.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace CreateDAO
{
    public class NativeQuery
    {
        public static void SQLQuery(string country, int year)
        {
             var db = new NorthwindEntities();
             using (db)
             {
                 string commandStringSQL =
               @"SELECT c.ContactName from Customers" +
                              " c INNER JOIN Orders o ON o.CustomerID = c.CustomerID " +
                              "WHERE (YEAR(o.OrderDate) = {0} AND o.ShipCountry = {1});";

                 object[] parameters = {country, year};

                 var customers = db.Database.SqlQuery<string>(commandStringSQL, parameters);

                 foreach (var name in customers)
                 {
                     Console.WriteLine(name);
                 }

             }
        }
    }
}
