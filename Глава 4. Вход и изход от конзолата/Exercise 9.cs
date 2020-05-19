using System;

//Напишете програма, която прочита едно цяло число n от конзолата. След това прочита още n на брой числа от конзолата и отпечатва тяхната сума.

namespace ConsoleAppConsoleAppGlava4Exercises9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers count: ");
            int number1 = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());

            for ( number1 = 0; number1 <= 10; number1++)
            {
                int summ = number1 + number2;
                Console.WriteLine("{0} + {1} = {2}", number1, number2, summ);
            }
        }
    }
}
