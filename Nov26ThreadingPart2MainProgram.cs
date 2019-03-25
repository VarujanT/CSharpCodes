using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace ThreadingSecondPart
{
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart pts = Add;
            Thread thread = new Thread(pts);
            thread.IsBackground = true;
            thread.Start(new AddParams(23, 35));
            thread.IsBackground = true;
        }

        public static void Add(Object o)
        {
            if (o is AddParams)
            {
                AddParams ap = o as AddParams;
                WriteLine("a =  " + ap.A + "\tb = " + ap.B + "\t a + b = " + (ap.A + ap.B));
            }
        }
    }
}