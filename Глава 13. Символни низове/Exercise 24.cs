using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Globalization;
using System.Linq;

//Напишете програма, която чете от конзолата списък от думи, разделени със запетайки и ги отпечатва по азбучен ред(след сортиране).

namespace ConsoleAppGlava13Exercises24
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            
            string[] aray = s.Split(",");

            char[] array = { 'z', 'a', 'b' };

            Console.WriteLine("UNSORTED: " + new string(array));

            Array.Sort<char>(array);
            Console.WriteLine("SORTED: " + new string(array));
        }
    }
}
   
    