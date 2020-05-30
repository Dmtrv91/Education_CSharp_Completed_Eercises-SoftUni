using System;

//Напишете програма, която чете от конзолата две цели числа (int) и отпечатва колко числа има между тях, такива, че остатъкът 
//им от деленето на 5 да е 0. Пример: в интервала (17, 25) има 2 такива числа.

namespace ConsoleAppGlava4Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
