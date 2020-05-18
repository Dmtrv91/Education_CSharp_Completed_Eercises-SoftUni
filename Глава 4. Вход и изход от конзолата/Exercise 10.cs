using System;

//Напишете програма, която прочита цяло число n от конзолата и отпечатва на конзолата всички числа в интервала [1…n], всяко на отделен ред.

namespace ConsoleAppGlava4Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            for( int i = 1; i <= number; i++)
            Console.WriteLine(i);
        }
    }
}
 
