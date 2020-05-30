using System;

//Да се напише програма, която създава масив с всички букви от латинската азбука. Да се даде възможност на потребител да въвежда
//дума от конзолата и в резултат да се извеждат индексите на буквите от думата.

namespace ConsoleAppGlava7Exercises15
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("Enter a word: ");
            char[] word = (Console.ReadLine()).ToCharArray();

            for (int i = 1; i < word.Length; i++)
                for (int j = 1; j < alphabet.Length; j++)
                    if (word[i] == alphabet[j]) Console.Write("{0} ", j); 
        }
    }
}
