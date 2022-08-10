using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inec = { "Tayo", "Niyii", "Toke", "Tayo" };
            var newInec = new HashSet<string>();
            var similar = inec.Where(i => !newInec.Add(i)).Distinct();
            Console.WriteLine(String.Join(",", similar));
            Console.ReadLine();
        }
    }
}
