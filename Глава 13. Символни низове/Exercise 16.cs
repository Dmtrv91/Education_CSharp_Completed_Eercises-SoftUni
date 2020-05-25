using System;

//Напишете програма, която заменя в HTML документ всички препратки(hyperlinks) от вида<a href= "…" >…</a> с препратки стил "форум", които имат вида[URL =…]…/URL].
// резултат: <p>Please visit [URL=http://softuni.bg] our site[/URL] to choose a software engineering training course.Also visit
//[URL=http://softuni.bg/forum]our forum[/URL] to discuss the courses.</p>

namespace ConsoleAppGlava13Exercises16
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "<p>Please visit <a href=http://softuni.bg>our site</a> " +
                "tochoose a software engineering training course. Also visit<a" +
                "href= http://softuni.bg/forum > our forum</ a > to discuss the courses.</ p > ";

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
