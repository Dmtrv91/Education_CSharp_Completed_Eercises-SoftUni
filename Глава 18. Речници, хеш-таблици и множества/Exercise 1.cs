using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava18Exercises1

//Напишете програма, която брои колко пъти се среща всяко число в дадена редица от числа.
//Пример: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//2 → 2 пъти
//3 → 4 пъти
//4 → 3 пъти

{
    class Program
    {
        static void Main()
        {
            string[] values = { "3", "4", "4", "2", "3", "3", "4", "3", "2" };
            List<string> valuesList = new List<string>(values);

            var freqs = GetFrequencies(valuesList);
            DisplaySortedFrequencies(freqs);
        }

        static Dictionary<string, int> GetFrequencies(List<string> values)
        {
            var result = new Dictionary<string, int>();
            foreach (string value in values)
            {
                if (result.TryGetValue(value, out int count))
                {
                    result[value] = count + 1;
                }
                else
                {
                    result.Add(value, 1);
                }
            }
            return result;
        }

        static void DisplaySortedFrequencies(Dictionary<string, int> frequencies)
        {
            var sorted = from pair in frequencies
                         orderby pair.Value descending
                         select pair;

            foreach (var pair in sorted)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
    }
}