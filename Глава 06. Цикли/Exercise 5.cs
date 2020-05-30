using System;

//Напишете програма, която чете от конзолата числото N и отпечатва сумата на първите N члена от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

namespace ConsoleAppGlava6Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            int furstN = 0;
            int secondN = 1;
            int thirdN = 0;

            Console.Write("Number N: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("0, 1, ");

            for (int i = 2; number > i; i++)
            {
                thirdN = furstN + secondN;
                Console.Write(" {0},", thirdN);
                furstN = secondN;
                secondN = thirdN;
            }
        }
    }
}
