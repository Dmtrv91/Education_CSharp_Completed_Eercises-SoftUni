using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ConsoleAppGlaca14Exercices23
{
    //Напишете типизиран клас GenericList<T>, който пази списък от
    //елементи от тип T. Пазете елементите от списъка в масив с фиксиран
    //капацитет, който е зададен като параметър на конструктора на класа.
    //Добавете методи за добавяне на елемент, достъпване на елемент по
    //634 Принципи на програмирането със C#
    //индекс, премахване на елемент по индекс, вмъкване на елемент на
    //зададена позиция, изчистване на списъка, търсене на елемент по
    //стойност и предефинирайте метода ToString().

    //Използвайте знанията си за типизираните класове. Проверявайте
    //всички входни параметри на методите, за да се подсигурите, че няма
    //да достъпите елемент на невалидна позиция.
    public class School
    {
        private string schoolPMG;

        public School(string schoolPMG)
        {
            this.schoolPMG = schoolPMG;
        }

        public override string ToString()
        {
            return String.Format("School: {0}", this.schoolPMG);
        }
    }

    class SchoolClass
    {
        private string indifikator;
        public SchoolClass(string indifikator)
        {
            this.indifikator = indifikator;
        }

        public override string ToString()
        {
            return String.Format("SchoolClass: {0}", this.indifikator);
        }
    }

    class Student
    {
        private int id;
        private string nameStudents;

        public Student(string nameStudents, int id)
        {
            this.nameStudents = nameStudents;
            this.id = id;
        }

        public override string ToString()
        {
            return String.Format("Name Student: {0}, Student ID: {1}", this.nameStudents, this.id);
        }
    }

    class Teacher
    {
        private string teacherDiscipline;
        public Teacher(string teacherDiscipline)
        {
            this.teacherDiscipline = teacherDiscipline;
        }

        public override string ToString()
        {
            return String.Format("Teacher Discipline: {0}", this.teacherDiscipline);
        }
    }

    class Discipline
    {
        private string nameDiscipline;
        private int numberDisciplineLesson;
        private int numberDisciplineExcercises;
        public Discipline(string nameDiscipline, int numberDisciplineLesson, int numberDisciplineExcercises)
        {
            this.nameDiscipline = nameDiscipline;
            this.numberDisciplineLesson = numberDisciplineLesson;
            this.numberDisciplineExcercises = numberDisciplineExcercises;
        }

        public override string ToString()
        {
            return String.Format("Name Discrip Line: {0}, Number Discip Line Lesson: {1}, Number Discip Line Excercises {2}", this.nameDiscipline, this.numberDisciplineLesson, this.numberDisciplineExcercises);
        }
        public IList<string> Discipline = new List<string>() {"emil", "Todorov", "Ivanov"};

    }

    class TestClass
    {
       

        static void Main(string[] args)
        {

            IList<int> intList = new List<int>() { 10, 20, 30, 40 };

            foreach (var el in intList)
                Console.WriteLine(el);

            Console.WriteLine();
        }





        //School schoolPMG = new School("PMG");
        // Console.WriteLine(schoolPMG);

        //SchoolClass clas12B = new SchoolClass("12 B");
        //Console.WriteLine(clas12B);

        //Student studentIvanIvanov = new Student("Ivan Ivanov", 132);
        //Console.WriteLine(studentIvanIvanov);

        //Teacher teacherDimitarDimitrov = new Teacher("DimitarDimitrov");
        // Console.WriteLine(teacherDimitarDimitrov);
        //
        //Discipline disciplineHistory = new Discipline("History", 22, 33);
        // Console.WriteLine(disciplineHistory);

    }
    }



