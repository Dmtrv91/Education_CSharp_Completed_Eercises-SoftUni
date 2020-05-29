using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava15Exercises8

    //Напишете предната програма така, че да заменя само целите думи (не части от думи).
    
{
    class ReplaceWholeWords
    {
        static void Main()
        {
            string pathText = @"C:\.......\text.txt";
            string pathResult = @"C:\.......\result.txt";

            ReplaceSubstrings(pathText, pathResult);
        }

        static void ReplaceSubstrings(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream)
                        result.WriteLine(Regex.Replace(reader.ReadLine(), @"\bstart\b", "finish"));
                }
            }
        }
    }
}
    