using System;

//Даден е масив с цели положителни числа. Напишете програма, която проверява дали в масива съществуват едно или повече числа(под-
//множество), чиято сума е N.Можете ли да решите задачата без рекурсия?

namespace ConsoleAppGlava10Exercises9
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Enter array length: ");
                int length = Int32.Parse(Console.ReadLine());
                int[] arr = new int[length];

                for (int i = 0; i < length; i++)
                {
                    Console.Write("Enter {0} element: ", i + 1);
                    arr[i] = Int32.Parse(Console.ReadLine());
                }

                Console.Write("Enter sum: ");
                int sum = Int32.Parse(Console.ReadLine());

                for (int i = 0; i < arr.Length; i++)
                {
                    int first = arr[i];
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        int second = arr[j];

                        if ((first + second) == sum)
                            Console.WriteLine("({0}, {1}) ", first, second);
                    }
                }
            }
    }
}