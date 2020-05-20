using System;

//Напишете програма, която намира максималната редица от последователни нарастващи елементи в масив.Пример: {3, 2, 3, 4, 2, 2, 4} → { 2, 3, 4}.

namespace ConsoleAppGlava7Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array Lenght: ");
            int lenght = Int32.Parse(Console.ReadLine());

            int[] arr = new int[lenght];

            int sames = 1, bestSame = 1, bestStart = 0, lastElement = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} elementi: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    sames++;
                    if (sames > bestSame)
                    {
                        bestSame = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSame + 1;
                    }
                }
                else sames = 1;
            }
            for (int i = bestStart; i < bestSame + bestStart; i++) Console.Write("{0}, ", arr[i]);
        }
    }
}
