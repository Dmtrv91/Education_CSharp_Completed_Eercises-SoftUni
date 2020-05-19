using System;

//Да се напише програма, която преобразува шестнадесетично число в десетично.

namespace ConsoleAppGlava8Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Hexadecimal number: ");
            string hexa = (Console.ReadLine());

            Console.WriteLine("{0} to decimal is: {1} ", hexa, Convert.ToInt32(hexa, 16));
        }
    }
}
