using System;

//Напишете метод ReadNumber(int start, int end), който въвежда от конзолата число в диапазона[start…end]. В случай на въведено невалидно число или число, което не е в подадения диапазон, хвърлете
//подходящо изключение.Използвайки този метод напишете програма, която въвежда 10 числа a1, a2, …, a10, такива, че 1 < a1< … < a10< 100.

namespace ConsoleAppGlava12Exercises8
{
    class Program
    {
        static void ReadNumber(int start, int end)
        {
            int count = 1, number;

            do
            {
                Console.Write("Number {0}: ", count);
                number = Int32.Parse(Console.ReadLine());

                if (number >= end || number <= start)
                {
                    Console.WriteLine("Wrong input");
                        break;
                }
                else
                    start = number;

                count++;
            } while (count < 11);
        }
        static void Main(string[] args)
        {
            Console.Write("Start: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = Int32.Parse(Console.ReadLine());

            if (end <= start + 10)
                Console.WriteLine("Wrong input");
            else
                ReadNumber(start, end);
        }
    }
}
