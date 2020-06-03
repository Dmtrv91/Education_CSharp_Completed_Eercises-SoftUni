using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava18Exercises3

//Напишете програма, която по даден текст във текстов файл, преброява колко пъти се среща всяка дума.Отпечатайте на конзолата всички
//думи и по колко пъти се срещат, подредени по брой срещания.
//Пример: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
//Резултат: is → 2, the → 2, this → 3, text → 6

{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string s1, string s2) => string.Compare(s1, s2, true);

        private static readonly string Text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";

        public static void Main()
        {
            var wordOccurrences = GetWordOccurrences(Text);
            PrintWordOccurrenceCount(wordOccurrences);
        }

        static IDictionary<string, int> GetWordOccurrences(string text)
        {
            string[] tokens = text.Split(' ', '.', ',', '-', '?', '!', '–');
            var words = new SortedDictionary<string, int>(new CaseInsensitiveComparer());

            foreach (string word in tokens)
            {
                if (!string.IsNullOrEmpty(word.Trim()))
                {
                    int count = 0;
                    words.TryGetValue(word, out count);
                    words[word] = count + 1;
                }
            }
            return words;
        }

        static void PrintWordOccurrenceCount(IDictionary<string, int> wordOccurrence)
        {
            foreach (var wordEntry in wordOccurrence)
            {
                Console.WriteLine("Word '{0}' occurs {1} time(s) in the text", wordEntry.Key, wordEntry.Value);
            }
        }
    }
}
