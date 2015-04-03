
//Task 7- Write a program that encodes and decodes a string using given encryption key (cipher). 
//        The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
//        of the string with the first of the key, the second – with the second, etc. 
//        When the last key character is reached, the next is the first.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodingOnText
{
    class EncodingOnText
    {
            static void Main()
            {
                Console.Write("Enter string: ");
                string str = Console.ReadLine();
                Console.Write("Enter cipher: ");
                string cipher = Console.ReadLine();
                Console.WriteLine("Decrypt--> {0}",Encrypt(str,cipher));
                Console.WriteLine("Encrypt--> {0}",Decrypt(Encrypt(str,cipher),cipher));

            }
            static string Encrypt(string str, string key)
            {
                StringBuilder encrypt = new StringBuilder();
                for (int i = 0,k=0; i < str.Length; i++,k++)
                {
                    if (k == key.Length)  k=0;
                    encrypt.Append((char)(str[i] ^ key[k % key.Length]));       
                }
               return encrypt.ToString();

            }
            static string Decrypt(string str, string key)
            {
                return Encrypt(str, key);
            }
        }
       
    }

