using System;

//Превърнете числата 151, 35, 43, 251, 1023 и 1024 в двоична
// бройна система.

namespace ConsoleAppGlava8Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("151 to binary {0}.", Convert.ToString(151, 2));
            Console.WriteLine("35 to binary {0}.", Convert.ToString(35, 2));
            Console.WriteLine("43 to binary {0}.", Convert.ToString(43, 2));
            Console.WriteLine("251 to binary {0}.", Convert.ToString(251, 2));
            Console.WriteLine("1023 to binary {0}.", Convert.ToString(1023, 2));
            Console.WriteLine("1024 to binary {0}.", Convert.ToString(1024, 2));
        }
    }
}
