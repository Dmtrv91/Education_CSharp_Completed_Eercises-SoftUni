using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Даден е текст. Напишете програма, която променя регистъра на буквите до главни на всички места в текста, заградени с таговете<upcase> и</upcase>.Таговете не могат да бъдат вложени.

namespace ConsoleAppGlava13Exercises6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. " +
                 "We don'thave<upcase> anything</ upcase > else.";

            string badText1 = "< upcase > yellow submarine </ upcase >"; 
            string badText2 = "<upcase> anything</ upcase >"; 

            string getText1 = "yellow submarine";
            string getText2 = "anything";

           string upGetText1 = getText1.ToUpper();
           string upGetText2 = getText2.ToUpper();

            string fileText = text.Replace("< upcase > yellow submarine </ upcase >", "yellow submarine");

            Console.WriteLine(fileText);
        }
    }
}
