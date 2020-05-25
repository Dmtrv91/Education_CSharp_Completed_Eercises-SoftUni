using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppGlava13Exercises9

//Напишете програма, която кодира текст по даден шифър като прилага шифъра побуквено с операция XOR(изключващо или) върху текста.
//Кодирането трябва да се извършва, като се прилага XOR между първата буква от текста и първата буква на шифъра, втората буква от текста и
//втората буква от шифъра и т.н.до последната буква от шифъра, след което се продължава отново с първата буква от шифъра и поредната
//буква от текста.Отпечатайте резултата като поредица от Unicode кодирани екраниращи символи.

{
    class Program
    {
        static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + shift);

                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
            return new string(buffer);
        }

        static void Main()
        {
            string a = "Nakov";
            string a1 = Caesar(a, 18);

            byte[] unibyte = Encoding.Unicode.GetBytes(a1);
            string uniString = string.Empty;
            foreach (byte b in unibyte)
            {
            uniString += string.Format("{0}{1}", @"\u", b.ToString("X"));

            }
            Console.WriteLine(a);
            Console.WriteLine(a1);
            Console.WriteLine(uniString);
        }
    }
}