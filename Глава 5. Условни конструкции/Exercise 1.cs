using System;

//Да се напише if конструкция, която проверява стойността на две цело- числени променливи и разменя техните стойности, ако стойността на първата променлива е по-голяма от втората.

namespace ConsoleAppGlava5Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            int biggerNumber = a;
            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine("First number - {0}, Second number - {1}.", a, b);
        }
    }
}
