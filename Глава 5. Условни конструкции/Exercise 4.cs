using System;

//Сортирайте 3 реални числа в намаляващ ред. Използвайте вложени if оператори.

namespace ConsoleAppGlava5Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine("Furst a {0} , second b {1} and last c {2}", a, b, c);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("Furst a {0} , second c {1} and last b {2}", a, c, b);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("Furst b {0} , second a {1} and last c {2}", b, a, c);
            }
            else if (b > c && c > a)
            {
                Console.WriteLine("Furst b {0} , second c {1} and last a {2}", b, c, a);
            }
            else if (c > a && a > b)
            {
                Console.WriteLine("Furst c {0} , second a {1} and last b {2}", c, a, b);
            }
            else if (c > b && b > a)
            {
                Console.WriteLine("Furst c {0} , second b {1} and last a {2}", c, b, a);
            }
        }
    }
}
