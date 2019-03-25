using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace classANDstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            PointS ps = new PointS(11);
            PointC pc = new PointC(11);
            PointS1 ps1 = new PointS1(17);
            TestStruct(ps1);
            TestClass(pc);
            WriteLine("PS1.X = " + ps1.Pc.X);
            WriteLine("PS.X = " + ps.X);

            WriteLine("PC.X = " + pc.X);
        }
       static void TestStruct(PointS1 ps)
        {
            ps.Pc.X = 22;
            ps.X = 21;
        }
        static void TestClass(PointC pc)
        {
            pc.X = 25;
        }

    }
    
}