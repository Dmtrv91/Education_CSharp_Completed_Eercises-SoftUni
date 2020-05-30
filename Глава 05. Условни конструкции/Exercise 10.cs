using System;

//Напишете програма, която прилага бонус точки към дадени точки в интервала [1..9] чрез прилагане на следните правила:
//- Ако точките са между 1 и 3, програмата ги умножава по 10.
//- Ако точките са между 4 и 6, програмата ги умножава по 100.
//- Ако точките са между 7 и 9, програмата ги умножава по 1000.
//- Ако точките са 0 или повече от 9, се отпечатва съобщение за грешка.

namespace ConsoleAppGlava5Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Int32.Parse(Console.ReadLine());
            
            if (number >= 1 && number <= 3)
            {
               int number1 = number + 10;
                Console.WriteLine("{0}", number1);
            }
            else if (number >= 4 && number <= 6)
            {
               int number1 = number + 100;
                Console.WriteLine("{0}", number1);
            }
            else if (number >= 7 && number <= 9)
            {
                int number1 = number + 1000;
                Console.WriteLine("{0}", number1);
            }
            else
                Console.WriteLine("Error");
        }
    }
}
