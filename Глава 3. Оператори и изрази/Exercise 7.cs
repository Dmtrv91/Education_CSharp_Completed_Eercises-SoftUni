using System;

//Силата на гравитационното поле на Луната е приблизително 17% от това на Земята. Напишете програма, която да изчислява тежестта на човек на Луната, по дадената 
//тежест на Земята. 9,807 m/s²

namespace ConsoleAppGlava3Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {           
            int manKg = Convert.ToInt32(Console.ReadLine());
            
            double gravitiEarth = 9.807;
            double gravitiMoon = gravitiEarth * 0.17;
            double moonKg = manKg * gravitiMoon;

            Console.WriteLine("Mans kg in the moon is: " + ($"{moonKg:F2}"));
        }
    }
}
