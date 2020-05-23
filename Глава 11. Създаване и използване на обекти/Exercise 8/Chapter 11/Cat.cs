using System;

namespace ConsoleAppGlava11Exercise7Cat
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void sayMiau()
        {
            Console.WriteLine("{0}: Miauu", name);   
        }
    }
}