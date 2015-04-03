
//Task 3- Write a program that enters file name along with its full file path 
//        (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. 
//        Find in MSDN how to use System.IO.File.ReadAllText(…). 
//        Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _03.ReadingAFile
{
    class ReadingAFile
    {
        static void Main()
        {
            //Console.Write("Enter file name: ");
            //string fileName = Console.ReadLine();

           string fileName = " C:\\WINDOWS\\win.ini";
            
            try
            {
                StreamReader reader = new StreamReader(fileName);
                
                using (reader)
                {
                    Console.WriteLine("File {0} successfully opened.", fileName);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Can not find {0}", fileName);

            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid directory!");
            }
            catch (IOException)
            {
                Console.WriteLine("The file {0} can not open.", fileName);
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine(uae.Message);
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have the required permission to access this file!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entered file path is not correct!");
            }
          
        }
    }
}
