using System;

//Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K(1 < K < N).

namespace ConsoleAppGlava6Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            int nMinusK = n - k;

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            for (int i = nMinusK - 1; i > 0; i--)
            {
                nMinusK *= i;
            }
            Console.WriteLine("{0}", n * k / nMinusK);
        }
    }
}
