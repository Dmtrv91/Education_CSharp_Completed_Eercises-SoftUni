using System;

//Да се напише програма, която чете два масива от конзолата и проверява дали са еднакви(два масива са еднакви, когато имат еднаква
//дължина и елементите им, записани под едни и същи индекси, са еднакви).

namespace ConsoleAppConsoleAppGlava7Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arraysEque = true;

            Console.Write("Enter lenght of first array");
            int lenght = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[lenght];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter lenght of second array: ");

            if (lenght != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nEnter lenght of second array: ");
            else
            {
                int[] arrB = new int[lenght];
                for(int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arrB[i] = Int32.Parse(Console.ReadLine());
                }

               for(int i = 0; i < arrA.Length; i++)
                {
                    if(arrA[i] != arrB[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysEque = false;
                        break;
                    }
                }
            }

            Console.WriteLine("YESSS");
        }
    }
}
