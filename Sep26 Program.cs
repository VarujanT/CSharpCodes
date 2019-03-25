using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAndEmployee;
using static System.Console;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer.CalcAge();
           
            
            
            
            
            
            //NewMethod(); // Progam.cs Main for "Car and Employee" classes


        }

        private static void NewMethod()
        {
            Car c1 = new Car("BMW", 121, 280);
            Car c2 = new Car("Lada", 75, 180);

            /*WriteLine(c1 + "\n" + c2);
                c1.Accelerate(17);
            WriteLine(c1 + "\n" + c2);*/

            for (int i = 0; i < 50; i++)
            {
                c1.Accelerate(19);
            }

            //WriteLine(Employee.Tax);

            /*Car c = new Car();
            WriteLine(c.GetCount());*/

            //WriteLine(Car.count); for "public static int count;"
            //Car.count = 50; for "public static int count;"
            //WriteLine(Car.count); for "public static int count;"
        }
    }
}