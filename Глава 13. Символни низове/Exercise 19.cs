using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Напишете програма, която извлича от даден текст всички e-mail адреси.Това са всички поднизове, които са ограничени от двете
//страни с край на текст или разделител между думи и съответстват на формата<sender>@<host>…<domain>. Примерен текст:
//text = "Please contact us by phone (+359 222 222 222) or by email at" + "example @abv.bg or at test.user @yahoo.co.uk.This is not email:" +
//"test @test. This also: @gmail.com.Neither this: a @a.b.";
//Извлечени e-mail адреси от примерния текст: example @abv.bg test.user @yahoo.co.uk

namespace ConsoleAppGlava13Exercises19
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at" +
            "example @abv.bg or at test.user @yahoo.co.uk.This is not email:" +
             "test @test. This also: @gmail.com.Neither this: a @a.b.";

            string[] splitText = text.Split(' ');
            List<string> mailList = new List<string>();
            MailCollector(splitText, mailList);

            foreach (var email in mailList)
            {
                Console.WriteLine(email);
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
        private static void MailCollector(string[] split, List<string> emails)
        {
            for (int i = 0; i < split.Length; i++)
            {
                if (Regex.IsMatch(split[i], @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
                {
                    emails.Add(split[i]);
                }
            }
        }
    }
}