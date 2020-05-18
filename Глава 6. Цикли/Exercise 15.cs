using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете програма, която преобразува дадено число от шестнайсетична в десетична бройна система.

namespace ConsoleAppGlava6Exercises15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}