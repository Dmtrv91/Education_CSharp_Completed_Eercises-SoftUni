using System;

//Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7.Числото N да се чете от стандартния вход.

namespace ConsoleAppGlava6Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }    
        }
    }
}

