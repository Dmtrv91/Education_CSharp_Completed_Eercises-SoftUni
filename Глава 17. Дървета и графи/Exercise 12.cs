using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises12

//Дефинирайте класове File { string name, int size } и Folder { string name, File[] files, Folder[] childFolders}. Използвайки тези класове,
//постройте дърво, което съдържа всички файлове и директории на твърдия диск, като започнете от C:\Windows\. Напишете метод, който
//изчислява сумата от големините на файловете в дадено поддърво и програма, която тества този метод.За обхождането на директориите
//използвайте рекурсивно обхождане в дълбочина (DFS).
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetDirectorySize(@"C:\mitko\Даката инстал\RarLab.WinRAR.v3.93.Cracked-EAT"));
        }

        static long GetDirectorySize(string p)
        {
            string[] a = Directory.GetFiles(p);

            long b = 0;
            foreach (string name in a)
            {
                FileInfo info = new FileInfo(name);
                b += info.Length;
            }
            return b;
        }
    }
}