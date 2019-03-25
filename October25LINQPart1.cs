using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -70, -8, -120, 200, 300, -9, 34, -2, 42, 0, 21 };
            //IEnumerable<int> result = from x in a where x < 0 orderby x descending select x;
            var result = from x in a where x < 0 orderby x descending select new {Name = "Arus", Toshak = Math.Pow(x,2)};
            //var result = from int x in a where x < 0 select x;
            foreach (var y in result) //with var result --> foreach (var y in result)
            {
                WriteLine(y + "\t");
            }
        }
    }
}