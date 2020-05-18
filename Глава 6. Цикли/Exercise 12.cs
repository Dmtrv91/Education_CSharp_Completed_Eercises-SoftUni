using System;

//Напишете програма, която преобразува дадено число от десетична в двоична бройна система.

namespace ConsoleAppGlava6Exercises12
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());

            string binary = Convert.ToString(number, 2);
            Console.WriteLine("{0} ", binary);
        }
    }
}
