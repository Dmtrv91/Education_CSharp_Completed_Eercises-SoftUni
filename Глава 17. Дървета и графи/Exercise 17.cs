using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises17

//Ойлеров цикъл в граф се нарича цикъл, който започва от даден връх, минава точно по веднъж през всички негови ребра и се връща в начал-
//ния връх.При това обхождане всеки връх може да бъде посетен многократно.Напишете програма, която по даден граф намира в него
//Ойлеров цикъл или установява, че такъв няма.

{
    public class Graph
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
        void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            foreach (int i in adj[v])
            {
                int n = i;
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }
        bool isConnected()
        {
            bool[] visited = new bool[V];
            int i;
            for (i = 0; i < V; i++)
                visited[i] = false;

            for (i = 0; i < V; i++)
                if (adj[i].Count != 0)
                    break;

            if (i == V)
                return true;

            DFSUtil(i, visited);

            for (i = 0; i < V; i++)
                if (visited[i] == false && adj[i].Count > 0)
                    return false;

            return true;
        }
        int isEulerian()
        {
            if (isConnected() == false)
                return 0;
            int odd = 0;
            for (int i = 0; i < V; i++)
                if (adj[i].Count % 2 != 0)
                    odd++;

            if (odd > 2)
                return 0;
            return (odd == 2) ? 1 : 2;
        }
        void test()
        {
            int res = isEulerian();
            if (res == 0)
                Console.WriteLine("graph is not Eulerian");
            else if (res == 1)
                Console.WriteLine("graph has a Euler path");
            else
                Console.WriteLine("graph has a Euler cycle");
        }
        public static void Main(String[] args)
        { 
            Graph g1 = new Graph(5);
            g1.addEdge(1, 0);
            g1.addEdge(0, 2);
            g1.addEdge(2, 1);
            g1.addEdge(0, 3);
            g1.addEdge(3, 4);
            g1.test();

            Graph g2 = new Graph(5);
            g2.addEdge(1, 0);
            g2.addEdge(0, 2);
            g2.addEdge(2, 1);
            g2.addEdge(0, 3);
            g2.addEdge(3, 4);
            g2.addEdge(4, 0);
            g2.test();

            Graph g3 = new Graph(5);
            g3.addEdge(1, 0);
            g3.addEdge(0, 2);
            g3.addEdge(2, 1);
            g3.addEdge(0, 3);
            g3.addEdge(3, 4);
            g3.addEdge(1, 3);
            g3.test();

            Graph g4 = new Graph(3);
            g4.addEdge(0, 1);
            g4.addEdge(1, 2);
            g4.addEdge(2, 0);
            g4.test();

            Graph g5 = new Graph(3);
            g5.test();
        }
    }
}
