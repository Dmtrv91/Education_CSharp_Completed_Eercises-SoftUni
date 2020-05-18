using System;

//Напишете програма, която преобразува дадено число от десетична в шестнайсетична бройна система.

namespace ConsoleAppGlava6Exercises14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
