// Task 9- Create a method that places a new order in the Northwind database. 
//         The order should contain several order items. 
//         Use transaction to ensure the data consistency.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace CreateDAO
{
    public class AddNewOrder
    {
        public static void InsertOrder(
            int orderID,
            string shipName,
            string shipAddress,
            string shipCity,
            string shipRegion,
            string shipPostalCode,
            string shipCountry,
            string customerID = null,
            int? employeeID = null,
            DateTime? orderDate =  null,
            DateTime? requiredDate = null,
            DateTime? shippedDate = null,
            int? shipVia = null,
            decimal? freight = null
            
            )
        {
            try
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    var newOrder = new Order
                    {
                        OrderID = orderID,
                        ShipName = shipName,
                        ShipAddress = shipAddress,
                        ShipCity = shipCity,
                        ShipRegion = shipRegion,
                        ShipPostalCode = shipPostalCode,
                        ShipCountry = shipCountry,
                        CustomerID = customerID,
                        EmployeeID = employeeID,
                        OrderDate = orderDate,
                        RequiredDate = requiredDate,
                        ShippedDate = shippedDate,
                        ShipVia = shipVia,
                        Freight = freight

                    }; 
                    db.Orders.Add(newOrder);
                    db.SaveChanges();
                }

            }
            catch (DbEntityValidationException dbEvx)
            {
                Console.WriteLine(dbEvx.Message);
            }

        }
    }
}
