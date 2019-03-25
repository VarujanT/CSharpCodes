using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using static System.Math;


namespace initialization
{
   class Program
   {
       static void Main(string[] args)
       {
           int[,] a = new int[5, 3]
           {
               {-5,7,8},
               {21,22,1},
               {0,77,21},
               {8,9,11},
               {6,7,8},
           };
               for (int i = 0; i < a.GetLength(0); i++)
               {
                   for(int k= 0; k < a.GetLength(1); k++)
                   {
                   Write(a[i, k] + "\t");
                   }
               WriteLine();
               }






       }

   }
}