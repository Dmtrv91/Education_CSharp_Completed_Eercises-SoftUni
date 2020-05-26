using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

//Създайте клас Call, който съдържа информация за разговор, осъществен през мобилен телефон.Той трябва да съдържа информация за датата, времето на 
//започване и продължителността на разговора. Прочетете за класа List<T> в Интернет. Класът GSM трябва да пази разговорите си в списък от тип List<Call>.

namespace ConsoleAppGlaca14Exercises15
{
    public class Call 
    {
        public string date { get; set; }
        public string timeStart { get; set; }
        public string callingTime { get; set; }

       public override string ToString()
        {
           return "Date: " + date + "   Time Start: " + timeStart + "Calling time " + callingTime;
        }
    }

    class Gsm
    {
        static void Print(IList<string> list)
        {
            Console.WriteLine("Count: {0}", list.Count);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }

        public static void Main()
        {
            string[] strArray = new string[2];
            strArray[0] = "Hello";
            strArray[1] = "World";
            Print(strArray);

            List<string> strList = new List<string>();
            strList.Add("Hello");
            strList.Add("World");
            Print(strList);
        }
    }
}
