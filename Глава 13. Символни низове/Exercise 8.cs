using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Напишете програма, която преобразува даден стринг във вид на поредица от Unicode екраниращи последователности.Примерен входен стринг: "Test". Резултат: "\u0054\u0065\u0073\u0074".

namespace ConsoleAppGlava13Exercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            byte[] unibyte = Encoding.Unicode.GetBytes(str);
            string uniString = string.Empty;
            foreach (byte b in unibyte)
            {
                uniString += string.Format("{0}{1}", @"\u", b.ToString("X"));
            }
            Console.WriteLine(uniString);
        }
    }
}