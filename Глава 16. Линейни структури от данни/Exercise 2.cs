using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises2

//Напишете програма, която прочита N цели числа от конзолата и ги отпечатва в обратен ред.Използвайте класа Stack<int>.

{
    class Program
    {
        static Stack<int> GetStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            return stack;
        }

        static void Main()
        {
            var stack = GetStack();
            Console.WriteLine("-----Numbers is 1, 2, 3----- ");
            Console.WriteLine("-----numbers in reverse order is-----");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
