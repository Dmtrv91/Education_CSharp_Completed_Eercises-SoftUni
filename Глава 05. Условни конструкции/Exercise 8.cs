using System;

//Напишете програма, която по избор на потребителя прочита от конзолата променлива от тип int, double или string. Ако променливата е 214 Принципи на програмирането със C#
//int или double, трябва да се увеличи с 1.Ако променливата е string, трябва да се прибави накрая символа "*".Отпечатайте получения резултат на конзолата. Използвайте switch конструкция.

namespace ConsoleAppGlava5Exercises8
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar = Int32.Parse(Console.ReadLine());
          
            switch (intVar)
            {
                case 0:
                    {
                        Console.Write("Enter int variable: ");
                        intVar = Int32.Parse(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong input"); break;
            }
        }
    }
}
