using System;

//Да се реализира двоично търсене(binary search) в сортиран целочислен масив, за да открие конкретен елемент.

namespace ConsoleAppGlava7Exercises16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter arry Leght: ");
            int leght = Int32.Parse(Console.ReadLine());

            int[] arr = new int[leght];

            for (int i = 0; i < leght; i++)
            {
                Console.Write("Enter {0} elements: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Enter searched number: ");
            int number = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, number);

            if (index >= 0) Console.Write("Number is on {0} index.", index);
            else Console.Write("Number wasn't found.");
        }
    }
}
