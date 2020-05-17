using System;

//Напишете програма, която чете две числа от конзолата и отпечатва по-голямото от тях. Решете задачата без да използвате условни конструкции.

namespace ConsoleAppConsoleAppGlava4Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Math.Max(a, b);
            
            Console.WriteLine(c);
        }
    }
}
