using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ParamaterParams
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] d = { 0.5, -0.007, 7.17 };
            Show(d);
            Show1(d);
            Show1(3.14, 7.99);
        }
        static void Show(double[] d)
        {
            foreach (double d1 in d)
            {
                Write(d1 + "\t");
            }
            WriteLine();
        }
        static void Show1(params double[] d)
        {
            foreach (double d1 in d)
            {
                Write(d1 + "\t");
            }
            WriteLine();
        }
    }
}