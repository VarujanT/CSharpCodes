using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FactorialRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int result = Fact(n);
            WriteLine(result);

        }
        static int Fact(int a)
        {
            if (a < 2)
            {
                return 1;
            }
                return Fact(a - 1) * a;
            
           
        }
    }
}