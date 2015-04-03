
// Task 12- Write a program that parses an URL address given in the format:
//         [protocol]://[server]/[resource]
//         and extracts from it the [protocol], [server] and [resource] elements. 
//         For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		   [protocol] = "http"
//		   [server] = "www.devbg.org"
//		   [resource] = "/forum/index.php"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            Console.Write("Enter URL adress: ");
            string url = Console.ReadLine();

            int offset =  url.IndexOf(":");
            string protocol = url.Substring(0, offset);
            Console.WriteLine("[protocol] = {0}",protocol);

            int slash = url.IndexOf("//");
            int nextSlash = url.IndexOf("/", slash + 2);

            string server = url.Substring(slash + 2, nextSlash - slash - 2);
            Console.WriteLine("[server] = {0}", server);

            string resurce = url.Substring(nextSlash, url.Length - nextSlash);
            Console.WriteLine("[resource] = {0}", resurce);
            

        }
    }
}
