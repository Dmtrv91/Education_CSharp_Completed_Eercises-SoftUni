using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Напишете програма, която открива колко пъти даден подниз се съдържа в текст.Например нека търсим подниза "in" в текста:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.So we are drinking all the
//day. We will move out of it in 5 days.
//резултат 9

namespace ConsoleAppGlava13Exercises5
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "We are living in a yellow submarine. We don't have anything else." +
                "Inside the submarine is very tight. So we are drinking all the" +
                "day.We will move out of it in 5 days.";
            String search = "in";

            string smallText = text.ToLower();

            int index = smallText.IndexOf(search);
            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", search, index);
                index = smallText.IndexOf(search, index + search.Length);
            }  
        }
    }
   
}
