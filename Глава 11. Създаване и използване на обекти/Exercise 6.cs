using System;

//Напишете програма, която пресмята лице на триъгълник по:
//- дължините на трите му страни;
//- дължината на една от страните и височината към нея;
//- дължините на две от страните му и ъгъла между тях в градуси.

namespace ConsoleAppGlava11Exercises6
{
    class Program
    {
        public static void byThreeSides()
        {
            Console.Write("Enter site a : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter site b : ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter site c : ");
            float c = float.Parse(Console.ReadLine());
            float p = (a + b + c) / 2;
            Console.WriteLine("S is: {0}", (float)(Math.Sqrt(p * (p - a) * (p - b) * (p - c))));
            Console.ReadLine();
        }
        
        public static void bySideAltitude()
        {
            Console.Write("Enter site a : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter site b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("S is: {0}", (a * b) / 2);
            Console.ReadLine();
        }

        public static void byTwoSidesAngle()
        {
            Console.Write("Enter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Enter sine: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("S is: {0}", (a * b * Math.Sin(c)) / 2);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            byte choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Calculate the area of a triangle by given:");
                Console.WriteLine("1.Three side lengths.");
                Console.WriteLine("2.Length of one side and it's altitude.");
                Console.WriteLine("3.Length of two sides and the angle between them.");
                Console.WriteLine("4.Exit.");
                Console.Write("Enter choice from 1 to 4: ");
                choice = System.Convert.ToByte(Console.ReadLine());

                switch (choice)
                {
                    case 1: byThreeSides(); break;
                    case 2: bySideAltitude(); break;
                    case 3: byTwoSidesAngle(); break;
                }
            } while (choice != 4);
        }  
    }
}
