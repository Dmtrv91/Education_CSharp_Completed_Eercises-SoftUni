using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Напишете програма, която извлича от даден текст всички изречения, които съдържат определена дума.Считаме, че изреченията са
//разделени едно от друго със символа ".", а думите са разделени една от друга със символ, който не е буква. Примерен текст:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.So we are drinking all the
//day. We will move out of it in 5 days.
//Примерен резултат: We are living in a yellow submarine.We will move out of it in 5 days.

namespace ConsoleAppGlava13Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else." +
                 "Inside the submarine is very tight. So we are drinking all the" +
                 "day.We will move out of it in 5 days.";

            char[] delimiterChars = {'.'};
            
            Console.WriteLine($"Original text: '{text}'");

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine($"{words.Length} words in text:");

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
            string search = "in";

            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", search, index);
                index = smallText.IndexOf(search, index + search.Length);
            }
        }
    }
}
