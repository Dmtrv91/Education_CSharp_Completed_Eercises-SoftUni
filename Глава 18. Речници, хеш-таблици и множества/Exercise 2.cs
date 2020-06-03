using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava18Exercises2

//Напишете програма, която премахва всички числа, които се срещат нечетен брой пъти в дадена редица.Например, ако имаме началната редица
//{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6}, трябва да я редуцираме до редицата {5, 3, 3, 5}.

{
    class Program
    {
        private static bool isEven(int i)
        {
            return ((i % 2) == 0);
        }

        public static void Main(String[] args)
        {
            List<int> firstlist = new List<int>();

            firstlist.Add(4);
            firstlist.Add(2);
            firstlist.Add(2);
            firstlist.Add(5);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(1);
            firstlist.Add(5);
            firstlist.Add(2);
            firstlist.Add(6);
            firstlist.Add(6);
            firstlist.Add(6);

            Console.Write("Elements Present in List:\n");

            foreach (int k in firstlist)
            {
                Console.Write(k);
            }

            Console.WriteLine(" ");
            Console.Write("Number of Elements Removed: ");
            Console.WriteLine(firstlist.RemoveAll(isEven));
            Console.WriteLine(" ");
            Console.WriteLine("Remaining Elements in List:"); 
            foreach (int k in firstlist)
            {
                Console.WriteLine(k);
            }
        }
    }
}