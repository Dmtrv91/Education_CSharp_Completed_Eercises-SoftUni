using System;

//Да се напише програма, която намира последователност от числа в масив, които имат сума, равна на число S, въведено от конзолата
//(ако има такава). Пример: {4, 3, 1, 4, 2, 5, 8}, S=11 → {4, 2, 5}.

namespace ConsoleAppGlava7Exercises11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, start = 0, end = 0;
            bool sumFound = false;

            Console.Write("Enter S: ");
            int s = Int32.Parse(Console.ReadLine());

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                sum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                }

                if (sumFound) break;
            }

            if (sumFound) for (int i = start; i <= end; i++) Console.Write("{0},", arr[i]);
            else Console.WriteLine("No sum found.");
        }
    }
}