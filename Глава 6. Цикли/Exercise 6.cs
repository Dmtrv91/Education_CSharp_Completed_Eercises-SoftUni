using System;

//Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).

namespace ConsoleAppGlava6Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());

            for (int i = n - 1; i > 1; i--)
            {
                n *= i;
            }
            for (int i = k - 1; i > 1; i--)
            {
                k *= i;
            }
            n /= k;

            Console.WriteLine("{0}", n);
        }
    }
}
