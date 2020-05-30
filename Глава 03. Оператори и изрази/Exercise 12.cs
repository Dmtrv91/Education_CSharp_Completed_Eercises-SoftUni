using System;

namespace ConsoleAppConsoleAppGlava3Excerises12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете булев израз, който проверява дали битъ
            //на позиция p на цялото число v има стойност 
            // Пример v=5, p=1 -> false.

            int v = 5;
            int p = 1;
            int i =0;
            int mask = i << p;

            Console.WriteLine((v & mask) != 0 ? 1 : 0);
        }
    }
}
