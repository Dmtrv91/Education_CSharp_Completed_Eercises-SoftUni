using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

//Напишете LINQ заявка, която намира първото име и фамилията на всички студенти, които са на възраст между 18 и 24 години включи-
//телно.Използвайте класа Student от предната задача. Използвайте LINQ заявка, за да създадете анонимен тип, който
//съдържа само 2 свойства – FirstName и LastName.

namespace ConsoleAppGlava22Exercises4
{
    public class Student
    {
        public string FurstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { FurstName = "Ivan", LastName = "Ivanov", Age = 18 },
                new Student() { FurstName = "Dimitar", LastName = "Dimitrov", Age = 17 },
                new Student() { FurstName = "Simeon", LastName = "Simeonov", Age = 24 },
                new Student() { FurstName = "Simeon", LastName = "Ivanov", Age = 31 },
                new Student() { FurstName = "Rusi", LastName = "Simeonov", Age = 29 },
            };
            List<Student> studentTarget = students.FindAll(delegate (Student p) { return p.Age >= 18 && p.Age <= 24; });
            Console.WriteLine("/Age 18 - 25/");
            studentTarget.ForEach(delegate (Student p)
            { 
                Console.WriteLine(String.Format("{0} {1}", p.FurstName, p.LastName));
            }
            );
            Console.WriteLine("---------------------");
            Console.WriteLine("/Linq age 18 - 25/");
            var newStudentList = studentTarget
           .Select(x => new { FurstName = x.FurstName, LastName = x.LastName });
            foreach (var item in newStudentList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
