using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Добавете изброим тип BatteryType, който съдържа стойности за тип на батерията(Li-Ion, NiMH, NiCd, …), и го използвайте като ново поле за класа Battery.

namespace ConsoleAppGlaca14Exercises11
{
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

        enum BatteryModel
        {
           LiIon, NiMH, NiCd
        }
         
        static void Main(string[] args)
        {
            Battery BatteryLiIon = new Battery("Li-IOn", "1111111", "22222222");
                   Console.WriteLine(BatteryLiIon);

            Battery BatteryNiMH = new Battery("NiMH", "333333", "444444");
            Console.WriteLine(BatteryNiMH);

            Battery BatteryNiCd = new Battery("NiCd", "555555", "666666");
            Console.WriteLine(BatteryNiCd);
        }
    }
}

