using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace genericfunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Aram";
            string s2 = "Amen inch karam";
            Swap(ref s1, ref s2);
            WriteLine(s1 + "\n" + s2);

        }
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}