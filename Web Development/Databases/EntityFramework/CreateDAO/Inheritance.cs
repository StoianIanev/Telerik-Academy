
// Task 8- By inheriting the Employee entity class create a class which allows employees to access their corresponding 
//        territories as property of type EntitySet<T>.

namespace CreateDAO
{
    using System;
    using System.Linq;
   
    public partial class Inheritance
    {
        public static void Inherit()
        {
            using (var db = new NorthwindEntities())
            {
                foreach (var teritory in db.Employees.First().Territories)
                {
                    Console.WriteLine(teritory.TerritoryDescription);
                }
            }
        }
    }
}
