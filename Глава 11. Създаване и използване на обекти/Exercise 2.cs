using System;

//Напишете програма, която генерира и принтира на конзолата 10 случайни числа в интервала[100, 200].

namespace ConsoleAppGlava11Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            Console.WriteLine(r.Next(100, 201));
        }
    }
}
