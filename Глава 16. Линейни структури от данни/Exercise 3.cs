using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises3

//Напишете програма, която прочита от конзолата поредица от цели положителни числа.Поредицата спира, когато се въведе празен ред и ги сортира възходящо.

{
    class Program
    {
        public static void Main()
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numbers = new List<int>(n);

            Console.WriteLine("Number of elements is : " + numbers.Count);

            var numbersSorted = numbers.OrderBy(num => num).ToArray();
            Console.WriteLine(string.Join(", ", numbersSorted));
        }
    }
}

