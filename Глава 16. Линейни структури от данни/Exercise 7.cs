
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace ConsoleAppGlava16Exercises7

//Напишете програма, която по даден масив от цели числа в интервала [0..1000] намира по колко пъти се среща всяко число.
//Пример: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2} 2 → 2 пъти 3 → 4 пъти 4 → 3 пъти

{
    class Program
    {
        public static void Main()
        {
            int[] num = { 3, 4, 4, 2, 3, 3, 4, 3 };
            int[] count = new int[10];

            for (int x = 0; x < 10; x++)
                for (int y = 0; y < num.Length; y++)
                    if (num[y] == x)
                        count[x]++;
          
            for (int x = 0; x < 10; x++)
                Console.WriteLine("Number " + x + " appears " + count[x] + " times");
        }
    }
}
