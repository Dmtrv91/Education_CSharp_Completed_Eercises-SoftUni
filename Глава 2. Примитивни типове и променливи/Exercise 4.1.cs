using System;

//Напишете програма, която сравнява вярно две реални числа с точност до 0.000001.

namespace ConsoleAppGlava2Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            decimal furstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            decimal secondNimber = decimal.Parse(Console.ReadLine());
            bool comparing = (Math.Abs(furstNumber - secondNimber) < 0.0000001m);
            Console.WriteLine(comparing);
        }
    }
}
