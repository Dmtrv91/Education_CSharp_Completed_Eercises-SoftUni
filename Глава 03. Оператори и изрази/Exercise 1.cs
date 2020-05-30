using System;

//1. Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

namespace ConsoleAppGlava3Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            decimal sumEven = 0;
            decimal sumOdd = 0;
            int y = 0;

            for (int i = 1; i > 0; i++)
            {
                y = (int)(N % 10);

                if (y % 2 == 0)
                {
                    sumEven = sumEven + y;
                }
                else
                {
                    sumOdd = sumOdd + y;
                }

                N = N / 10;

                if (N == 0 || N < 0)
                {
                    break;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine("straight");
            }
            else if (sumEven > sumOdd)
            {
                Console.WriteLine("True");
            }
            else if (sumOdd > sumEven)
            {
                Console.WriteLine("False");
            }

        }
    }
}
      