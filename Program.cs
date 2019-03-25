using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Malyar ml = new Malyar("Sargis");
            WriteLine(ml);
            Malyar ml1 = new Malyar();
            WriteLine(ml1);
            Malyar ml2 = new Malyar("Vahan");
            WriteLine(ml2);
            Malyar ml3 = new Malyar("Sahak", 44);
            WriteLine(ml3);
            Malyar ml4 = new Malyar("Nargiz", 33, 150000);
            WriteLine(ml4);
            Malyar ml5 = new Malyar("Poxos", 52, 200000, 100);
            WriteLine(ml5);
            ml1.TestSameNameItems();


        }
    }
}