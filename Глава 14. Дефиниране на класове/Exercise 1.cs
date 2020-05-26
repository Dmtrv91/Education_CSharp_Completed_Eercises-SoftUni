using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Дефинирайте клас Student, който съдържа следната информация за студентите: трите имена, курс, специалност, университет, електронна
//поща и телефонен номер.Съобразете какви типове данни да ползвате за отделните полета.

namespace ConsoleAppGlava14Exercises1
{
    public class Students
    {
        string tripleName;
        string course;
        string specialty;
        string university;
        string emailAddress;
        int phneNumber;

        string[] studentNames = new string[] { "Ivan Zmeq", "Kolio Motikata", "Ginka Kichkova" };
        string[] studentCurse = new string[] { "1", "2", "3", "4" };
        string[] studentSpecialty = new string[] { "Finance", "Marketing", "accounting" };
        string[] studentUniversity = new string[] { "Sofia University", "Business Academy", "Burgas Free University" };
        string[] studentEmailAddress = new string[] { "zmeq@abv.bg", "motikata@gmail.com", "gincheto@yahoo.com" };

        static void Main()
        {
            Students stud = new Students();

            Console.WriteLine("Triple names: {0}," + " Curse: {1}," + " Specialty: {2}," + " University: {3}," + " EmailAddress: {4} "
                    , stud.studentNames[0], stud.studentCurse[0], stud.studentSpecialty[0], stud.studentUniversity[0], stud.studentEmailAddress[0]);
            Console.WriteLine("Triple names: {0}," + " Curse: {1}," + " Specialty: {2}," + " University: {3}," + " EmailAddress: {4} "
                   , stud.studentNames[1], stud.studentCurse[1], stud.studentSpecialty[1], stud.studentUniversity[1], stud.studentEmailAddress[1]);
            Console.WriteLine("Triple names: {0}," + " Curse: {1}," + " Specialty: {2}," + " University: {3}," + " EmailAddress: {4} "
                   , stud.studentNames[2], stud.studentCurse[2], stud.studentSpecialty[2], stud.studentUniversity[2], stud.studentEmailAddress[2]);
        }

    }
}

