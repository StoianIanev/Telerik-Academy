
// Task 18- Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
// Task 19- Rewrite the previous using extension methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_19.GroupedByGroupName
{
    public class GroupedByGroupName
    {
       private static List<Students> students = new List<Students>()
            {
                new Students("Pesho Peev","Goal"),
                new Students("Ivo Milchev","Millenium"),
                new Students("Ana Peeva","Greaters"),
                new Students("Kristina Staneva","Greaters")
            };
        static void Main()
        {
            //Task 18
          var groupNum=
              from gNum in students
              orderby gNum.GroupName descending
              select gNum;

          Console.WriteLine("Task 18");
          foreach (var item in groupNum)
          {
              Console.WriteLine(item.FullName + " " + item.GroupName);
          }     
 

            //Task 19
          Console.WriteLine();
          Console.WriteLine("Task 19");
          var list = students.OrderByGroupName();

          foreach (var item in list)
          {
              Console.WriteLine(item.FullName + " " + item.GroupName);
          }
              


        }
    }
}
