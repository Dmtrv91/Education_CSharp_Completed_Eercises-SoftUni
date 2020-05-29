using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppGlava15Exercises3

//Напишете програма, която прочита съдържанието на текстов файл и вмъква номерата на редовете в началото на всеки ред и след това записва обратно съдържанието на файла.

{
    class Program
    {
        static void Main()
        {
            string text = @"C:\.......\Text.txt";
            string result = @"C:\.......\Result.txt";

            InsertLinesToResultFile(text, result);
            PrintResultContent(result);
        }

        static void InsertLinesToResultFile(string text, string result)
        {
            int lineCount = 1;

            using (StreamWriter fileResult = new StreamWriter(result))
            {
                using (StreamReader fileReader = new StreamReader(text))
                {
                    while (!fileReader.EndOfStream) fileResult.WriteLine("Line {0}: {1}", lineCount++, fileReader.ReadLine());
                }
            }
        }

        static void PrintResultContent(string path)
        {
            Console.WriteLine("> Result:\n");

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
            }
            Console.WriteLine("\n> End of file...\n");
        }
    }
}
