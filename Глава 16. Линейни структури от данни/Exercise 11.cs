using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava16Exercises11

//Реализирайте структурата двойно свързан динамичен списък, чиито елементи имат указател, както към следващия така и към предхождащия го елемент.Реализирайте операциите добавяне,
//премахване и търсене на елемент, добавяне на елемент на определено място (индекс), извличане на елемент по индекс и метод, който връща масив с елементите на списъка.

{
    public class Node
    {
        public Node next;
        public Object data;
    }

    public class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            toAdd.next = head;
            head = toAdd;
        }

        public void AddLast(Object data)
        {
            if (head == null)
            {
                head = new Node();
                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddFirst("Magical");
            myList1.AddFirst("World");
            myList1.printAllNodes();

            Console.WriteLine();
            Console.WriteLine("Remove:");

            myList1.Remove(LinkedList);
            myList1.printAllNodes();

            Console.ReadLine();
        }
    }
}