using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava17Exercises6

//Да се напише програма, която проверява дали дадено двоично дърво е идеално балансирано.

{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }
    public class Height
    {
        public int height = 0;
    }

    public class BinaryTree
    {
        public Node root;

        public virtual bool isBalanced(Node root, Height height)
        {
            if (root == null)
            {
                height.height = 0;
                return true;
            }

            Height lheight = new Height(), rheight = new Height();
            bool l = isBalanced(root.left, lheight);
            bool r = isBalanced(root.right, rheight);
            int lh = lheight.height, rh = rheight.height;

            height.height = (lh > rh ? lh : rh) + 1;

            if ((lh - rh >= 2) || (rh - lh >= 2))
            {
                return false;
            }

            else
            {
                return l && r;
            }
        }
        public virtual int height(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(height(node.left), height(node.right));
        }

        public static void Main(string[] args)
        {
            Height height = new Height();
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.right.right = new Node(6);
            tree.root.left.left.left = new Node(7);

            if (tree.isBalanced(tree.root, height))
            {
                Console.WriteLine("Tree is balanced");
            }
            else
            {
                Console.WriteLine("Tree is not balanced");
            }
        }
    }
}