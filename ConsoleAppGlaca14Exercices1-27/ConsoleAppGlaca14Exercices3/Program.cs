using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGlaca14Exercices3
{
    //Добавете статично поле в класа Student, в което се съхранява броя
    //на създадените обекти от този клас.

    //Използвайте конструктора на класа като място, където броят на
    // обектите от класа Student се увеличава.Пазете този брой в статично
    // поле в класа Student.
    public class Students
    {
        static int lists = 0;
        string tripleName = null;
        string course = null;
        string specialty = null;
        string university = null;
        string emailAddress = null;
        string phnoNumber = null;

        public Students(string tripleName, string course, string specialty, string university, string emailAddress, string phoneNumber)
        {
            this.tripleName = tripleName;
            this.course = course;
            this.specialty = specialty;
            this.university = university;
            this.emailAddress = emailAddress;
            this.phnoNumber = phoneNumber;

            Students.lists += 1;

        }



        public static void Main()
        {
             Students list1 = new Students("Ivan Ivanov Ivanov", "1", "Finansi", "Nov Balgarski", "vankata@abv.bg", " +35988888888");
             Console.WriteLine(" Name: {0}, " + " Kurs: {1}, " + "Specianost: {2} , " + "Universitet: {3} , " + "Email: {4} , " + "Telefon: {5}."
              , list1.tripleName, list1.course, list1.specialty, list1.university, list1.emailAddress, list1.phnoNumber);
           
            Students list2 = new Students("Dimitar Dimitrov Dimitrov", "3", "Marketing", "Uni-Svishotv", "mitaka@abv.bg", " +35988888888");
            Console.WriteLine(" Name: {0}, " + " Kurs: {1}, " + "Specianost: {2} , " + "Universitet: {3} , " + "Email: {4} , " + "Telefon: {5}."
              , list2.tripleName, list2.course, list2.specialty, list2.university, list2.emailAddress, list2.phnoNumber);

            Console.WriteLine("Students lists is now " + Students.lists);
        }



    }
}

