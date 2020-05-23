using System;

//Напишете програма, която по дадени два катета намира хипотенузата на правоъгълен триъгълник.Реализирайте въвеждане на
//дължините на катетите от стандартния вход, а за пресмятането на хипотенузата използвайте методи на класа Math.

namespace ConsoleAppGlava11Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("{0:F1}", Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
