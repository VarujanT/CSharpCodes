using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ParamaterParams
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Array ar = Array.CreateInstance(typeof(int), 5, 7);
            for (int  i = 0; i <ar.GetLength(0); i++)
            {
                for(int k = 0; k<ar.GetLength(1); k++)
                {
                    ar.SetValue(11, i, k);
                    Write(ar.GetValue(i, k)+"\t");
                }
                WriteLine();
            }
            WriteLine();
           
            
        }
        
    }
}