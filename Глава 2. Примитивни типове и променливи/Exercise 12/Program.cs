using System;

namespace ConsoleAppGlava2Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Фирма, занимаваща се с маркетинг, 
            //иска да пази запис с данни на нейните 
            //служители. Всеки запис трябва да има 
            //следната характе-ристика – първо име, 
            //фамилия, възраст, пол (‘м’ или ‘ж’) и 
            //уникален номер на служителя (27560000 до 27569999).
            //Декларирайте необходи-мите променливи нужни,
            //за да се запази информацията за един служи-тел,
            //като използвате подходящи типове данни и 
            //описателни имена.

            Console.Write("Furst name: ");
            string furstName = Console.ReadLine();
            Console.Write("Second name: ");
            string secondName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Sex: ");
            char gender = char.Parse(Console.ReadLine());
            Console.Write("Pesonal № ");
            int number = int.Parse(Console.ReadLine());

            string Name1 = "Dimitar";
            string Name2 = "Veselinov";
            string Name3 = "Dimitrov";
            string sex = "M";
            int n = 27321123;

            Console.WriteLine("Furst name: " + Name1);
            Console.WriteLine("Second name: " + Name2);
            Console.WriteLine("Last name: " + Name3);
            Console.WriteLine("sex: " + sex);
            Console.WriteLine("Unikue N: " + n);
        }
    }
}
