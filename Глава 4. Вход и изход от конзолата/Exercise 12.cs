 using System;

//Напишете програма, която пресмята сумата (с точност до 0.001): 1+ 1/2 + 1/3 + 1/4 + 1/5 + ...

namespace ConsoleAppConsoleAppGlava4Excercises13
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter last number: ");
                int length = Int32.Parse(Console.ReadLine());
                double sum = 1.0;

                for (int i = 2; i <= length; i++)
                {
                    sum += (1.0 / i);
                }
                Console.WriteLine("{0:F3}", sum);
            }
        }
    }
}
