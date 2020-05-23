using System;

//Напишете програма, която прочита от конзолата година и проверява дали е високосна.

namespace ConsoleAppGlava11Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = Int32.Parse(Console.ReadLine());
            if ((((year % 4) == 0) && ((year % 100) != 0) || ((year % 400) == 0)))
                Console.WriteLine("{0} is leap year.", year);
            else
                Console.WriteLine("{0} isn't a leap year.", year);
        }
    }  
}
