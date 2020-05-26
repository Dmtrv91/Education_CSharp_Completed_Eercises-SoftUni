using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Модифицирайте текущия код на класа Student така, че да капсулирате данните в класа чрез свойства.

namespace ConsoleAppGlaca14Exercises5
{
    public class Students
    {
        static int lists = 0;

        private string tripleName;
        public static int Lists;
        
        private string course;
        private string specialty;
        private string university;
        private string emailAddress;
        private string phoneNumber;

        public Students(string tripleName, string course, string specialty, string university, string emailAddress, string phoneNumber)
        {
            this.tripleName = tripleName;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;

            Students.Lists += 1;
        }
        public string TripleName { get => null; set => tripleName = value; }
        public string Course { get => null; set => Course = value; }
        public string Specialty { get => null; set => specialty = value; }
        public string University { get => null; set => university = value; }
        public string EmailAddress { get => null; set => emailAddress = value; }
        public string PhnoNumber { get => null; set => phoneNumber = value; }

        public static void Main()
        {
            Students list1 = new Students("Ivan Ivanov Ivanov", "1", "Finansi", "Nov Balgarski", "vankata@abv.bg", " +35988888888");
            list1.Studentss();
            Console.WriteLine(" Name: {0}, " + " Kurs: {1}, " + "Specianost: {2} , " + "Universitet: {3} , " + "Email: {4} , " + "Telefon: {5}."
             ,list1.TripleName, list1.Course, list1.Specialty, list1.University, list1.EmailAddress, list1.PhnoNumber);

            Console.WriteLine("Students lists is now " + Students.Lists);
        }

        private void Studentss()
        { 
        }
    }
}

