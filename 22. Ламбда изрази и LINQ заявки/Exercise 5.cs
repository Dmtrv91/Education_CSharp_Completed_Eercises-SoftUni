using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

//Като използвате разширяващите методи OrderBy(…) и ThenBy(…) с ламбда израз, сортирайте списък от студенти по първо име и по
//фамилия в намаляващ лексикографски ред.Напишете същата функционалност, използвайки LINQ заявка.

namespace ConsoleAppGlava22Exercises5
{
    public class Student
    {
        public string FurstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student() { FurstName = "Ivan", LastName = "Ivanov", Age = 18 },
                new Student() { FurstName = "Dimitar", LastName = "Dimitrov", Age = 17 },
                new Student() { FurstName = "Simeon", LastName = "Simeonov", Age = 24 },
                new Student() { FurstName = "Simeon", LastName = "Ivanov", Age = 31 },
                new Student() { FurstName = "Rusi", LastName = "Simeonov", Age = 29 }, 
            };
            var studentsSortByFurstName = studentsList.OrderBy(s => s.FurstName).ThenBy(s => s.Age);
            Console.WriteLine("Sorty by furst Name: ");
            foreach (var fName in studentsSortByFurstName)
                Console.WriteLine(fName.FurstName);

            var studentsSortByLastName = studentsList.OrderBy(s => s.LastName);
            Console.WriteLine(" ");
            Console.WriteLine("Sorty by last Name: ");
            foreach (var lName in studentsSortByLastName)
                Console.WriteLine(lName.LastName);
        }
    }
}