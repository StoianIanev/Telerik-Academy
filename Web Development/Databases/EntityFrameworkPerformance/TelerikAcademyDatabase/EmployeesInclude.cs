
// Task 1 - Using Entity Framework write a SQL query to select all employees from the Telerik Academy database 
//          and later print their name, department and town. Try the both variants: with and without .
//          Include(…). Compare the number of executed SQL statements and the performance.

namespace TelerikAcademyDatabase
{
    using System;

    public class EmployeesInclude
    {
        public static TelerikAcademyEntities db = new TelerikAcademyEntities();

        public static void Employer()
        {
            using (db)
            {
                PrintWithoutInclude();
                PrintWithInclude();
            }
        }
        public static void PrintWithoutInclude()
        {
            foreach (var e in db.Employees)
            {
                Console.WriteLine("ID: {0} First Name: {1} Town: {2}", e.Department.DepartmentID, e.FirstName, e.Address.Town.Name);
            }
        }
        public static void PrintWithInclude()
        {
            foreach (var em in db.Employees.Include("Department").Include("Address.Town"))
            {
                Console.WriteLine("ID: {0} First Name: {1} Town: {2}", em.Department.DepartmentID, em.FirstName, em.Address.Town.Name);
            }
        }
    }
}
