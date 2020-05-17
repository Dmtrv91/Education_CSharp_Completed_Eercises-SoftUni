using System;

//Напишете програма, която намира най-голямото по стойност число измежду дадени 5 числа.

namespace ConsoleAppGlava5Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int d = Int32.Parse(Console.ReadLine());
            int e = Int32.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e)
            {
                Console.WriteLine("The bigest number is A {0}!", a);
            }
            else if (b > a && b > c && b > d && b > e)
            {
                Console.WriteLine("The bigest number is B {0}!", b);
            }
            else if (c > a && c > b && c > d && c > e)
            {
                Console.WriteLine("The bigest number is C {0}!", c);
            }
            else if (d > a && d > b && d > c && d > e)
            {
                Console.WriteLine("The bigest number is D {0}!", d);
            }
            else if (e > a && e > b && e > c && e > d)
            {
                Console.WriteLine("The bigest number is E {0}!", e);
            }
        }
    }
}
