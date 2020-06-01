using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleAppGlava20Exercises6

//Имплементирайте следните обекти: куче (Dog), жаба (Frog), котка (Cat), котенце (Kitten), котарак(Tomcat). Всички те са животни(Animal). Жи-
//вотните се характеризират с възраст(age), име(name) и пол(gender). Всяко животно издава звук(виртуален метод на Animal). Направете ма-
//сив от различни животни и за всяко изписвайте на конзолата името, въз- растта и звука, който издава.

{
    public class Animal
    {
        public int[] Age = { 1, 2, 3, 4, 5 };
        public string[] Name = new string[] {"Name1", "Name2", "Name3", "Name4", "Name5" };
        public string[] Gender = new[] { "man", "woman" };

        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("------DOG------");
            Console.WriteLine("The name is: " + Name[0].ToString() + " The age is: " + Age[0].ToString() + " The gender is: " + Gender[0].ToString());
            Console.WriteLine("The dog says: Bow, Bow");
        }
    }
    class Frog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("------Frog------");
            Console.WriteLine("The name is: " + Name[1].ToString() + " The age is: " + Age[1].ToString() + " The gender is: " + Gender[1].ToString());
            Console.WriteLine("The frog says: Djvak, Djvak");
        }
    }
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("------Cat------");
            Console.WriteLine("The name is: " + Name[2].ToString() + " The age is: " + Age[2].ToString() + " The gender is: " + Gender[1].ToString());
            Console.WriteLine("The cat says: miay, miay");
        }
    }
    class Kitten : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("------Kitten------");
            Console.WriteLine("The name is: " + Name[3].ToString() + " The age is: " + Age[3].ToString() + " The gender is: " + Gender[0].ToString());
            Console.WriteLine("The Kitten says: miay, miay");
        }
    }
    class Tomcat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("------TomCat------");
            Console.WriteLine("The name is: " + Name[3].ToString() + " The age is: " + Age[3].ToString() + " The gender is: " + Gender[0].ToString());
            Console.WriteLine("The TomCat says: miay, miay");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myFrog = new Frog();
            Animal myCat = new Cat();
            Animal myKitten = new Kitten();
            Animal myTomCat = new Tomcat();

            myAnimal.animalSound();
            myDog.animalSound();
            myFrog.animalSound();
            myCat.animalSound();
            myKitten.animalSound();
            myTomCat.animalSound();
        }
    } 
}

