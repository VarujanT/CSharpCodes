using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Method1
{
    class Program


    {
        static void Main(string[] args)
        {
            int result = Sum(71, 82);
            WriteLine("Result = " + result);
            int reslut1 = Sum((new Random()).Next(-50,50)*Sum(3,5), 27);
            WriteLine(reslut1);
        }

        public static int Sum(int a, int b)
        {
            if (a > b)
            {
                return (int)(Math.Pow(a, 2) - Math.Sqrt(b));
            }
            return a * b;
        }
    }
}