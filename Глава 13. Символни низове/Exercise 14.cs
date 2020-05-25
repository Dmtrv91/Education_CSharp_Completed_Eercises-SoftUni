using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Напишете програма, която обръща думите в дадено изречение без да променя пунктуацията и интервалите.Например: "C# is not C++ and PHP is not Delphi" → "Delphi not is PHP and C++ not is C#".

namespace ConsoleAppGlava13Exercises14
{
   static class WordTools
    {
        public static string ReverseWords(string sentence)
        {
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
        }
    }

    class Program
    {
         static void Main()
         {
         const string s1 = "C# is not C++ and PHP is not Delphi";
       
         string rev1 = WordTools.ReverseWords(s1);
         Console.WriteLine(rev1);
         }
    }
}