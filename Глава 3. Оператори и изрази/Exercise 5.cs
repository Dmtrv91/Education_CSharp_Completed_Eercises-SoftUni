using System;

//Напишете израз, който изчислява площта на трапец по дадени a, b и h.

namespace ConsoleAppGlava3Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int area = ((a + b) / 2) * h;

            Console.WriteLine("Тrapeze Area is :" + " " + area);
        }
    }
}
