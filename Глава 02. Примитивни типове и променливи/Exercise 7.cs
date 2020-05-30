using System;

// Декларирайте две променливи от тип string със стойности "Hello" и "World". Декларирайте променлива от тип object. Присвоете на тази
// променлива стойността, която се получава от конкатенацията на двете стрингови променливи (добавете интервал, ако е необходимо). Отпе-
// чатайте променливата от тип object.

namespace ConsoleAppGlavaExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = "Hello";
            string Word = "Word";
            object HW = Hello + " " + Word + "!";

            Console.WriteLine(HW);
        }
    }
}
