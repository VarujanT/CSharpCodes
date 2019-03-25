using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c1 = { 'A', 'B', 'C' };
            char[] c2 = { 'X', 'Y', 'Z' };
            IEnumerable<string> result = from x in c1
                         from y in c2
                         select x + "" + y;
            foreach (string t in result)
            {
                WriteLine(t);
            }

            string[] sites = { "A.com", "B.am", "C.ru", "D.com", "E.net", "F.com", "G.ru", "H.com", "I.am", "J.ru", };
            var res = from x in sites
                         let index = x.LastIndexOf('.')
                         group x by x.Substring(index);
            foreach (var t1 in res)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(t1.Key);
                ResetColor();
                foreach(var t2 in t1)
                {
                    WriteLine(t2);
                }
            }
        }
    }
}