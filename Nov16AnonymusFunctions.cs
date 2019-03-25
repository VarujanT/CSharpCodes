using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AnonymusFunctions
{
    public delegate void D1();
    public delegate void D2(int a);
    public delegate int D3(int a, int b);
    class Program
    {
        static D1 d1; static D2 d2; static D3 d3;
        static void Main(string[] args)
        {
            int a = 200;
            CreateUnnamed(ref a, 500);
            d1();
            CreateUnnamed(ref a, 1000);
            Test();
            WriteLine("\n");
            CreateLyambda();
            Test();
        }
        public static void Test()
        {
            d1();
            d2(175);
            WriteLine(d3(17, 13));
        }
        public static void CreateUnnamed(ref int x, int y)
        {
            int c = 150;
            d1 = delegate
            {
                WriteLine("Calling Annonymus Without Param");
                //int x = 10;
                //int y = 20;
                //int c = 30;
                //Console.WriteLine("Ref Param = " + x);
                WriteLine("Param = " + y);
                WriteLine("Local Var = " + c);
            };
            d2 = delegate
            {
                WriteLine("Calling Annonymus By Param ");
            };
            d3 = delegate
            {
                return 10;
            };
        }
        public static void CreateLyambda()
        {
            d1 = () => WriteLine("Calling Lyambda");
            d2 = a => WriteLine("Param = " + a);
            d3 = (a, b) => a > b ? a * b : b - a;
        }
    }
}