using System;

//Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.

namespace ConsoleAppGlava4Excercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Result is {0}", a + b + c);
        }
    }
}
