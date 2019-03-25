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
            int result = Area();
            WriteLine(result);
            result = Area(2);
            WriteLine(result);
            result = Area(2, 3);
            WriteLine(result);
            result = Area(2, 3, 7);
            WriteLine(result);
        }
        static int Area(int w = 10, int h = 5, int t = 15)
        {
            return w * h * t;
        }
    }
}