using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGlaca14Exercices22
{
    //Дадено ни е училище. В училището имаме класове и ученици. Всеки
    //клас има множество от преподаватели.Всеки преподавател има мно-
    //жество от дисциплини, по които преподава.Учениците имат име и
    //уникален номер в класа.Класовете имат уникален текстов иден-
    //тификатор.Дисциплините имат име, брой уроци и брой упражнения.
    //Задачата е да се моделира училище с C# класове. Трябва да деклари-
    //рате класове заедно с техните полета, свойства, методи и конструк-
    //тори.Дефинирайте и тестов клас, който демонстрира, че останалите
    //класове работят коректно.

    //Създайте класове School, SchoolClass, Student, Teacher, Discipline и в
    //тях дефинирайте съответните им полета, както са описани в условието
    //на задачата.Не ползвайте за име на клас думата "Class", защото в C#
    //тя има специално значение.Добавете методи за отпечатване на всички
    //полета от всеки от класовете.
    public class School
    {
        private string schoolPMG;

        public School (string schoolPMG)
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
    }

    class TestClass
    {
        public static void Main(string[] args)
        {
           School schoolPMG = new School ("PMG");
           Console.WriteLine(schoolPMG);

           SchoolClass clas12B = new SchoolClass("12 B");
           Console.WriteLine(clas12B);

           Student studentIvanIvanov = new Student("Ivan Ivanov", 132);
           Console.WriteLine(studentIvanIvanov);

           Teacher teacherDimitarDimitrov = new Teacher("DimitarDimitrov");
           Console.WriteLine(teacherDimitarDimitrov);

           Discipline disciplineHistory = new Discipline("History", 22, 33);
           Console.WriteLine(disciplineHistory);

        }
    }
}

