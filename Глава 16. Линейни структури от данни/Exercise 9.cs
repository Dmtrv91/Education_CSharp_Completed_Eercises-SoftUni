using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises9

//Дадена е следната поредица:
//S1 = N;
//S2 = S1 + 1;
//S3 = 2* S1 + 1;
//S4 = S1 + 2;
//S5 = S2 + 1;
//S6 = 2* S2 + 1;
//S7 = S2 + 2;

{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Int32.Parse(Console.ReadLine());
            var s2 = s1 + 1;
            var s3 = (2 * s1) + 1;
            var s4 = s1 + 1;
            var s5 = s2 + 1;
            var s6 = (2 * s2) + 1;
            var s7 = s2 + 2;

            Queue my_formula = new Queue();
            my_formula.Enqueue(s1);
            my_formula.Enqueue(s2);
            my_formula.Enqueue(s3);
            my_formula.Enqueue(s4);
            my_formula.Enqueue(s5);
            my_formula.Enqueue(s6);
            my_formula.Enqueue(s7);

            foreach(var myFormula in my_formula)
            {
                Console.WriteLine(myFormula);
            }
        }
    }
}
