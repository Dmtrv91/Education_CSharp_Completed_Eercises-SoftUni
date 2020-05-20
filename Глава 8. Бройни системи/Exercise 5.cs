using System;

//Да се напише програма, която преобразува двоично число в десетично.

namespace ConsoleAppGlava8Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();

            Console.WriteLine("{0} to decimal is {1}: ", binary, Convert.ToInt32(binary, 2));
        }
    }
}
