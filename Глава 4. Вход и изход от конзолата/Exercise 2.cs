using System;

//Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговото лице и обиколка.

namespace ConsoleAppConsoleAppGlava4Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Int32.Parse(Console.ReadLine());
             
            Console.WriteLine("P is: {0} and S is {1}", 2 * Math.PI * r, Math.PI * r * r);
        }
    }
}
