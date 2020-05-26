using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Дефинирайте клас, който съдържа информация за мобилен телефон: модел, производител, цена, собственик, характеристики на батерията
//(модел, idle time и часове разговор /hours talk/) и характеристики на екрана(големина и цветове).

namespace ConsoleAppGlaca14Exercises8
{
    public class GSM
    {
        private string model;
        private string maker;
        private string price;
        private string owner;
        private string parametars;
    }
   
    public class Battery
    {
        private string model;
        private string idleTime;
        private string hoursTolk;
    }
    public class Displey
    {
        private string size;
        private string collor;
    }
}
