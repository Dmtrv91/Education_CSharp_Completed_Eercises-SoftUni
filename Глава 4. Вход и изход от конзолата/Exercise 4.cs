using System;

//Напишете програма, която отпечатва три числа в три виртуални колони на конзолата. Всяка колона трябва да е с широчина 10 символа, а числата 
//трябва да са ляво подравнени. Първото число трябва да е цяло число в шестнадесетична бройна система, второто да е дробно положи-телно, а
//третото да е дробно отрицателно. Последните две числа да се закръглят до втория знак след десетичната запетая.

namespace ConsoleAppConsoleAppGlava4Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            int furstNumber = Int16.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thurdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0}          |{1:F2}          |{2:F2}          |", furstNumber, secondNumber, thurdNumber);
        }
    }
}
