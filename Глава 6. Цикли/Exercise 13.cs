using System;

//Напишете програма, която преобразува дадено число от двоична в десетична бройна система.

namespace ConsoleAppGlava6Exercises13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
