using System;

//Напишете програма, която за подадени от потребителя дължина и височина на правоъгълник пресмята и отпечатва на конзолата неговите периметър и лице.

namespace ConsoleAppConsoleAppGlava3Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = a * b;
            int Perimetar = 2 * (a + b);

            Console.WriteLine("Аarea Rectange is: " + area);
            Console.WriteLine("Аarea Perimetar is: " + Perimetar);
        }
    }
}
