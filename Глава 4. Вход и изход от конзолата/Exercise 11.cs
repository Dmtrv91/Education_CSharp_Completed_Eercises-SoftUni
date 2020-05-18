using System;

//Напишете програма, която отпечатва на конзолата първите 100 числа от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,233, 377, ... 

namespace ConsoleAppConsoleAppGlava4Exercises11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.Write("{0} {1}", a, b);

            for(int i = 2; i <= 100; i++)
            {
                c= a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}


 
