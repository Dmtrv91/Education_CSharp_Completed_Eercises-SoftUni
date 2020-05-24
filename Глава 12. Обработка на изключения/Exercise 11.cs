using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGlava12Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient Client = new WebClient();

            try
            {
                Client.DownloadFile("https://softuni.bg/", @"C:\Users\Lenovo\Desktop\web.html");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address or fileName parameter is null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error! Possible causes:\n1. The URI formed by combining BaseAddress and address is invalid.\n2. filename is null or Empty.\n3. The file does not exist.\n4. An error occurred while downloading data.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            Console.WriteLine("GOOD");
        }
    }
}