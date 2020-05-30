using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises6

//Напишете програма, която при дадена редица изтрива всички числа, които се срещат нечетен брой пъти.
//Пример: array = {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}

{
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