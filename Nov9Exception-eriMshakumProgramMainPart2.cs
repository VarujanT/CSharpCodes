using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptioneriMshakum
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car c = new Car("Ford", 155, 200);
                Test(c);
            }
            catch
            {
                Console.WriteLine("Car is Crushed");
            }
            Console.WriteLine("Continue After Exception");
        }

        static void Test(Car c)
        {
            for(int i = 0; i<50;i++)
            {
                c.Accelerate(13);
            }
        }
    }
}