using System;

//Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.

namespace ConsoleAppConsoleAppGlava3Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool k = x * x + y * y <= 25;

            Console.WriteLine(k);
        }
    }
}
