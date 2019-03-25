using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;

namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int[][] a = new int[10][];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = new int[i+1];
            }
            for(int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < a[i].Length; k++)
                {
                    Write(a[i][ k] + "\t");
                }
                WriteLine();
            }
            WriteLine();
        }
    }
}