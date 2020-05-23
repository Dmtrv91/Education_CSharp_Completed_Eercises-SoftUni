using System;

//Напишете програма, която генерира случайно рекламно съобщение за някакъв продукт.Съобщенията трябва да се състоят от хвалебствена фраза, следвани от хвалебствена случка, следвани от
//автор (първо и второ име) и град, които се избират от предварително подготвени списъци.Например, нека имаме следните списъци:
//- Хвалебствени фрази: {"The product is excellent", "This is a great product.", "I use this products all the time.", "This is the best product from this category."}.
//- Хвалебствени случки: {"Now I feel better.", "I managed to change.", "It made a miracle.", "I can’t believe it, but I am feeling great now.", "You should try it too. I am very satisfied."}.
//- Първо име на автор: { "Diana", "Petya", "Stela", "Elena", "Katya"}.
//-Второ име на автор: { "Ivanova", "Petrova", "Kirova"}.
//-Градове: { "Sofia", "Plovdiv", "Varna", "Ruse", "Burgas"}. Тогава програма би могла да изведе следното случайно-генерирано рекламно съобщение:
//I use this product all the time. You should try it too. I am very satisfied. -- Elena Petrova, Plovdiv

namespace ConsoleAppGlava11Exercises11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] firstNames = new string[] { "Diana", "Petia", "Stela", "Elena", "Katia" };
            string[] secondNames = new string[] { "Ivanova", "Petrova", "Kirova", "Popova" };
            string[] cities = new string[] { "Sofia", "Plovdiv", "Varna", "Ruse", "Dolno konare" };
            string[] reviews1 = new string[] { "This product is excelent.", "This is a great product.", "I use this product all the time.", "This is the best product of this category." };
            string[] reviews2 = new string[] { "Now I feel better.", "I changed.", "It was a miracle.", "I can't believe it. Now I feel better.", "Try it yourself. I'm very greatful." };

            Console.WriteLine("{0} {1} {2} {3}, {4}.", reviews1[rnd.Next(4)], reviews2[rnd.Next(5)], firstNames[rnd.Next(5)], secondNames[rnd.Next(4)], cities[rnd.Next(5)]);
        }
    }
}