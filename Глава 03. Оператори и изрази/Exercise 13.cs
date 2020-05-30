using System;

namespace ConsoleAppConsoleAppGlava3Excerises13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This program calculates " +
            "the area of a reactangle or a triangle");

            Console.WriteLine("Enter a and b (for rectangle) " +
             "or a and h (for triangle): ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 for a rectangle or " +
            "2 for a triangle: ");

            int choise = int.Parse(Console.ReadLine());
            double area = (double)(a * b) / choise;
            Console.WriteLine("The area of your figure is " + area);

        }
    }
}
