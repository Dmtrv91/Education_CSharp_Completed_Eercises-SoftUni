using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppGlava15Exercises7

//Напишете програма, която заменя всяко срещане на подниза "start" с "finish" в текстов файл.Можете ли да пренапишете
//програмата така, че да заменя само цели думи? Работи ли програмата за големи файлове(например 800 MB)?

{
    class ReplaceAllOccurrencesOfSubstring
    {
        static void Main()
        {
            string pathText = @"C:\......\text.txt";
            string pathResult = @"C:\......\result.txt";

            ReplaceSubstrings(pathText, pathResult);
        }

        static void ReplaceSubstrings(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream) result.WriteLine(reader.ReadLine().Replace("start", "finish"));
                }
            }
        }
    }
}
