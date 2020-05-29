using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppGlava15Exercises4

//Напишете програма, която сравнява ред по ред два текстови файла с еднакъв брой редове и отпечатва броя съвпадащи и броя различни редове.

{
    class CompareTwoTextFiles
    {
        static int sameLinesCount = 0, diffLinesCount = 0;

        static void Main()
        {
            string pathText1 = @"C:\.......\Text1.txt";
            string pathText2 = @"C:\.......\Text2.txt";

            CompareTextFiles(pathText1, pathText2);

            Console.WriteLine("Same lines: {0}", sameLinesCount);
            Console.WriteLine("Different lines: {0}\n", diffLinesCount);
        }

        static void CompareTextFiles(string pathText1, string pathText2)
        {
            using (StreamReader reader1 = new StreamReader(pathText1))
            {
                using (StreamReader reader2 = new StreamReader(pathText2))
                {
                    while (!reader1.EndOfStream || !reader2.EndOfStream)
                    {
                        string line1 = reader1.ReadLine();
                        string line2 = reader2.ReadLine();

                        if (line1.CompareTo(line2) == 0) sameLinesCount++;
                        else diffLinesCount++;
                    }
                }
            }
        }
    }
}


