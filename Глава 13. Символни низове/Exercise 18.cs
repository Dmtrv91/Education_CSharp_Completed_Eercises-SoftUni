using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

//Напишете програма, която чете дата и час, въведени във формат
//"ден.месец.година час:минути:секунди" и отпечатва датата и часа след
//6 часа и 30 минути, в същия формат.

namespace ConsoleAppGlava13Exercises18
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] hours = {6.5};
            DateTime dateValue = DateTime.Now;

            foreach (double hour in hours)
                Console.WriteLine("{0} + {1} hour(s) = {2}", dateValue, hour, dateValue.AddHours(hour));
        }
    }
}
