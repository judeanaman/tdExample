using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDStringExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);

            // Possible Substrings Of A Given String
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");

            string str;
            Console.WriteLine("Enter a string: ");

            str = Console.ReadLine();

            //This loop maintains the starting character 

            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder newString = new StringBuilder();


                //This loop adds the next character every iteration for the substring and then print

                for (int j = i; j < str.Length; j++)
                {
                    newString.Append(str[j]);

                    Console.Write(newString + " ");
                }
            }
            Console.ReadLine();
           
        }
    }
}
