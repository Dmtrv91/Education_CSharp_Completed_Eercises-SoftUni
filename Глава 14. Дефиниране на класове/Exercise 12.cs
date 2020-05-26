using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Имплементирайте метода ToString() в класа GSM, така че да връща информация за обекта под формата на string.

namespace ConsoleAppGlaca14Exercises12
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
    }

    public class Battery
    {
        private string modelBattery;
        private string idleTime;
        private string hoursTolk;

        public Battery(string modelBattery, string idleTime, string hoursTolk)
        {
            this.modelBattery = modelBattery;
            this.idleTime = idleTime;
            this.hoursTolk = hoursTolk;
        }

        public string ModelBattery { get => null; set => modelBattery = value; }
        public string IdleTime { get => null; set => idleTime = value; }
        public string HoursTolk { get => null; set => hoursTolk = value; }

        public override string ToString()
        {
            return String.Format("ModelBattery: {0}, IdleTime: {1}, HoursTolk: {2}", this.modelBattery, this.idleTime, this.hoursTolk);
        }
    }
    public class Displey
    {
        private string size;
        private string collor;

        public Displey(string size, string collor)
        {
            this.size = size;
            this.collor = collor;
        }

        public string Size { get => null; set => size = value; }
        public string Collor { get => null; set => collor = value; }
        public override string ToString()
        {
            return String.Format("Size: {0}, Collor: {1}", this.size, this.collor);
        }

    }
    class TestGsmDispley
    {
        public static void Main(string[] args)
        {
            Gsm nokia = new Gsm("proba1", "proba2", "3.33", "proba3", "proba4");
            Console.WriteLine(nokia);

            Battery battery = new Battery("proba1.1", "proba2.1", "proba3.1");
            Console.WriteLine(battery);

            Displey led = new Displey("proba1.2", "proba2.2");
            Console.WriteLine(led);
        }
    }
}
