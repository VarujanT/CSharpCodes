using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MethodExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = GetValues(20, 10);
            WriteLine(a[0]);
            WriteLine(a[1]);
            WriteLine(a[2]);
        }
        
        static int [] GetValues(int a, int b)
        {
            return new int[] { a + b, a - b, a * b };
        }
    }
}