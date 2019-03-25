using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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
            PointC pc5 = new PointC();
            PointC pc6 = new PointC(17,19,"MyPaint",ConsoleColor.Green);
            WriteLine(pc5.X + "\t" + pc5.Y + "\t" + pc5.Name + "\t" + pc5.Color);
            WriteLine(pc6.X + "\t" + pc6.Y + "\t" + pc6.Name + "\t" + pc6.Color);
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