using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Method2
{
    class Program


    {
        static void Main(string[] args)
        {
            DrawLine(5);
            DrawLine(-3);
        }

        public static void DrawLine(int a)
        {
            if( a < 1 || a > WindowWidth)
            {
                WriteLine("Error Size");
                return;
            }
            for (int i = 0; i < a; i++)
            {
                Write("*");
            }
            WriteLine();
        }
    }
}