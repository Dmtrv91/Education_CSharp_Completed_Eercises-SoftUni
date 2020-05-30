using System;

//Напишете програма, която за дадени две числа, намира най-големия им общ делител(НОД) и най-малкото им общо кратно(НОК). Можете да използвате формулата НОК(a, b) = |a* b| / НОД(а, b).

namespace ConsoleAppGlava6Exercises17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            while (a !=0 && b !=0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);
        }
    }
}
