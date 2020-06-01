using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleAppGlava20Exercises4
{
//Инициализирайте масив от 10 работника и ги сортирайте по заплата в намаляващ ред.

    class Worker : IComparable<Worker>
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(Worker other)
        {
            if (this.Salary == other.Salary)
            {
                return this.Name.CompareTo(other.Name);
            }
            return other.Salary.CompareTo(this.Salary);
        }

        public override string ToString()
        {
            return this.Name + " - " + this.Salary.ToString() + " " + "лева.";
        }
    }
    class Program
    {
        static void Main()
        {
            List<Worker> list = new List<Worker>();
            list.Add(new Worker() { Name = "Mitko", Salary = 600 });
            list.Add(new Worker() { Name = "Ivan", Salary = 523 });
            list.Add(new Worker() { Name = "Georgi", Salary = 242 });
            list.Add(new Worker() { Name = "Georgi", Salary = 653 });
            list.Add(new Worker() { Name = "Sasho", Salary = 334 });
            list.Add(new Worker() { Name = "Sergei", Salary = 652 });
            list.Add(new Worker() { Name = "Spas", Salary = 745 });
            list.Add(new Worker() { Name = "Alex", Salary = 234 });
            list.Add(new Worker() { Name = "Neli", Salary = 6 });
            list.Add(new Worker() { Name = "Emil", Salary = 764 });

            list.Sort();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
