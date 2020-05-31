using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises1

//Да се напише програма, която намира броя на срещанията на дадено число в дадено дърво от числа.

{
    class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
    public class BinaryTree
    {
        Node root;

        BinaryTree()
        {
            root = null;
        }
        void printInorder(Node node)
        {
            if (node == null)
                return;

            printInorder(node.left);

            Console.Write(node.key + " ");

            printInorder(node.right);
        } 
        void printInorder()
        {
            printInorder(root);
        }
        public static void Main(String[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);

            Console.WriteLine("\nInorder traversal of binary tree is ");
            tree.printInorder();
        }
    }
}