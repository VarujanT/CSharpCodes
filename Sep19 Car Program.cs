using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("BMW", 121, 280);
            Car c2 = new Car("Lada", 75, 180);
            WriteLine(c1 + "\n" + c2);
        }
    }
}