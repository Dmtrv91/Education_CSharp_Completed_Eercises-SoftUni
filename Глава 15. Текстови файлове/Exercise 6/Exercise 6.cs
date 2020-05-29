using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppGlava15Exercises6

//Напишете програма, която чете списък от имена от текстов файл, подрежда ги по азбучен ред и ги запазва в друг файл.Имената са записани по едно на ред.

{
    class SortListOfStrings
    {
        static List<string> strings = new List<string>();

        static void Main()
        {
            string pathText = @"C:\.....\strings.txt";
            string pathResult = @"C:\...\result.txt";

            SeparateStringsFromTextFile(pathText);

            Console.WriteLine("Strings: {0}", string.Join(", ", strings));

            strings.Sort();
            SaveSortedStringsToTextFile(pathResult);

            Console.WriteLine("\nSorted strings: {0}\n", string.Join(", ", strings));
        }

        static void SeparateStringsFromTextFile(string pathText)
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(new char[] { ' ', ',', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < tokens.Length; i++)
                        strings.Add(tokens[i]);
                }
            }
        }

        static void SaveSortedStringsToTextFile(string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                for (int i = 0; i < strings.Count; i++)
                    result.WriteLine(strings[i]);
            }
        }
    }
}
