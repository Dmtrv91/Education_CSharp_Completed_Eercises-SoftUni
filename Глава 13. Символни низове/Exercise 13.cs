using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

//Напишете програма, която приема URL адрес във формат:
//[protocol]://[server]/[resource] и извлича от него протокол, сървър и ресурс. Например при подаден адрес: https://softuni.bg/forum резултатът е:
//[protocol]="https"
//[server]="softuni.bg"
//[resource]="/forum "

namespace ConsoleAppGlava3Exercises13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "https://softuni.bg/forum";

            string https = text.Substring(0, 5);
            string softuni = text.Substring(8, 7);
            string forum = text.Substring(18, 6);

            Console.WriteLine("[protocol]=" + https);
            
            Console.WriteLine("[server]=" + softuni);
            Console.WriteLine("[resource]=" + forum);
        }
    }
}
