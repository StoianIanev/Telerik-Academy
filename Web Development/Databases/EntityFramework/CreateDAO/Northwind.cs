
// Task 1- Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDAO
{
    class Northwind
    {
        public static void Task1()
        {
            var db = new NorthwindEntities();

            var list = db.Customers.ToList();

            foreach (var customers in list)
            {
                Console.WriteLine(customers.CompanyName);
            }
        }
    }
}
