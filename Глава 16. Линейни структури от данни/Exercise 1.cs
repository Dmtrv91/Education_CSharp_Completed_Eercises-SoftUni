using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises1

//Напишете програма, която прочита от конзолата поредица от цели положителни числа.Поредицата спира, когато се въведе празен ред.
//Програмата трябва да изчислява сумата и средното аритметично на поредицата.Използвайте List<int>.

{
    class Program
    {
        public static void Main()
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numbers = new List<int>(n);

            Console.WriteLine("Number of elements is : " + numbers.Count);
           
            int sum = numbers.Take(4).Sum();
            double average = numbers.Average();

            Console.WriteLine("The sum of numbers is: {0} and The average of numbers is: {1} ", sum, (average));
            Console.WriteLine(average);
        }
    }
}

