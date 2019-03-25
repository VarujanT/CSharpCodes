using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car("BMW", 133, 250);
            Console.WriteLine(c1 + "\n" + c2);

            //c1.RegisterCarCrash(OnCarCrush);
            //c2.CarCrush += OnCarCrush;
            //c1.HighSpeed += OnHighSpeed;
            //c2.RegisterHighSpeed(OnHighSpeed);
            c1.HighSpeed += OnHighSpeed;
            c2.CarCrush += OnCarCrush;

            for (int i = 0; i < 50; i++)
            {
                //if (i < 4) c1.CarCrush -= OnCarCrush;
                c1.Accelerate(17);
                c2.Accelerate(15);

                Thread.Sleep(150);
            }
        }

        public static void OnCarCrush(object o, EventArgs e)
        {
            if (o is Car)
            {
                Car c = o as Car;
                c.Crush = false;
                c.Speed = 0;
            }
            else
            {
                throw new ArgumentException("Argument Eror");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car is Crash");
            Console.ResetColor();
        }

        public static void OnHighSpeed(object o, EventArgs e)
        {
            if (o is Car)
            {
                Car c = o as Car;
                c.Speed = 80;
            }
            else
            {
                throw new ArgumentException("Argument Eror");
            }
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Drive slover");
            Console.ResetColor();
        }
    }
}