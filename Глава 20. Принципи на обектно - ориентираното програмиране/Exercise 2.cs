using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleAppGlava20Exercises2

//Дефинирайте клас Human със свойства "собствено име" и "фамилно име". Дефинирайте клас Student, наследяващ Human, който има свойство "оцен-
//ка". Дефинирайте клас Worker, наследяващ Human, със свойства "надница" и "изработени часове". Имплементирайте и метод "изчисли надница за 1
//час", който смята колко получава работникът за 1 час работа на базата на надницата и изработените часове.Напишете съответните конструкто-
//ри и методи за достъп до полетата(свойства)
{
    class Program
    {
        public class Human
        {
            public string FurstName;
            public string LastName;
            public void GetUserInfo(string nameFurst, string nameLast)
            {
                FurstName = nameFurst;
                LastName = nameLast;

                Console.WriteLine("Име: {0}", nameFurst);
                Console.WriteLine("Фамилия: {0}", nameLast);
            }
        }
        public class Student : Human
        {
            public int Ocenka;
            public void GetOcenka()
            {
                Console.WriteLine("Оценка: {0}", Ocenka);
            }
        }
        public class Worked : Human
        {
            public double Nadnik;
            public double WorkedHourse;
            public double HourPey;
            public void GetWorked()
            {
                Console.WriteLine("Надница: {0} лв. на ден и дневни работни часове: {1} часа ", Nadnik, WorkedHourse);
                HourPey = WorkedHourse / Nadnik;
                Console.WriteLine("Изработената надница за един час е : {0} лв. ", HourPey);
            }
            class Test
            {
                static void Main(string[] args)
                {
                    Human hourse = new Human();
                    hourse.FurstName = "Иван";
                    hourse.LastName = "Иванов";
                    hourse.GetUserInfo(hourse.FurstName, hourse.LastName);

                    Student ocenka = new Student();
                    ocenka.Ocenka = 6;
                    ocenka.GetOcenka();

                    Worked w = new Worked();
                    w.Nadnik = 10;
                    w.WorkedHourse = 8;
                    w.GetWorked();
                }
            }
        }
    }
}