using System;

//Дадена е последователност от цели положителни числа, записани едно след друго като символен низ, разделени с интервал. Да се напише програма, която пресмята сумата им Пример: "43 68 9 23 318" = 461.

namespace ConsoleAppGlava11Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("Enter numbers: ");
            string inputNumbers = Console.ReadLine();
            string[] splitNumbers = inputNumbers.Split(' ');

            for (int i = 0; i < splitNumbers.Length; i++)
                result += Convert.ToInt32(splitNumbers[i]);

            Console.WriteLine("Result is: {0}", result);
        }
    }
}
