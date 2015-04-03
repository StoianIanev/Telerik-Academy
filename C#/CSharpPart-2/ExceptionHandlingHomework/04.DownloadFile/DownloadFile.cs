
// Task 4- Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
//         Find in Google how to download files in C#. 
//         Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            //Console.Write("Enter URL address: ");
            //string address = Console.ReadLine();
            string address = "http://www.devbg.org/img/Logo-BASD.jpg";
            string directory = Environment.ExpandEnvironmentVariables(@"%UserProfile%\Desktop\g.jpg");

            try
            {
                WebClient file = new WebClient();
                file.DownloadFile(address, directory);
                using (file)
                {
                    Console.WriteLine("The file is downloaded successfully!");
                }

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You entered an empty address.");
            }
            catch(WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch(NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
        }
    }
}
