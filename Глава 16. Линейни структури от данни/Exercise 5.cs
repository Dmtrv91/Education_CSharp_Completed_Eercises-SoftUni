using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises5
{
    //Напишете програма, която премахва всички отрицателни числа от дадена редица.
    // Пример: array = { 19, -10, 12, -6, -3, 34, -2, 5} → {19, 12, 34, 5}

    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(' ').Select(int.Parse).Reverse().ToList();
            List<int> sequence2 = new List<int>();
            foreach (var num in sequence)
            {
                if (num > 0)
                {
                    sequence2.Add(num);
                }
            }
            if (sequence2.Count < 1)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", sequence2));
            }
        }
    }
}
