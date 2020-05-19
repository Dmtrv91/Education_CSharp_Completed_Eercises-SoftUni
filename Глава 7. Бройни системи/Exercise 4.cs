using System;

//Да се напише програма, която преобразува десетично число в двоично. 

namespace ConsoleAppGlava8Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter Decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} to binary is {1}).", deci, Convert.ToString(deci, 2));
        }
    }
}
       