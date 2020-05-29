using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava15Exercises11

//Напишете програма, която изтрива от текстов файл всички думи, които започват с "test". Думите съдържат само символите 0...9, a…z, A…Z,_.

{
    class DeleteWordsWithPrefixTest
    {
        static void Main()
        {
            string pathText = @"C:\.......\text.txt";
            string pathResult = @"C:\.....\result.txt";

            ExtractTextWithoutTags(pathText, pathResult);
        }

        static void ExtractTextWithoutTags(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = Regex.Replace(reader.ReadLine(), @"\btest\S*", String.Empty).Trim();
                        result.Write(line);
                    }
                }
            }
        }
    }
}
