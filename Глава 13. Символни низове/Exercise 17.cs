using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

//Напишете програма, която чете две дати, въведени във формат "ден.месец.година" и изчислява броя дни между тях.
//Enter the first date: 27.02.2006 Enter the second date: 3.03.2006 Distance: 4 days

namespace ConsoleAppGlava13Exercises17
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2006, 02, 27);
            DateTime d2 = new DateTime(2006, 03, 03);
           
            Console.WriteLine((d2 - d1).TotalDays);
        }
    }
}
