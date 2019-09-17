using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            AA s = new AA();
            List<AA> l = new List<AA>() { s };
            var look = l.ToLookup(a => a.key);
           
            Console.Out.WriteLine(look[0].Count());
            Console.Out.WriteLine(DateTime.Today.ToString(CultureInfo.InvariantCulture));
            Console.Read();
        }
    }
    class AA
    {
        public int key = 88;
    }
}
