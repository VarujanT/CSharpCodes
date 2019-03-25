using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;

namespace PaintKonsole
{
   class Program
   {
       static void Main(string[] args)
       {
           Random rd = new Random();
           ConsoleColor[,] colors;
           colors = new ConsoleColor[WindowHeight, WindowWidth];
           for(int i = 0; i < colors.GetLength(0); ++i)
           {
               for (int j = 0; j < colors.GetLength(1); ++j)
               {
                   colors[i,j] = (ConsoleColor)rd.Next(1,16);
                   BackgroundColor = colors[i, j];
                   Write(" ");
               }
               WriteLine();
           }
       }
   }
}