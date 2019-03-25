using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Indexaoterner
{
    public class Cow
    {
        public string Name { set; get; }
        public int Milk { set; get; }
        public double Qash { set; get; }

        public Cow (String nm = "Flower", int mk = 15, double qash = 100)
        {
            Name = nm;
            Milk = mk;
            Qash = qash;
        }

        public override string ToString()
        {
            return Name + "\t" + Milk + "\t" + Qash;
        }

        public static explicit operator int(Cow cw)
        {
            return cw.Milk;
        }

        public static explicit operator Cow(string name)
        {
            return new Cow(name);
        }
    }
}