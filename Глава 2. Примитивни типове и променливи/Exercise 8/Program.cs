using System;

namespace ConsoleAppGlava2Excercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            string H = "Hello ";
            string W = "Word";
            object HM = H + W;
            string thirt = (string)HM;

            Console.WriteLine(thirt);
        }
    }
}
