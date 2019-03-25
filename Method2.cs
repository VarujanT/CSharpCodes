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
            DrawLine(2);
        }

        public static void DrawLine(int a)
        {
            for(int i = 0; i < a; i++)
            {
                Write("*");
            }
            WriteLine();
        }
    }
}