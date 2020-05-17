using System;

//Напишете програма, която за дадена цифра (0-9), зададена като вход, извежда името на цифрата на английски език. Използвайте switch конструкция.

namespace ConsoleAppGlava5Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());

            switch ( a )
            {
                case 0: Console.WriteLine("nula"); break;
                case 1: Console.WriteLine("edno"); break;
                case 2: Console.WriteLine("dve"); break;
                case 3: Console.WriteLine("tri"); break;
                case 4: Console.WriteLine("chetiri"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("shest"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("night"); break;
                default: Console.WriteLine("Wrong input"); break;
            }
        }
    }
}
