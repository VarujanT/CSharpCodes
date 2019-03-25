using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRealize
{
    public class Cow : IComparable<Cow>
    {
        public string Name { set; get; }
        public int Qash { set; get; }
        public Cow(string nm = "UnNamed", int qash = 110)

        {
            Name = nm;
            Qash = qash;
        }

        public override string ToString()
        {
            return Name + "\t" + Qash;
        }

        public int CompareTo(Cow other)
        {
            //if (this.Qash == other.Qash) return 0;
            //if (this.Qash > other.Qash) return 1;
            //return -1;
            return Qash.CompareTo(other.Qash);
        }

        public static CompareNames byNames
        {
            get { return new CompareNames(); }
        }
}

    public class CompareNames : IComparer<Cow>
    {
        public int Compare(Cow x, Cow y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

}