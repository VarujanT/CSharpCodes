using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Car
{
    public class Malyar : Employee
    {
        private int kv;

        public int Kv
        {
            get => kv;


            set
            {
                if (value > 0)
                    kv = value;
            }

        }

        public Malyar(string nm = "UnNamed", int ag = 18, decimal sl = 100000, int k = 100):base(nm,ag,sl)
        {

            kv = k;


        }

        ~ Malyar()
        {
            
        
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + kv;
        }

        public new int item = 40;

        public new void TestSameNameItems()
        {
            Console.WriteLine("Item = " + item);
        }



    }
}