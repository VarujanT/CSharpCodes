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
            int[][,][,] b = new int[5][,][,];
            for(int i = 0; i < b.Length; i++)
            {
                int x = rd.Next(2, 6);
                b[i] = new int[x, x][,];
                for(int k = 0; k < b[i].GetLength(0);k++)
                {
                    for (int g = 0; g < b[i].GetLength(1); g++)
                        {
                            b[i][k, g] = new int [3, 3];
                            for(int r = 0; r < b[i][k,g].GetLength(0); r++)
                            {
                                for(int s = 0; s <b[i][k,g].GetLength(1); s++)
                                {
                                b[i][k, g][r, s] = rd.Next(-10, 11);
                                Write(b[i][k, g][r, s] + "\t");
                                }
                            WriteLine();
                            }
                        WriteLine();
                        }
                    WriteLine();
                }
                WriteLine();
            }
            WriteLine();
        }  
    }
}