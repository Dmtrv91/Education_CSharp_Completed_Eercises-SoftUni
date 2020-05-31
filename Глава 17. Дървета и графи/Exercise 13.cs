using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises13

//Напишете програма, която намира всички цикли в даден граф.

{
    class Program
    {
        static int[,] graph =
        {
                {1, 2}, {1, 3}, {1, 4}, {2, 3},
                {3, 4}, {2, 6}, {4, 6}, {7, 8},
                {8, 9}, {9, 7}
        };

        static List<int[]> cycles = new List<int[]>();

        static void Main(string[] args)
        {
            for (int i = 0; i < graph.GetLength(0); i++)
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    findNewCycles(new int[] { graph[i, j] });
                }

            foreach (int[] cy in cycles)
            {
                string s = "" + cy[0];

                for (int i = 1; i < cy.Length; i++)
                    s += "," + cy[i];

                Console.WriteLine(s);
            }
        }

        static void findNewCycles(int[] path)
        {
            int n = path[0];
            int x;
            int[] sub = new int[path.Length + 1];

            for (int i = 0; i < graph.GetLength(0); i++)
                for (int y = 0; y <= 1; y++)
                    if (graph[i, y] == n)
                    {
                        x = graph[i, (y + 1) % 2];
                        if (!visited(x, path))
                        {
                            sub[0] = x;
                            Array.Copy(path, 0, sub, 1, path.Length);
                            findNewCycles(sub);
                        }
                        else if ((path.Length > 2) && (x == path[path.Length - 1]))
                        {
                            int[] p = normalize(path);
                            int[] inv = invert(p);
                            if (isNew(p) && isNew(inv))
                                cycles.Add(p);
                        }
                    }
        }

        static bool equals(int[] a, int[] b)
        {
            bool ret = (a[0] == b[0]) && (a.Length == b.Length);

            for (int i = 1; ret && (i < a.Length); i++)
                if (a[i] != b[i])
                {
                    ret = false;
                }

            return ret;
        }

        static int[] invert(int[] path)
        {
            int[] p = new int[path.Length];

            for (int i = 0; i < path.Length; i++)
                p[i] = path[path.Length - 1 - i];

            return normalize(p);
        }

        static int[] normalize(int[] path)
        {
            int[] p = new int[path.Length];
            int x = smallest(path);
            int n;

            Array.Copy(path, 0, p, 0, path.Length);

            while (p[0] != x)
            {
                n = p[0];
                Array.Copy(p, 1, p, 0, p.Length - 1);
                p[p.Length - 1] = n;
            }
            return p;
        }

        static bool isNew(int[] path)
        {
            bool ret = true;

            foreach (int[] p in cycles)
                if (equals(p, path))
                {
                    ret = false;
                    break;
                }
            return ret;
        }

        static int smallest(int[] path)
        {
            int min = path[0];

            foreach (int p in path)
                if (p < min)
                    min = p;

            return min;
        }

        static bool visited(int n, int[] path)
        {
            bool ret = false;

            foreach (int p in path)
                if (p == n)
                {
                    ret = true;
                    break;
                }
            return ret;
        }
    }
}
