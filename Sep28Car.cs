using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexerner
{
    public class Cow
    {
        public string Name { set; get; }
        public int Milk { set; get; }
        public double Weight { set; get; }
        public Cow(string nm = "Flower", int mk = 15,double wg = 100)
        {
            Name = nm;
            Milk = mk;
            Weight = wg;
        }
        public override string ToString()
        {
            return Name + "\t" + Milk + "\t" + Weight;
        }
    }
}