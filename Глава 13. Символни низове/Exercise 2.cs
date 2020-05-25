using System;
using System.Text;

//Напишете програма, която прочита символен низ, обръща го отзад напред и го принтира на конзолата.Например: "introduction" → "noitcudortni".

namespace ConsoleApp2Glava13Exercises2
{
    class Program
    {
       public static string ReverseText(string text)

        {
           StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
                sb.Append(text[i]);
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            string text = "introduction";
            string reversed = ReverseText(text);

            Console.WriteLine(reversed);
        }
    }
}
