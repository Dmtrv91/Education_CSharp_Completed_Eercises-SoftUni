using System;

namespace ConsoleAppGlava2Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Декларирайте променлива isMale от тип bool и присвоете 
            //стойност на последната в зависимост от вашия пол.

            //string isMale = (Console.ReadLine());
            //string isMaleWoman = (Console.ReadLine());
            var isMaleMan = 2;
            var isMaleWoman = 1; //2
            //bool isMale = (isMaleMan > isMaleWoman);

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
