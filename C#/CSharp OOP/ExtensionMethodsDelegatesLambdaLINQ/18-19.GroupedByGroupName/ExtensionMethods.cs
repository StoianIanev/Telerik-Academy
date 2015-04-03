using System;
using System.Collections.Generic;
using System.Linq;
namespace _18_19.GroupedByGroupName
{
    public static class ExtensionMethods
    {
        public static List<Students> OrderByGroupName(this List<Students> list) 
        {
            var listOfStudents = list.OrderByDescending(x => x.GroupName);

            return listOfStudents.ToList();
        }
    }
}
