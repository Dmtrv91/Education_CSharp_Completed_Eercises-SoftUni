using System;

//Напишете израз, който да проверява дали третата цифра (от дясноналяво) на дадено цяло число е 7.

namespace ConsoleAppConsoleAppGlava3Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 45764;
            bool isSeven = (number / 100) % 10 == 7 ? true : false;
            Console.WriteLine("Third digit of {0} is 7", number, even);
        }
    }
}
