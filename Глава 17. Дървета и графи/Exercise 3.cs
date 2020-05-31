using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises3

//Да се напише програма, която намира броя на листата и броя на вътрешните върхове на дадено дърво.

{
    class GFG
    {
        static int calcNodes(int N, int I)
        {
            int result = 0;
            result = I * (N - 1) + 1;
            return result;
        }

        public static void Main()
        {
            int N = 5, I = 2;

            Console.Write("Leaf nodes = " + calcNodes(N, I));
        }
    }
}