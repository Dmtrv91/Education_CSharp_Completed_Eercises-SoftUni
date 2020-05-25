using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Globalization;

//Напишете програма, която извлича от даден текст всички думи, които са палиндроми, например "ABBA", "lamal", "exe".

namespace ConsoleAppGlava13Exercises21
{
    class Program
    {
        static void Main(string[] args)
        {
        int i = 0;
        Console.WriteLine("Enter a String"); 
        string s = Console.ReadLine();
        string words = s.ToLower();
        string[] hasil = words.Split(' ');
            foreach (string temp in hasil)
            {
                string str = string.Empty;
                int x = temp.Length;

                for (int y = x - 1; y >= 0; y--)
                {
                    str = str + temp[y];
                }

                int count = 0;

                if (str == temp)
                {
                    count++;
                    Console.WriteLine(temp + " is palindrome = " + count);
                }
                    i++;
            }
        }
    }
} 