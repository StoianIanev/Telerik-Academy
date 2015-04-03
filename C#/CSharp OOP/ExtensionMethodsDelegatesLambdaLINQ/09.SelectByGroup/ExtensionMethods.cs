using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SelectByGroup
{
    public static class ExtensionMethods
    {
        // Task 10- Implement the previous using the same query expressed with extension methods.

        public static List<Students> SelectedAndOrderTheStudents(this List<Students> list, int groupNum)
        {
           var students =
                from stud in list
                where stud.groupNumber == groupNum
                orderby stud.firstName descending
                select stud;
           
		 
            return students.ToList();
	    }

        // Task 14- Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.

        public static List<Students> SelectByMarks2(this List<Students> marks)
        {
            var students =
                from std in marks
                where std.marks.Count(x => x == 2) == 2
                select std;

            return students.ToList();
        }
		 
     }
        
    
}
