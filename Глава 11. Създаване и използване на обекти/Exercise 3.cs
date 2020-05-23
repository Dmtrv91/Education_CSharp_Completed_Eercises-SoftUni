using System;

//Напишете програма, която извежда на конзолата кой ден от седмицата е днес.

namespace ConsoleAppGlava11Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
                DayOfWeek wk = DateTime.Today.DayOfWeek;
                Console.WriteLine(wk);  
        }
    }
}
