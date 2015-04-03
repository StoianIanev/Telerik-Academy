
// Task 2 - Using Entity Framework write a query that selects all employees from the Telerik Academy database, 
//          then invokes ToList(), then selects their addresses, then invokes ToList(), 
//          then selects their towns, then invokes ToList() and finally checks whether the town is "Sofia". 
//          Rewrite the same in more optimized way and compare the performance.

namespace TelerikAcademyDatabase
{
    using System;
    using System.Linq;
    using System.Collections;

    public class EmployeesToList
    {
        public static TelerikAcademyEntities db = new TelerikAcademyEntities();

        public static void EmployerToList()
        {
            using (db)
            {
                NoOptimizedWay();
                OptimizedWay();
            }
        }
        public static void NoOptimizedWay()
        {
            var employer = db.Employees.ToList()
             .Select(a => a.Address).ToList()
             .Select(t => t.Town).ToList()
             .Where(x => x.Name == "Sofia");

            foreach (var town in employer)
            {
                Console.WriteLine(town.Name);
            }

           

        }
        public static void OptimizedWay()
        {

            var employer = db.Employees
                .Select(a => a.Address)
                .Select(t=> t.Town)
                .Where(t => t.Name == "Sofia");

            foreach (var town in employer)
            {
                Console.WriteLine(town.Name);
            }
        }
    }
}
