using System;

//Опитайте да сумирате 50 000 000 пъти числото 0.000001. Използвайте цикъл и събиране(не директно умножение). Опитайте с типовете float и double и след това с decimal.Забелязвате ли разли-
//ката в резултатите и в скоростта? Обяснете защо се получава така?

namespace ConsoleAppGlava8Exercises14
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0.0m;
            for (int i = 1; i <= 50000000; i++)
            {
                sum += 0.000001m;
            }
            Console.WriteLine(sum);
        }
    }
}
