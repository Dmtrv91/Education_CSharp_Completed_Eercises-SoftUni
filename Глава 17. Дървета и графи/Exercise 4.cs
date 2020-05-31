using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises4

//Напишете програма, която по дадено двоично дърво от числа намира сумата на върховете от всяко едно ниво на дървото.

{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;
        }; 
        static Node newNode(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.left = temp.right = null;
            return temp;
        }

        static void printArr(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i]);
        }
        static int getHeight(Node root)
        {
            if (root.left == null &&
                root.right == null)
                return 0;

            int left = 0;
            if (root.left != null)
                left = getHeight(root.left);

            int right = 0;
            if (root.right != null)
                right = getHeight(root.right);

            return (Math.Max(left, right) + 1);
        }
 
        static void calculateLevelSum(Node node, int level, int[] sum)
        {
            if (node == null)
                return;
 
            sum[level] += node.data;
  
            calculateLevelSum(node.left, level + 1, sum);
            calculateLevelSum(node.right, level + 1, sum);
        }

        public static void Main(String[] args)
        {
            Node root = newNode(6);
            root.left = newNode(4);
            root.right = newNode(8);
            root.left.left = newNode(3);
            root.left.right = newNode(5);
            root.right.left = newNode(7);
            root.right.right = newNode(9);
  
            int levels = getHeight(root) + 1;

            int[] sum = new int[levels];
            calculateLevelSum(root, 0, sum);
 
            printArr(sum, levels);
        }
    }
}