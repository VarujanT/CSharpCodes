using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Arraysoop
{
   class Program
   {
       static void Main(string[] args)
       {
           Random rd = new Random();
           WriteLine("Enter Matrix Sizes");
           int col = int.Parse(ReadLine());
           int row = int.Parse(ReadLine());
           int[,] a = new int[row, col];
           for (int i = 0; i < a.GetLength(0); i++)
           {
               for (int k = 0; k < a.GetLength(1); k++)
               {
                   a[i, k] = rd.Next(-99, 100);
                   Write(a[i, k] + "\t");
               }
               WriteLine();
           }
           WriteLine();
       }
   }
}