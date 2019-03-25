using System;
using static System.Console;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timer.CalcAge();
            Random rd = new Random();
            Point p1 = new Point(rd.Next(WindowWidth), rd.Next(WindowHeight));
            Point p2 = new Point(rd.Next(WindowWidth), rd.Next(WindowHeight));
            WriteLine("p1 = "+p1);
            WriteLine("p2 = " + p2);
            WriteLine(p2 + p1);
            WriteLine("p1 = " + p1);
            WriteLine("p2 = " + p2);
            p1 += p2;
            WriteLine("p1 = " + p1);
            WriteLine(p1 + "\t" + (p1+5));
            Point p5 = new Point(5,7);
            Point p6 = new Point(5,7);
            if(p5 == p6)
            {
                WriteLine("Equals");
            }
            else
            {
                WriteLine("No Equals");
            }
        }
        private static void NewMethod()
        {
            Car c1 = new Car("BMW", 121, 280);
            Car c2 = new Car("Lada", 75, 180);

            WriteLine(Employee.Tax);

            for (int i = 0; i < 50; i++)
            {
                c1.Accelerate(19);
            }
        }
    }
}
/*
    WriteLine(c1 + "\n" + c2);
    c1.Accelerate(17);
    WriteLine(c1 + "\n" + c2);
*/