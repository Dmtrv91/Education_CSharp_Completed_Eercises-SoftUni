using System;

//6. Декларирайте променлива isMale от тип bool и присвоете стойност на последната в зависимост от вашия пол.

namespace ConsoleAppGlava2Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var isMaleMan = 2;
            var isMaleWoman = 1; //2

            bool isMaleAB = (isMaleMan > isMaleWoman);
            bool isMaleA1 = (isMaleMan == 1);

            if (isMaleAB)
            {
                Console.WriteLine(1 < 2);
            }
            else
            {
                Console.WriteLine(1 <= 2);
            }
            Console.WriteLine("MAN" + isMaleAB);
            Console.WriteLine("Woman" + isMaleA1);
        }
    }
}
