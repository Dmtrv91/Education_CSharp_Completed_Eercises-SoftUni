using System;

//Декларирайте две променливи от тип int. Задайте им стойности съответно 5 и 10. Разменете стойностите им и ги отпечатайте.

namespace ConsoleAppGlava2Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int oldA = a;
            a = b;
            b = oldA;
            
        Console.WriteLine("old a = 5, old b = 10");
		Console.WriteLine("new a = {0}, new b = {1}", a, b);
        }
    }
}
