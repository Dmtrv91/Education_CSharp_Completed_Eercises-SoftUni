using System;

//Напишете програма, която за дадени цели числа n и x, пресмята сумата: .

namespace ConsoleAppGlava6Exercises9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, temp = 1;
            int n = Int32.Parse(Console.ReadLine());
            int x = Int32.Parse(Console.ReadLine());
          
            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }
            Console.WriteLine("{0} ", sum);
        }
    }
}
