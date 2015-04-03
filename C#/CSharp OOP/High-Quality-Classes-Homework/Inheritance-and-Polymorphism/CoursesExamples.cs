using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    class CoursesExamples
    {
        static void Main()
        {
            IList<Students> students = new List<Students>()
            {
                new Students("Peter"), 
                new Students("Maria")

            };

            LocalCourse localCourse = new LocalCourse("Databases", "Svetlin Nakov",students, "Enterprise");
            Console.WriteLine(localCourse);

            Console.WriteLine();
            students.Add(new Students("Milena"));
            students.Add(new Students("Todor"));           
            Console.WriteLine(localCourse);

            Console.WriteLine();
            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev", students, "Burgas");
            Console.WriteLine(offsiteCourse);
            Console.WriteLine();
        }
    }
}
