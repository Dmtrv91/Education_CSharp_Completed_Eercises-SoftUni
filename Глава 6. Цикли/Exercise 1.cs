using System;

//Напишете програма, която отпечатва на конзолата числата от 1 до N.

namespace ConsoleAppConsoleAppGlava6Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
                Console.WriteLine(i);
        }
    }
}
