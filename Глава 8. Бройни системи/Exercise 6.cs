using System;

//Да се напише програма, която преобразува десетично число в шестнадесетично.

namespace ConsoleAppGlava8Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0} to hexadecimal is {1}: ", deci, deci.ToString("X"));
        }
    }
}
