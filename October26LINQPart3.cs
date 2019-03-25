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
        }
    }
}