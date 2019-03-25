using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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
           /*int[,] a = new int[row, col];
           for (int i = 0; i < a.GetLength(0); i++)
           {
               for (int k = 0; k < a.GetLength(1); k++)
               {
                   a[i, k] = rd.Next(-99, 100);
                   Write(a[i, k] + "\t");
                   Thread.Sleep(2000);
               }
               WriteLine();
           }
           WriteLine();
           */
           int matcount = 3;
           int[,,] b = new int[matcount, row, col];
           for(int i = 0; i <b.GetLength(0); i++)
           {
               ForegroundColor = (ConsoleColor)rd.Next(5, 16);
               for(int k = 0; k < b.GetLength(1); k++)
               {
                   for (int j = 0; j<b.GetLength(2); j++)
                   {
                       b[i, k, j] = rd.Next(-10, 10);
                       Write(b[i, k, j] + "\t");
                       Thread.Sleep(200);
                   }
                   WriteLine();

               }
               WriteLine("\n");
           }

       }
   }
}
int sum = 0;
WriteLine("Sum = " + sum);
           int sum1 = 0;
           foreach(int item in b)
           {
               sum1 += item;
           }
           WriteLine("Sum1= " + sum1);