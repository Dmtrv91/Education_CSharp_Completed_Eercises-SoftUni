using System;

//Да се напише програма, която преобразува двоично число в десетично по схемата на Хорнер.

namespace ConsoleAppGlava8Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            int deci = 0;

            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("Result is {0}.", deci);
        }
    }
}


  