using System;

namespace ConsoleAppGlava3Excerises10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която приема за вход четирицифрено число във формат abcd 
            //(например числото 2011) и след това извършва следните действия върху него:
            //-Пресмята сбора от цифрите на числото(за нашия пример 2 + 0 + 1 + 1 = 4).
            //- Разпечатва на конзолата цифрите в обратен ред: dcba(за нашия пример резултатът е 1102).
            //- Поставя последната цифра на първо място: dabc(за нашия пример резултатът е 1201).
            //- Разменя мястото на втората и третата цифра: acbd(за нашия пример резултатът е 2101).

            int abcd = int.Parse(Console.ReadLine());

            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd / 10) % 10;
            int d = abcd % 10;
            int sum = a + b + c + d;
            // var sumABCD = a + b + c + d;




            ////Console.WriteLine(sum);
            // Console.WriteLine(d, c, b, a);
            // Console.WriteLine(d, a, b, c);
            // Console.WriteLine(a + c + b + d);

            Console.WriteLine("1.Sum of digits = {0}", a + b + c + d);
            Console.WriteLine("2.Digits backwards = {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("3.Last digit on first place = {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("4.Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);
        }
    }
}
