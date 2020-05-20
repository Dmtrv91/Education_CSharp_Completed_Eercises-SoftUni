using System;

//Да се напише програма, която преобразува двоично число в шестнадесетично.

namespace ConsoleAppGlava8Exercises9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to hexadecimal is: {1}", binary, Convert.ToInt32(binary, 2).ToString("X"));
        }
    }
}
