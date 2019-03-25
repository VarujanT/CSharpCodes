using System;
using static System.Console;
using static System.Math;

namespace Classes_and_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod1();
            //NewMethod();
            PointC pc = new PointC(41);
            Write(pc.Y + "\t" + pc.GetX());
            PointS ps = new PointS();
            ps.X = 20;
        }

        private static void NewMethod()
        {
            PointC pc = new PointC();
            WriteLine(pc.Y);
            pc.Y = 12;
            PointS ps = new PointS();
            WriteLine(ps.X);
            ps.X = 20;
        }

        static void NewMethod1()
        {
            PointC pc = new PointC();
            //WriteLine(default(DateTime) + "\t" + default(bool) + "\t" + default(int));
            WriteLine(pc.Y);
            pc.Y++;
            WriteLine(pc.Y);
        }
    }
}