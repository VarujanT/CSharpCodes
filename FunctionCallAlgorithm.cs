using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FunctionCallAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 200;
            Swap(x, y);
            WriteLine(x + "\t" + y);
            Swap(ref x, ref y);
            WriteLine(x + "\t" + y);
        }
        public static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}