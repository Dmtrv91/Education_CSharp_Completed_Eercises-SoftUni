using System;

// Декларирайте две променливи от тип string и им присвоете стойности "Hello" и "World". Декларирайте променлива от тип object и ѝ присвоете
// стойността на конкатенацията на двете променливи от тип string (не изпускайте интервала по средата). Декларирайте трета променлива от
// тип string и я инициализирайте със стойността на променливата от тип object.

namespace ConsoleAppGlava2Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string H = "Hello ";
            string W = "Word";
            object HM = H + W;
            string thirt = (string)HM;

            Console.WriteLine(thirt);
        }
    }
}
