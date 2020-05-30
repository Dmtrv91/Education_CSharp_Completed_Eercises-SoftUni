using System;

//Напишете програма, която намира последователност от числа, чиято сума е максимална. Пример: { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8} → 11

namespace ConsoleAppGlava7Exercises9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, tenpSum = 0;

            Console.Write("Enter array lenght: ");
            int lenght = Int32.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            for(int i = 0; i < lenght; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for(int i = 0; i < lenght - 1; i++)
            {
                tenpSum = arr[i];
               for(int j = i+1; j < lenght; j++)
                {
                    tenpSum += arr[j];
                    if (tenpSum > sum) sum = tenpSum;
                }
            }
            Console.WriteLine("Result is {0}. ", sum);
        }
    }
}
