using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises8

//Нека е даден граф G(V, E). Напишете програма, която проверява дали графът е цикличен.

{
    class Graph
    {
        private int V;
        private List<int>[] adj;

        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        void addEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        Boolean isCyclicUtil(int v, Boolean[] visited, int parent)
        {
            visited[v] = true;

            foreach (int i in adj[v])
            { 
                if (!visited[i])
                {
                    if (isCyclicUtil(i, visited, v))
                        return true;
                }
                else if (i != parent)
                    return true;
            }
            return false;
        }

        Boolean isCyclic()
        { 
            Boolean[] visited = new Boolean[V];
            for (int i = 0; i < V; i++)
                visited[i] = false;

            for (int u = 0; u < V; u++)
                if (!visited[u])
                    if (isCyclicUtil(u, visited, -1))
                        return true;
            return false;
        }

        public static void Main(String[] args)
        {
            Graph g1 = new Graph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            if (g1.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't contains cycle");

            Graph g2 = new Graph(3);
            g2.addEdge(0, 1);
            g2.addEdge(1, 2);
            if (g2.isCyclic())
                Console.WriteLine("Graph contains cycle");
            else
                Console.WriteLine("Graph doesn't contains cycle");
        }
    }
}