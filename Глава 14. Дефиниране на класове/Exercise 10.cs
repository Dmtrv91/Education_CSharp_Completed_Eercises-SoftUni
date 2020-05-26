using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Към класа за мобилен телефон от предходните две задачи, добавете статично поле nokiaN95, което да съхранява информация за мобилен
//телефон модел Nokia N95.Добавете метод в същия клас, който извежда информация за това статично поле.

namespace ConsoleAppGlaca14Exercises10
{
    public class Gsm
    {
        private string model;
        private string maker;
        private string price;
        private string owner;
        private string parametars;

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

        private static void Main(string[] args)
        {
            Gsm nokiaN95 = new Gsm("nokiaN95", "null", "0", "null", "null");
            Console.WriteLine(nokiaN95);
        }
    }
}

