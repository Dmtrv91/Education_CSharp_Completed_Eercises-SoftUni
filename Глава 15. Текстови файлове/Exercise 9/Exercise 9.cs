using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava15Exercises9

//Напишете програма, която изтрива от текстов файл всички нечетни редове.

{
    class OddLineRemover
    { 
        static string pathText = @"C:\........\text.txt";

        static void Main()
        {
            WriteOddLines(ReadOddLines());
        }

        static List<string> ReadOddLines()
        {
            List<string> oddLines = new List<string>();
            int lineCount = 1;

            using (StreamReader reader = new StreamReader (pathText))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (lineCount++ % 2 == 0) oddLines.Add(line);
                }
            }
            return oddLines;
        }

        static void WriteOddLines(List<string> oddLines)
        {
            using (StreamWriter result = new StreamWriter(pathText))
            {
                for (int i = 0; i < oddLines.Count; i++)
                    result.WriteLine(oddLines[i]);
            }
        }
    }
}
