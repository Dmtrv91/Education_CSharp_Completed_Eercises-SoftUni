using System;

//Напишете програма, която извежда на стандартния изход броя на дните, часовете и минутите, които са изтекли от включването на
//компютъра до момента на изпълнението на програмата.За реализацията използвайте класа Environment.

namespace ConsoleAppGlava11Exercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            var mo = new ManagementObject(@"\\.\root\cimv2:win32_OperationgSystem=@");
            var lastBootup = managementDateTimeConvert.ToDateTime(mo["LastBootUpTime"].ToString());
            Console.WriteLine(DateTime.Now.ToUniversalTime() - lastBootup.ToUniversalTime());
        }
    }
}