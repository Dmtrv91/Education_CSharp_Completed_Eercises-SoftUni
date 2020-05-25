using System;

//Напишете програма, която чете от конзолата стринг от максимум 20 символа и ако е по-кратък го допълва отдясно със "*" до 20 символа.

namespace ConsoleAppGlava13Exercises7
{
    class Program
    { 
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str.PadRight(20, '*');

            Console.WriteLine(str.PadRight(20, '*')); 
        }
    }
}
