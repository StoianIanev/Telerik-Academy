using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CreateDAO
{
    public class CreateDAOTest
    {
        public static void Main()
        {
            //Northwind.Task1();

            Console.WriteLine();

            // Task 2

            //DAO.InsertCustomer("Best", "Telerik School Academy", "Pesho", "Owner", "Aleksandur Malinov", "Sofia", "Bulgaria", "08971455", "M", "0213", "0651");
            //DAO.InsertCustomer("Cool", "MS");
            //DAO.InsertCustomer("The best", "Peshoo"); // throw exception because customerID.Length > 5
            //DAO.DeliteCustomer("Best");
            DAO.ModifyCustomer("FAMIA", "Pesho");

            //

            Console.WriteLine();

            // Task 3
            //FindCustomers.FindAllCustomers("Canada",1997);
            //

            Console.WriteLine();

            // Task 4
            //NativeQuery.SQLQuery("Canada", 1997);
            //

            Console.WriteLine();

            // Task 5
            //FindSales.FindAllSales("SP", DateTime.Parse("1997-05-10"), DateTime.Parse("1998-09-10"));
            //

            // Task 8
            // Inheritance.Inherit();
            //
            // Task 9

            //using (TransactionScope scope = new TransactionScope())
            //{
            //    using (var db = new NorthwindEntities())
            //    {
            //        AddNewOrder.InsertOrder(10247, "The Best", "rue", "Paris", "SP", "0751", "Paris", null, null, null, null, null, null, null);
            //    }
            //    scope.Complete();
            //}
            //


        }
    }
}
