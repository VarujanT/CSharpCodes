using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassesAndStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            PointC pc = new PointC();
            //WriteLine(default(DateTime) + "\t" + default(bool) + "\t" + default(int));
            pc.SetX(50);
            WriteLine(pc.GetX());

        
            
           
        }
    }
}