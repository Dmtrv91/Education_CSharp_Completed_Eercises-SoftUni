using System;

//4. Инициализирайте променлива от тип int със стойност 256 в шестна-десетичен формат (256 е 100 в бройна система с основа 16).

namespace ConsoleAppGlava2Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int exr1 = 0x100;
            Console.WriteLine(exr1);
            
            int exr = 0xf7;

            Console.WriteLine(exr);
        }
    }
}
