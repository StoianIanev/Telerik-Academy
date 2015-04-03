
// Task 7 - Declare two string variables and assign them with “Hello” and “World”. 
//      Declare an object variable and assign it with the concatenation 
//      of the first two variables (mind adding an interval). 
//    Declare a third string variable and initialize it with the value of the object variable 
//    (you should perform type casting).


using System;

namespace StringAndObject
{
    class StringAndObject
    {
        static void Main()
        {
            string greeting = "Hello";
            string word = "World";

            object sentence = greeting +" "+ word;
            Console.WriteLine(sentence);
        }
    }
}
