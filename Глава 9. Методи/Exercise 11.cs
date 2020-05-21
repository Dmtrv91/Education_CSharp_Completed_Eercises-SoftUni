using System;

//Напишете програма, която решава следните задачи:
// - Обръща последователността на цифрите на едно число.
// - Пресмята средното аритметично на дадена поредица от числа.
// - Решава линейното уравнение a * x + b = 0.
//Създайте подходящи методи за всяка една от задачите. Напишете програмата така, че на потребителя да му бъде изведено текстово меню, от което да избира коя от задачите да решава.
//Направете проверка на входните данни:
// - Целочисленото число трябва да е в интервала[1…50, 000, 000].
// - Редицата не трябва да е празна.
// - Коефициентът a не трябва да е 0.

namespace ConsoleAppGlava9Exercises11
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Reverse()
        {
            int numberReverse;
            string stringNumberReverse;
            do
            {
                Console.Clear();
                Console.Write("Въведете НЕотрицателно число: ");
                stringNumberReverse = Console.ReadLine();
                numberReverse = int.Parse(stringNumberReverse);
            } while (numberReverse < 0);

            Console.WriteLine("Числото обърнато " + ReverseString(stringNumberReverse));
            Console.ReadLine();
        }

        static void Average()
        {
            int numberAverage = 0;
            int entries = -1;
            int temp;
            string numberAverageString;
            bool input;
            Console.Clear();

            do
            {
                Console.Write("Въведете число от редицата. Въведете буква за да приключите: ");
                numberAverageString = Console.ReadLine();
                input = Int32.TryParse(numberAverageString, out temp);
                numberAverage += temp;
                entries++;
            } while (input);

            Console.WriteLine("Средно аретмитичното число е: {0}.", (float)numberAverage / entries);
            Console.ReadLine();
        }

        static void SolveEquation()
        {
            int a = 0;

            do
            {
                Console.Clear();
                Console.Write("Въведете a: ");
                a = int.Parse(Console.ReadLine());
            } while (a == 0);

            Console.Write("Въведете b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}", (float)-b / a);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            byte choice;

            do
            {
                Console.Clear();
                Console.WriteLine("##########################################");
                Console.WriteLine("#   M     M  EEEEEEE  N     N  U     U   #");
                Console.WriteLine("#   M M M M  E        N N   N  U     U   #");
                Console.WriteLine("#   M  M  M  EEEEE    N  N  N  U     U   #");
                Console.WriteLine("#   M     M  E        N   N N  U     U   #");
                Console.WriteLine("#   N     N  EEEEEEE  N     N   UUUUU    #");
                Console.WriteLine("##########################################" + System.Environment.NewLine);
                Console.WriteLine("1.Обърнете последователността на числото.");
                Console.WriteLine("2.Средно аретмитично на редица от числа.");
                Console.WriteLine("3.Решаване на уравнение: a * x + b = 0.");
                Console.WriteLine("4.Изход.");
                Console.Write("Въведете изход: ");

                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Reverse(); break;
                    case 2: Average(); break;
                    case 3: SolveEquation(); break;
                }

            } while (choice != 4);

            Console.WriteLine(System.Environment.NewLine + "КРАЙ!");
            Console.ReadLine();
        }
    }
}
