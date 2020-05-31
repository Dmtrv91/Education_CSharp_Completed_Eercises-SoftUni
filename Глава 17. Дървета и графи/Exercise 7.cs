using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;


namespace ConsoleAppGlava17Exercises7

//Нека е даден граф G(V, E) и два негови върха x и y. Напишете програма, която намира най-краткия път между два върха по брой на върховете.

{
    class Program
    {
        static void Main(string[] args)
        {
            int V = 3, E = 3;
            Graph graph = new Graph(V, E);

            graph.edge[0].src = 0;
            graph.edge[0].dest = 1;

            graph.edge[1].src = 1;
            graph.edge[1].dest = 2;

            graph.edge[2].src = 0;
            graph.edge[2].dest = 2;

            if (graph.isCycle(graph) == 1)
                Console.WriteLine("graph contains cycle");
            else
                Console.WriteLine("graph doesn’t contain cycle");
        }
    }

    class Graph
    {
        public int V, E; 
        public Edge[] edge; 

        public class Edge
        {
            public int src, dest;
        };
        public Graph(int v, int e)
        {
            V = v;
            E = e;
            edge = new Edge[E];
            for (int i = 0; i < e; ++i)
                edge[i] = new Edge();
        }

        internal int isCycle(Graph graph)
        {
            int[] parent = new int[graph.V];

            for (int i = 0; i < graph.V; ++i)
                parent[i] = -1;

            for (int i = 0; i < graph.E; ++i)
            {
                int x = graph.find(parent, graph.edge[i].src);
                int y = graph.find(parent, graph.edge[i].dest);

                if (x == y)
                    return 1;

                graph.Union(parent, x, y);
            }
            return 0;
        }

        private void Union(int[] parent, int x, int y)
        {
            int xset = find(parent, x);
            int yset = find(parent, y);
            parent[xset] = yset;
        }

        private int find(int[] parent, int src)
        {
            if (parent[src] == -1)
                return src;
            return find(parent, parent[src]);
        }
    }
}