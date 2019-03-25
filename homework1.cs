using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            WriteLine("Press Enter To Start");
            while (ReadKey().Key == ConsoleKey.Enter)
            {
                int[,] a = new int[5, 5];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        
                        a[i, k] = rd.Next(-99, 100);
                        Write(a[i, k] +"\t");
                    }
                    WriteLine();
                }
                WriteLine();
                for (int i= 0; i<a.GetLength(0); i++)
                {
                    for(int k=0; k<a.GetLength(1)-i; k++)
                    {
                        Write(a[i, k] + "\t");
                    }
                    WriteLine();
                }
                WriteLine();

                
                
            }
        }
    }
}
/int[,] a = new int[6, 5];
              // int[,] b = a;
               //a = new int[6, 5];