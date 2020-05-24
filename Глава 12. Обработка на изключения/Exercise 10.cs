using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Напишете метод, който приема като параметър име на бинарен файл и прочита съдържанието на файла и го връща като масив от байтове.
//Напишете метод, който записва прочетеното съдържание в друг файл.Сравнете двата файла.

namespace ConsoleAppGlava12Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Lenovo\Desktop\text.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The specified path is invalid!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Invalid syntax!");
            }
        }
    }
}