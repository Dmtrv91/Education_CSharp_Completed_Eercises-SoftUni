using System;

//Създайте метод GetMax() с два целочислени (int) параметъра, който връща по-голямото от двете числа.Напишете програма, която прочи-
//та три цели числа от конзолата и отпечатва най-голямото от тях, използвайки метода GetMax().

namespace ConsoleAppGlava9Exercises2
{
    class Program
    {
       static int a;
       static void GetMax(int first, int second)
        {
            if (first > second) a = first;
            else a = second;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter seconds number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(a, c);

            Console.WriteLine("Biggest number is {0}", a);
        }
    }
}
