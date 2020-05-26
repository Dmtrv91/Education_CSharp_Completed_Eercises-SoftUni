using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Напишете клас GSMTest, който тества функционалностите на класа GSM.Създайте няколко обекта от дадения клас и ги запазете в масив.
//Изведете информация за създадените обекти.Изведете информация за статичното поле nokiaN95.

namespace ConsoleAppGlaca14Exercises14
{
    class Gsm
    {
        public string model;
        public string maker;
        public string price;
        public string owner;
        public string parametars;

        public Gsm(string model, string maker, string price, string owner, string parametars)
        {
            this.model = model;
            this.maker = maker;
            this.price = price;
            this.owner = owner;
            this.parametars = parametars;
        }

        public string Model { get => null; set => model = value; }
        public string Maker { get => null; set => maker = value; }
        public string Price { get => null; set => price = value; }
        public string Owner { get => null; set => owner = value; }
        public string Parametars { get => null; set => parametars = value; }

        public override string ToString()
        {
            return String.Format("Model: {0}, Maker: {1}, Price: {2}, Owner: {3}, Parametars: {4}", this.model, this.maker, this.price, this.owner, this.parametars);
        }

        public phoneModell (string phones)
        {
            Gsm phoneNokia = new Gsm("proba1", "proba2", "3.33", "proba3", "proba4");
            string[] phones = { phoneNokia };
        }
        public static void Main()
        {
            Console.WriteLine(phoneNokia);
        }
    }
}