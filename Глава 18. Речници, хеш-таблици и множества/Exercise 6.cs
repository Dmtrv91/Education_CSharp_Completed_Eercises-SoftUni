using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleAppGlava18Exercises6

//Реализирайте хеш-таблица, която позволява по даден ключ да съхраняваме повече от една стойност.

{
    class Program
    {
        static void Main()
        {
            IDictionary<string, IList<string>> specTimes = new Dictionary<string, IList<string>>();
            IList<string> times = new List<string>();

            times.Add("000.00.00");
            times.Add("000.00.00");
            times.Add("000.00.00");

            string spec = "A101";
            specTimes.Add(spec, times);

            int count = specTimes[spec].Count;
        }
    }
}