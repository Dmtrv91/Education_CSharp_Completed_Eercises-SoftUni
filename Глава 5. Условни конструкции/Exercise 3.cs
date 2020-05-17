using System;

//Напишете програма, която намира най-голямото по стойност число,измежду три дадени числа.

namespace ConsoleAppGlava5Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine()); 
            int b = Int32.Parse(Console.ReadLine()); 
            int c = Int32.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Number a = {0} is the bigest",a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("Number b = {0} is the bigest", b);
            }
            else if (c > a && b < c)
            {
                Console.WriteLine("Number c = {0} is the bigest", c);
            }
        }
    }
}
