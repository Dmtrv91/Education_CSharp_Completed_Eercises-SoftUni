using System;

//* Напишете програма, която преобразува дадено число в интервала[0..999] в текст, съответстващ на английското произношение на числото.Примери:
//- 0 → "Zero"
//- 12 → "Twelve"
//- 98 → "Ninety eight"
//- 273 → "Two hundred seventy three"
//- 400 → "Four hundred"
//- 501 → "Five hundred and one"
//- 711 → "Seven hundred and eleven"

namespace ConsoleAppGlava5Exercises11
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string[] a = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            string[] b = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] c = new string[] { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] d = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string h = "hundred";

            if (n <= 10)
            {
                string outun = a[n - 1];
                Console.WriteLine(outun);
            }

            else if (n > 10 && n > 20 && n < 100)
            {
                int units = n % 10;
                int digits = n /= 10;
                string outputd = c[digits];
                string outputun = d[units];
                Console.WriteLine("{0} {1}", outputd, outputun);
            }

            else if (n > 10 && n < 20)
            {
                int units1 = n % 10;
                string oout = b[units1];
                Console.WriteLine(oout);
            }

            else if (n % 10 == 0 && n < 100)
            {
                int desetici = (n / 10);
                string desetki = c[desetici];
                Console.WriteLine(desetki);
            }

            else if (n / 100 == 1)
            {
                if (n < 101)
                {
                    int stotici = n / 100;
                    string sto = a[stotici - 1];
                    Console.WriteLine("{0} {1}", sto, h);
                }
            }
            if (n > 100)
                Console.WriteLine("invalid number");
        }

    }
}