using System;

//Напишете програма, която чете от конзолата символен низ и отпечатва в азбучен ред всички букви от въведения низ и съответно колко пъти се среща всяка от тях.

namespace ConsoleAppGlava13Exercises22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringTools.Alphabetize(Console.ReadLine()));
        }
    }

    public static class StringTools
    {
        public static string Alphabetize(string s)
        {
            char[] a = s.ToCharArray();

            Array.Sort(a);

            return new string(a);
        }
    }
}
