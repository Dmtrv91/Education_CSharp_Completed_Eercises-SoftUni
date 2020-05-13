using System;

// Напишете булев израз, който да проверява дали дадено цяло число се дели и на 5, и на 7 без остатък.

namespace ConsoleAppGlava3Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool even = n % 35 == 0 ? true : false;

            Console.WriteLine("{0} is even? {1}", n, even);
        }
    }
}