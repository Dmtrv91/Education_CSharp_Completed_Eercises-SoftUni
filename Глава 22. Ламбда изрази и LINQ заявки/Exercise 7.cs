using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Globalization;

//Напишете разширяващ метод на класа String, който прави главна всяка буква, която е начало на дума в изречение на английски език.
//Например текстът "this iS a Sample sentence." трябва да стане на "This Is A Sample Sentence.".

namespace ConsoleAppGlava22Exercises7
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This Is A Sample Sentence.";
            string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
            Console.WriteLine(titleCase);
        }
    }
}
