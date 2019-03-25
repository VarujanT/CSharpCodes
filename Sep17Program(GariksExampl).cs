using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;
namespace Classes_and_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            PointC pc = new PointC(11, 13);
            PointC pc1 = new PointC(11,13);
            if (pc1.Equals(pc))
            {
                WriteLine("Same Points");
            }
            else
            {
                WriteLine("Diferent Points");
            }
            /*WriteLine(pc1);
            for (int i = 0; i < 100; i++)
            {
                PointC pc = new PointC(rd.Next(0, WindowWidth),rd.Next(0,WindowHeight),"A", (ConsoleColor)rd.Next(0, 16));
                pc.Draw();
                Thread.Sleep(300);
                //pc.Draw(false);
            }
            */
            /* pc.Draw();
             pc.Draw(false);
             PointC pc1 = new PointC(rd.Next(0, 20), rd.Next(0, 15));
             pc1.Draw();
             pc1.Draw(false);*/
        }
        static void TestStruct(PointS ps)
        {
            ps.X = 25;
        }
        static void TestClass(PointC pc)
        {
            pc.X = 25;
        }
        static void TestPontS1(PointS1 ps)
        {
            ps.Pc.X = 22;
            ps.X = 21;
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