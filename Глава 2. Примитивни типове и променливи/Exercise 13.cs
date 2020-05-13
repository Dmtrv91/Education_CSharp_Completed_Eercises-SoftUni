using System;

namespace ConsoleAppGlava2Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            string sum = "Sum = " + (a + b);
            Console.WriteLine(sum);
            String incorrect = "Sum=  " + a + b;
            Console.WriteLine(incorrect);
            Console.WriteLine("Perimeter = " + 2 * (a + b) + ". Area = " + (a * b) + ".");
        }
    }
}