using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Даден е символен низ, съставен от няколко "забранени" думи, разделени със запетая.Даден е и текст, съдържащ тези думи.Да се напише
//програма, която замества забранените думи в текста със звездички.Примерен текст:
//Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR.
//********* announced its next generation ** compiler today. It uses advanced parser and special optimizer for the************.

namespace ConsoleAppGlava13Exercises11
{ 
    public class Word
    {
        public string SearchWord { get; set; }
        public string ReplaceWord { get; set; }
    
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation C# compiler today. It" +
            "uses advanced parser and special optimizer for the Microsoft CLR.";

            Console.WriteLine(text);
                        
            List<Word> words = new System.Collections.Generic.List<Word>();
            words.Add(new Word() { SearchWord = "C#", ReplaceWord = "**" });
            words.Add(new Word() { SearchWord = "Microsoft", ReplaceWord = "*********" });
            words.ForEach(w => text = text.Replace(w.SearchWord, w.ReplaceWord));
            
            Console.WriteLine(text);
        }   
    }
}
