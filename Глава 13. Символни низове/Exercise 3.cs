using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava13Exercises3
{
    class Program
    {

        //Напишете програма, която проверява дали в даден аритметичен
        //израз скобите са поставени коректно.Пример за израз с коректно
        //поставени скоби: ((a+b)/5-d). Пример за некоректен израз: )(a+b)).

        public static void Main()
        {
            string source = Console.ReadLine();
            int open = source.Length - source.Replace("(", "").Length;
            int close = source.Length - source.Replace(")", "").Length;

            if (open == close)
            {
                Console.WriteLine("Balansed");
            }
            else
            {
                Console.WriteLine("UnBlansed");
            }
        }
    }
}