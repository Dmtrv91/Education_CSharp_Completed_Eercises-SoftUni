using System;

//Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто(т.е.се дели без остатък само на себе си и на единица).

namespace ConsoleAppConsoleAppGlava3Exercises14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 72;
            bool isPrime = true;
            if (number > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(numbber)); ++i)
                {
                    if (number % i == 0) isPrime = false;
                }
            Console.WriteLine("{0} is prime?: {1}", number, isPrime);
        }
    }
}
