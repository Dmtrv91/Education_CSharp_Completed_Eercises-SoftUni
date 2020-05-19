using System;

//Да се напише програма, която преобразува шестнадесетично число в двоично.

namespace ConsoleAppGlava8Exercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number : ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1} ", hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
        }
    }
}
