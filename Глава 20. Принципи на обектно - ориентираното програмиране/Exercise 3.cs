using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleAppGlava20Exercises3
{
//Инициализирайте масив от 10 студента и ги сортирайте по оценка в нарастващ ред.Използвайте интерфейса System.IComparable<Т>.

    class Student : IComparable<Student>
    {
        public int Ocenka { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Ocenka == other.Ocenka)
            {
                return this.Name.CompareTo(other.Name);
            }
            return other.Ocenka.CompareTo(this.Ocenka);
        }

        public override string ToString()
        {
            return this.Name + " - " + this.Ocenka.ToString();
        }
    }
    class Program
    {
        static void Main()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { Name = "Mitko", Ocenka = 6 });
            list.Add(new Student() { Name = "Ivan", Ocenka = 5 });
            list.Add(new Student() { Name = "Georgi", Ocenka = 2 });
            list.Add(new Student() { Name = "Georgi", Ocenka = 3 });
            list.Add(new Student() { Name = "Sasho", Ocenka = 3 });
            list.Add(new Student() { Name = "Sergei", Ocenka = 2 });
            list.Add(new Student() { Name = "Spas", Ocenka = 5 });
            list.Add(new Student() { Name = "Alex", Ocenka = 4 });
            list.Add(new Student() { Name = "Neli", Ocenka = 6 });
            list.Add(new Student() { Name = "Emil", Ocenka = 4 });

            Student gg = new Student();
            list.Sort();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
