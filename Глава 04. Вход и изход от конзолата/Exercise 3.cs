using System;

//Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер.
namespace ConsoleAppConsoleAppGlava4Exercises3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Company: ");
            string firm = Console.ReadLine();

            Console.Write("Adres: ");
            string adres = Console.ReadLine();

            Console.Write("Phone number: ");
            string telephon = Console.ReadLine();

            Console.Write("Faks:");
            string faks = Console.ReadLine();

            Console.Write("Web site: ");
            string site = Console.ReadLine();

            Console.Write("Manager name: ");
            string fmanager = Console.ReadLine();


            Console.Write("Inormation of Manager: ");
            Console.Write(" Furs name");
            string mFurstName = Console.ReadLine();

            Console.Write("second name is ");
            string mLastName = Console.ReadLine();

            Console.Write("her phone number is ");
            string mPhonNumber = Console.ReadLine();

            Console.WriteLine("Compani names is {0}. Her informacion for comunication is : adres {1}, phone number {2}, faks {3}, web site {4} and Manager {5}.", 
                firm, adres, telephon, faks, site, fmanager);
            Console.WriteLine("Manager informacion: Furst name: {0}, Second name : {1} and phone number: {2} ", mFurstName, mLastName, mPhonNumber);
        }
    }
}
