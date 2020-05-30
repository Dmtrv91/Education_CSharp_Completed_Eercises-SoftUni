using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises4
{
    //Напишете метод, който намира най-дългата подредица от равни числа в даден List<int> и връща като резултат нов List<int> с тази
    //подредица.Напишете програма, която проверява дали този метод работи коректно.

    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers = new List<int>(n);
            int count = 1;
            int longestNum = numbers[0];
            int longestCount = 1;

            for (int i = 1; i < n.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    count = 0;
                }
                count++;

                if (count > longestCount)
                {
                    longestCount = count;
                    longestNum = numbers[i];
                }
            }
            var result = new List<int>(longestCount);
            Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));
        }
    }
}
