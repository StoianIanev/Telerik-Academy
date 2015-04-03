
// Task 16 - Create a class Group with properties GroupNumber and DepartmentName. Introduce a property Group in the Student class. 
//           Extract all students from "Mathematics" department. Use the Join operator.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SelectByGroup
{
    public class Group
    {
        public int GroupNumber;
        public string DepartmentName;

        public Group(int GNumber, string DName)
        {
            this.GroupNumber = GNumber;
            this.DepartmentName = DName;
        }

        public int GNumber {get;set;}
       
        public string DName{get;set;}
        
    }
}
