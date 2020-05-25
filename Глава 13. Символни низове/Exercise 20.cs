using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Globalization;

//Напишете програма, която извлича от даден текст всички дати, които се срещат изписани във формат DD.MM.YYYY и ги отпечатва на
//конзолата в стандартния формат за Канада.Примерен текст:
//I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section
//7.3.12) that we are allowed to do this (section 7.4.2.9).
//Отговор 14.06.1980 3.7.1984

namespace ConsoleAppGlava13Exercises20
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringWithDate = "I was born at 14.06.1980. My sister was born at 3.7.1984. In " +
                "01/05/1999 I graduated my high school.The law says(see section " +
                "7.3.12) that we are allowed to do this(section 7.4.2.9).";
            Match match = Regex.Match(stringWithDate, @"\d{2}.\d{2}.\d{4}");
            Match match1 = Regex.Match(stringWithDate, @"\d{1}.\d{1}.\d{4}");
            string date = match.Value;
            string date1 = match1.Value;
            
           if (!string.IsNullOrEmpty(date))
            {
               var dateTime = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.CurrentCulture);
               Console.WriteLine(dateTime.ToString());
            }

            if (!string.IsNullOrEmpty(date1))
            {
                var dateTime = DateTime.ParseExact(date1, "d/M/yyyy", CultureInfo.CurrentCulture);
                Console.WriteLine(dateTime.ToString());
            }
        }
    }
}
