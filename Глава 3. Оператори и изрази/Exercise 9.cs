using System;

//Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5) и едновременно с това право-ъгълника ((-1, 1), (5, 5)). Пояснение: правоъгълникът 
//е зададен чрез координатите на долния си ляв и горния си десен ъгъл.

namespace ConsoleAppConsoleAppGlava3Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool k = x * x + y * y <= 25;
            bool p = (x < -1 && x > 5 && y < 1 && y > 25);

            Console.WriteLine(k);
            Console.WriteLine(p);
        }
    }
}
