using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;


//Нека е дадено едно училище. В училището има класове от ученици. Всеки клас има множество от учители.Всеки учител преподава множес-
//тво от предмети. Учениците имат име и уникален номер в класа. Класовете имат уникален текстов идентификатор.Учителите имат име.
//Предметите имат име, брой на часове и брой упражнения. Както учителите, така и студентите са хора.Вашата задача е да моделирате
//класовете (в контекста на ООП) заедно с техните атрибути и операции, дефинирате класовата йерархия и създайте диаграма с Visual Studio.

namespace ConsoleAppGlava20Exercises1
{
    class School
    {
        class Student
        {
            public string StudentName { get; set; }
            public int StudentId { get; set; }
        }
        class StudentClass
        {
            public string ClassName { get; set; }
        }
        class StudentTeacher
        {
            public string ClassTeacherName { get; set; }
        }
        class StudentObjects
        {
            public string ClassObjectsName { get; set; }
            public int ClassObjectsLectureNumbers { get; set; }
            public int ClassObjectsExerciseNumbers { get; set; }
        }
    }
}


