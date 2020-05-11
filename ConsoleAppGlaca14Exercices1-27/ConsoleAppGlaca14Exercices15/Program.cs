using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleAppGlaca14Exercices15
{
    //Създайте клас Call, който съдържа информация за разговор, осъщес-
    //твен през мобилен телефон.Той трябва да съдържа информация за
    //датата, времето на започване и продължителността на разговора.
    //Прочетете за класа List<T> в Интернет. Класът GSM трябва да пази
    // разговорите си в списък от тип List<Call>.
    public class Call // : IEquatable<Call>
    {
        public string date { get; set; }
        public string timeStart { get; set; }
        public string callingTime { get; set; }

       public override string ToString()
        {
           return "Date: " + date + "   Time Start: " + timeStart + "Calling time " + callingTime;
        }

       // public override bool Equals(object obj)
       // {
        //    if (obj == null) return false;
        //    Call objAsPart = obj as Call;
        //    if (objAsPart == null) return false;
        //    else return Equals(objAsPart);
       // }
     //   public override int GetHashCode()
       /// {
      //      return date;
       // }
       // public bool Equals(Call other)
       // {
       //     if (other == null) return false;
       //     return (this.date.Equals(other.date));
      //}

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

            // List<Call> callDate = new List<Call>();

            //callDate.Add(new Call { date = "date1", callingTime = "callingtime 1" });

            // Console.WriteLine(callDate);


            //callDate.Add(15.01.2020);
            //callDate.Add("16.01.2020");

            //  List<string> callTimeStart = new List<string>();
            // callTimeStart.Add("12:15:22");
            // callTimeStart.Add("12:26:22");

            //  List<string> callCallingTime = new List<string>();
            //  callCallingTime.Add("05:15");
            // callCallingTime.Add("02:26");

            // Console.WriteLine(callDate.Count);
        }
    }
}
