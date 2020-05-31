using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises2
{
//Да се напише програма, която извежда корените на онези поддървета на дадено дърво, които имат точно k на брой върха, където k e дадено естествено число.

    class GFG
    {
        static readonly int N = 5005;
        static int n, k;
        static List<int>[] gr = new List<int>[N];
        static int[,] d = new int[N, 505]; 
        static int ans = 0;
        static void Add_edge(int x, int y)
        {
            gr[x].Add(y);
            gr[y].Add(x);
        }
        static void dfs(int v, int par)
        {
            d[v, 0] = 1;
            foreach (int i in gr[v])
            {
                if (i != par)
                {
                    dfs(i, v);

                    for (int j = 1; j <= k; j++)
                        ans += d[i, j - 1] * d[v, k - j];

                    for (int j = 1; j <= k; j++)
                        d[v, j] += d[i, j - 1];
                }
            }
        }
        public static void Main(String[] args)
        {
            n = 5;
            k = 2;
            for (int i = 0; i < N; i++)
                gr[i] = new List<int>();
            Add_edge(1, 2);
            Add_edge(2, 3);
            Add_edge(3, 4);
            Add_edge(2, 5);

            dfs(1, 0);
            Console.Write(ans);
        }
    }
}