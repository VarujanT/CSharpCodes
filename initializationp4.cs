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
           int[,] a = new int[5, 5]
           {
               {-5,7,8,5,8},
               {21,22,1,2,47},
               {0,77,21,25,98},
               {8,9,11,36,5,},
               {6,7,8,23,9,},
           };
           int sum = 0;
               for (int i = 0; i < a.GetLength(0); i++)
               {
               sum += a[i, i];
               }
               WriteLine("Sum= "+sum);







       }

   }
}