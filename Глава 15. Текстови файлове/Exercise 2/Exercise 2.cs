using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppGlava15Exercises2

//Напишете програма, която съединява два текстови файла и записва резултата в трети файл.

{
    class Program
    {
        static void Main()
        {
            string fileText1 = @"C:\Users\Lenovo\source\repos\ConsoleAppGlava15Exercices1\ConsoleAppGlava15Excercices1\ConsoleAppGlava15Excercices2\TextRead1.txt";
            string fileText2 = @"C:\Users\Lenovo\source\repos\ConsoleAppGlava15Exercices1\ConsoleAppGlava15Excercices1\ConsoleAppGlava15Excercices2\TextRead2.txt";
            string fileText3 = @"C:\Users\Lenovo\source\repos\ConsoleAppGlava15Exercices1\ConsoleAppGlava15Excercices1\ConsoleAppGlava15Excercices2\TextRead3.txt";

            ReadFileContent(fileText1, fileText3);
            ReadFileContent(fileText2, fileText3);

            PrintResultContent(fileText3);
        }

        static void ReadFileContent(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult, true))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream) result.WriteLine(reader.ReadLine());
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



