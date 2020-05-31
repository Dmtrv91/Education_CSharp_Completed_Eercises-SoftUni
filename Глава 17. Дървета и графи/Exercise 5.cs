using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises5

//Да се напише програма, която намира и отпечатва всички върхове на двоично дърво, които имат за наследници само листа.

{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;
            public Node(int data)
            {
                left = right = null;
                this.data = data;
            }
        }
 
        static void printInternalNodes(Node root)
        { 
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                Node curr = q.Peek();
                q.Dequeue();
  
                Boolean isInternal = false;

                if (curr.left != null)
                {
                    isInternal = true;
                    q.Enqueue(curr.left);
                }

                if (curr.right != null)
                {
                    isInternal = true;
                    q.Enqueue(curr.right);
                }
  
                if (isInternal == true)
                    Console.Write(curr.data + " ");
            }
        }
 
        public static void Main(String[] args)
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.right.left = new Node(5);
            root.right.right = new Node(6);
            root.right.right.right = new Node(10);
            root.right.right.left = new Node(7);
            root.right.left.left = new Node(8);
            root.right.left.right = new Node(9);

            printInternalNodes(root);
        }
    }
}