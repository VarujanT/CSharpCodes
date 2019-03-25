using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Show(10);
        }
        static void Show(int n)
        {
            //WriteLine(n);
            if (n > 1)
            {
                Show(n - 1);
            }
            WriteLine(n);

        }
    }
}