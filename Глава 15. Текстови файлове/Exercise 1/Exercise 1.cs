using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Напишете програма, която чете от текстов файл и отпечатва нечетните му редове на конзолата.

namespace ConsoleAppGlava15Exercises13
{
    class FileReader
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\.........\Sample.txt";

            Console.WriteLine("> Prints odd lines of text file...\n");

            using (StreamReader reader = new StreamReader(fileName))
            {
                int lineNumber = 1;

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (lineNumber++ % 2 != 0) Console.WriteLine(line);
                }
            }
        }
    }
}
