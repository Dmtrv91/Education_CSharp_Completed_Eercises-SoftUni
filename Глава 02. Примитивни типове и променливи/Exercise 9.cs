using System;

// Декларирайте две променливи от тип string и им присвоете стойност "The "use" of quotations causes difficulties." 
// (без първите и последни кавички). В едната променлива използвайте quoted string, а в другата не го използвайте.

namespace ConsoleAppGlava2Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "of quotations causes difficulties.";
            string The2 =  "\"use\"";
            Console.WriteLine("The " + The2 + sentence);
        }
    }
}
