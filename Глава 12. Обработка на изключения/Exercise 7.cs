using System;

//Напишете програма, която прочита от конзолата цяло положително число и отпечатва на конзолата корен квадратен от това число.Ако
//числото е отрицателно или невалидно, да се изпише "Invalid Number" на конзолата. Във всички случаи да се принтира на конзолата "Good Bye".

namespace ConsoleAppGlava12Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int n = -1;
            bool invalidNumber = false;

            try
            {
                n = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid number!");
                invalidNumber = true;
            }

            finally
            {
                if (n < 0)
                {
                    if (!invalidNumber) Console.WriteLine("Invalid number");
                }
                else Console.WriteLine("Good Bye");
            }
        }
    }
}