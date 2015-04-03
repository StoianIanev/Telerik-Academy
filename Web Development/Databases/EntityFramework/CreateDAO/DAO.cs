
// // Task 2- Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. 
//         Write a testing class.

using System;
using System.Linq;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace CreateDAO
{
    public static class DAO
    {

        public static void InsertCustomer(
            string customerID,
            string companyName,
            string contactName=null,
            string contactTitle = null,
            string address = null,
            string city = null,
            string country = null,
            string phone = null,
            string region = null,
            string postalCode = null,
            string fax = null)


        {
            try
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    var newCustomer = new Customer
                    {
                        CustomerID = customerID,            
                        CompanyName = companyName,
                        ContactName = contactName,
                        ContactTitle = contactTitle,
                        Address = address,
                        City = city,
                        Region = region,
                        PostalCode = postalCode,
                        Country = country,
                        Phone = phone,
                        Fax = fax,

                    };
                    if (customerID.Length > 5)  
                    {
                        throw new ArgumentOutOfRangeException("Your customerID must be smaller than 5"); // in Database CustomerID = nchar(5)
                    }
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();
 
                }
               
            }
            catch (DbEntityValidationException dbEvx)
            {
                Console.WriteLine(dbEvx.Message);
            }
            
        }

        public static void DeliteCustomer(string customerID)
        {
            try
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    var found =
                    (from customer in db.Customers
                    where customer.CustomerID == customerID
                    select customer).First();

                    db.Customers.Remove(found);
                    db.SaveChanges();
                }


            }           
            catch (DbEntityValidationException dbEvx)
            {
                Console.WriteLine(dbEvx.Message);
            }
        }
        public static void ModifyCustomer(string customerID, string newName)
        {
            try
            {
                var db = new NorthwindEntities();
                using (db)
                {
                    var customerToModify =
                        (from customer in db.Customers
                         where customer.CustomerID == customerID
                         select customer).First();

                    customerToModify.ContactName = newName;
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
