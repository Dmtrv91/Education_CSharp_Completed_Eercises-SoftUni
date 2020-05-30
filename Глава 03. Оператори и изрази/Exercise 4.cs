using System;

//Напишете израз, който да проверява дали третият бит на дадено число е 1 или 0.

namespace ConsoleAppGlava3Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The third bit of {0} is 1? {1}", n, ((n >> 3) & 1) == 1);
        }
    }
}
