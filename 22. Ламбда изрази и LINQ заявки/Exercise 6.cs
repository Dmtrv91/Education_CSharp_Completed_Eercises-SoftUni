using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

//Напишете програма, която отпечатва на конзолата всички числа в даден масив(или списък), които се делят едновременно на 7 и на 3.
//Използвайте вградените разширяващи методи

namespace ConsoleAppGlava22Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 21};
            var evenNumbers =
                from num in numbers
                where num % 21 == 0
                select num;
            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
