using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Sum2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Sum(10));
        }
        static int Sum(int n)
        {
            if(n==1)
            {
                return n;
            }
            return Sum(n - 1) + n;
        }
        
    }
}