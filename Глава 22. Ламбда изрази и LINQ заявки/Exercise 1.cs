using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava22Exercises1

//Имплементирайте разширяващ метод Substring(int index, int length)
//за класа StringBuilder, който връща нов StringBuilder и има същата
//функционалност като метода Substring(…) на класа String.

{
    class Program
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                builder.Append(i).Append(" ");
            }
            Console.WriteLine(builder);
        }
    }
}
