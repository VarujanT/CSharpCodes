using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Classes_and_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            PointC pc1 = new PointC(7,9);
            PointC pc2 = new PointC(7,9);
            
            if (pc1 == pc2)
            {
                WriteLine("Same Points");
            }
            else
                WriteLine("Diferent Points");
            if (pc1.Equals (pc2))
            {
                WriteLine("Same Points");
            }
            else
                WriteLine("Diferent Points");

            WriteLine(pc1);
            for (int i = 0; i < 100; i++);
            {
                PointC pc = new PointC(rd.Next(0, Console.WindowWidth - 1), rd.Next(0, Console.WindowHeight - 1),"A",(ConsoleColor)rd.Next(1, 16));
                
                pc.Draw();
                Thread.Sleep(100);
                pc.Draw(false);
            }
            
            /*PointS ps = new PointS(11);
            PointC pc = new PointC(11, 13);
            TestStruct(ps);
            TestClass(pc);
            WriteLine("Struct X = " + ps.X);
            WriteLine("Class X = " + pc.X);
            PointS1 ps1 = new PointS1(17);
            TestPontS1(ps1);
            WriteLine("Struct X = " + ps1.X + "\n" + "Struct Class X = " + ps1.Pc.X);*/
            //NewMethod1();
            //NewMethod();
            /*PointC pc = new PointC(41);
            Write(pc.Y + "\t" + pc.GetX());
            PointS ps = new PointS();
            ps.X = 20;
            PointC pc5 = new PointC();
            PointC pc6 = new PointC(17,19,"MyPaint",ConsoleColor.Green);
            WriteLine(pc5.X + "\t" + pc5.Y + "\t" + pc5.Name + "\t" + pc5.Color);
            WriteLine(pc6.X + "\t" + pc6.Y + "\t" + pc6.Name + "\t" + pc6.Color);*/
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