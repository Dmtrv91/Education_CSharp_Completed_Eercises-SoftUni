using System;

//Да се напише програма, която създава масив с 20 елемента от целочислен тип и инициализира всеки от елементите със стойност, равна
//на индекса на елемента умножен по 5.Елементите на масива да се изведат на конзолата.

namespace ConsoleAppGlava7Еxercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
           
            for (int index = 0; index < myArray.Length; index++)
            {
                myArray[index] = 5 * index;
                Console.Write(myArray[index] + " ");
            }
        }
    }
}
