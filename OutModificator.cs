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
            int sum, sub, multy;
            int a = 100, b = 200;
            multy = TvabOp(a, b, out sum, out sub);
            WriteLine("sum = " + sum + "\t" + "sub = " + sub + "\tmulty = " + multy);
            
        }

        public static int TvabOp(int a, int b, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
            return a * b;
        }
    }
}