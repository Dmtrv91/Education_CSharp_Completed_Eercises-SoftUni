using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises11

//Напишете програма, която обхожда директорията C:\Windows\ и всичките ѝ поддиректории рекурсивно и отпечатва всички файлове, които имат разширение*.exe.

{
    class FileSysInfo
    {
        static void Main()
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\mitko\Даката инстал");
            Console.WriteLine(di.TotalFreeSpace);
            Console.WriteLine(di.VolumeLabel);

            System.IO.DirectoryInfo dirInfo = di.RootDirectory;
            Console.WriteLine(dirInfo.Attributes.ToString());
            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");

            foreach (System.IO.FileInfo fi in fileNames)
            {
                Console.WriteLine("{0}: {1}: {2}", fi.Name, fi.LastAccessTime, fi.Length);
            }

            System.IO.DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");

            foreach (System.IO.DirectoryInfo d in dirInfos)
            {
                Console.WriteLine(d.Name);
            }

            string currentDirName = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirName);

            string[] files = System.IO.Directory.GetFiles(currentDirName, "*.exe");

            foreach (string s in files)
            {
                System.IO.FileInfo fi = null;
                try
                {
                    fi = new System.IO.FileInfo(s);
                }
                catch (System.IO.FileNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine("{0} : {1}", fi.Name, fi.Directory);
            }
            if (!System.IO.Directory.Exists(@"C:\mitko\Даката инстал"))
            {
                System.IO.Directory.CreateDirectory(@"C:\mitko\Даката инстал");
            }

            System.IO.Directory.SetCurrentDirectory(@"C:\mitko\Даката инстал");

            currentDirName = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirName);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}