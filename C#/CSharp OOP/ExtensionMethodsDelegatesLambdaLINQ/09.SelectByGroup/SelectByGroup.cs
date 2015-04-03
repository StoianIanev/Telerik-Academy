using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SelectByGroup
{
   public class SelectByGroup
    {
           private static List<Students> students = new List<Students>()
            {
                new Students("Pesho","Penev","123406","+359897452132","www.pesho@abv.bg",1, 3, 2, 2, 5, 4, 6),
                new Students("Mariq","Daneva","123305","+3592896321419","www.mariq@abv.bg", 4, 5, 2, 3, 5, 3, 4),
                new Students("Ana","Toneva","214705","0289147225","www.ana@yahoo.com", 3, 3, 3, 3, 5, 4, 6),
                new Students("Milka","Ivanova","189408","+359891645120","www.milka@yahoo.com", 2, 5, 5, 4, 6, 6, 6),
                new Students("Kristina","Maneva","114406","+3592887223148","www.kristina@abv.bg", 2, 3, 3, 3, 6, 4, 2)
            };

       private static void Task9()
       {
           Console.WriteLine("Task 9");
            Console.WriteLine();
            var groupNumbers =
                from student in students
                where student.GroupNumber == 2
                select student;

            Console.WriteLine("The students which are from 2 group are:");
            foreach (var item in groupNumbers)
            {
                Console.WriteLine(item.firstName + " " + item.lastName);
            }


            // Order the students by FirstName. 

            var orderStudents =
                from student in students
                orderby student.firstName
                select student;

            Console.WriteLine();
            Console.WriteLine("Order the students by FirstName");     
            foreach (var stud in orderStudents)
            {
                Console.WriteLine(stud.firstName + " " + stud.lastName);
            } 

       }
       private static void Task10()
       {
           // select and sort students by first name with extension methods.  
           Console.WriteLine();
           Console.WriteLine("Task 10");
           var extension = students.SelectedAndOrderTheStudents(2);
           Console.WriteLine("The students which are from 2 group are:");
           foreach (var st in extension)
           {
               Console.WriteLine(st.firstName + " " + st.lastName);
           }
       }

       private static void Task11()
       {
           // Task 11- Extract all students that have email in abv.bg. Use string methods and LINQ.

           Console.WriteLine();
           Console.WriteLine("Task 11");
           var studentsWithMailABV =
               from student in students
               where student.email.Substring(student.email.LastIndexOf("@")) == "@abv.bg"
               select student;

           foreach (var student in studentsWithMailABV)
           {
               Console.WriteLine(student.firstName + " " + student.lastName + " " + "with abv: " + student.email);
           }

       }
       private static void Task12()
       {
           // Task 12- Extract all students with phones in Sofia. Use LINQ.

           Console.WriteLine();
           Console.WriteLine("Task 12");
           var studentsWithPhoneInSofia =
               from student in students
               where student.tel.StartsWith("+3592") || student.tel.StartsWith("02")
               select student;
           Console.WriteLine("Students with phones in Sofia");
           foreach (var st in studentsWithPhoneInSofia)
           {
               Console.WriteLine(st.firstName + " " + st.lastName + " " + "with telephone number: " + st.tel);
           }
       }

       private static void Task13()
       {
           // Task 13- Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.

           var marksOfStudent =
               from mark in students
               where mark.marks.Any(x => x == 6)
               select new { mark.firstName,mark.lastName, Marks = string.Join(" ", mark.Marks) };
           Console.WriteLine();
           Console.WriteLine("Task13");
           Console.WriteLine("Students that have at least one mark Excellent (6)");
           foreach (var mark in marksOfStudent)
           {
               Console.WriteLine(mark.firstName + " " + mark.lastName + " with marks: " + mark.Marks);
           }
           
       }
       private static void Task14()
       {
           // Task 14- Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.

           Console.WriteLine();
           Console.WriteLine("Task 14");
           Console.WriteLine("Students with exactly two marks weak (2)");
           List<Students> studentsMarks = students.SelectByMarks2();
           foreach (var student in studentsMarks)
           {
               Console.WriteLine(student.firstName + " " + student.lastName + " with exactly two marks weak (2): " + string.Join(" ",student.marks));
               
           }
       }
       private static void Task15()
       {
           // Task 15- Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

           var student =
               from st in students
               where st.fn.EndsWith("06") || st.fn.EndsWith("05")
               select st;
           Console.WriteLine();
           Console.WriteLine("Task 15");
           foreach (var stud in student)
           {
               Console.WriteLine(stud.firstName + " " + stud.lastName + " with faculty number: "  + stud.fn + " with marks: " + string.Join(" ",stud.marks));
           }
       }
       private static void Task16()
       {
          
           List<Group> groups = new List<Group>()
           {
               new Group(1,"History"),
               new Group(2,"English"),
               new Group(3,"Mathematics"),
               new Group(4,"Art"),
               new Group(5,"Biology")

           };

           var studentsFromGroupMathematics =
               from student in students
               join gr in groups
               on student.groupNumber equals gr.GroupNumber
               where gr.DepartmentName == "Math" || gr.DepartmentName == "Mathematics"
               select student;

           Console.WriteLine();
           Console.WriteLine("Task 16");
           Console.WriteLine("All students from Mathematics department");
           foreach (var student in studentsFromGroupMathematics)
           {
               Console.WriteLine(student.firstName + " " + student.lastName);            
           }
       }
        static void Main()
        {
            Task9();
            Task10();
            Task11();
            Task12();
            Task13();
            Task14();
            Task15();
            Task16();
        }
        
    }
}
