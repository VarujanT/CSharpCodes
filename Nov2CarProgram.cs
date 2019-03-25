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

            c1.CarCrush += OnCarCrush;
            c2.CarCrush += OnCarCrush;
            c1.HighSpeed += OnHighSpeed;
            c2.HighSpeed += OnHighSpeed;

            for (int i = 0; i<50; i++)
            {
                if (i < 4) c1.CarCrush -= OnCarCrush;
                c1.Accelerate(17);
                c2.Accelerate(15);
                Thread.Sleep(150);
            }
        }

        public static void OnCarCrush(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s + "\nVAX ES INCH ES AREL, \nVORTEX BRNEM ************** \nARAAAA!!!!!");
            Console.ResetColor();
        }

        public static void OnHighSpeed(string s)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(s + " : Zgush, etex pavarotner kan, ay txa!");
            Console.ResetColor();
        }
    }
}