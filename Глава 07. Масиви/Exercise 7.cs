using System;

//Да се напише програма, която чете от конзолата две цели числа N и K(K < N), както и масив от N елемента. Да се намерят тези K поредни елемента, които имат максимална сума.

namespace ConsoleAppGlava7Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K (K < N): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("\nBiggest sum is {0}", sum);
        }
    }
}
