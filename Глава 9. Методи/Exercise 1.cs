using System;

//Напишете метод, който при подадено име отпечатва на конзолата "Hello, <name>!" (например "Hello, Peter!"). Напишете програма, която тества дали този метод работи правилно.

namespace ConsoleAppGlava9Exercises1
{
    class Program
    {
        static void ReturnTheName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:  ");
            ReturnTheName(Console.ReadLine());
        }
    }
}
