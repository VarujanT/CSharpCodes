using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfaceRealize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -3, 73, -50, 40, 200 };
            Array.Sort(a);
            foreach(int x in a)
            {
                WriteLine(x + "\t");
            }

            WriteLine();

            Cow[] cw = { new Cow("Anush", 90), new Cow("Manush", 153), new Cow("Tsaxik", 123), new Cow("Tsoxik", 45) };
            Array.Sort(cw);
            foreach (Cow c in cw)
            {
                WriteLine(c);
            }

            WriteLine();

            Array.Sort(cw, new CompareNames());
            foreach (Cow c in cw)
            {
                WriteLine(c);
            }

            WriteLine();

            Array.Sort(cw, Cow.byNames);
            WriteLine();
            foreach (Cow c in cw)
            {
                WriteLine(c);
            }

        }
    }
}