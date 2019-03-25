public class Cow : IComparable<Cow>
    {
        public string Name { set; get; }
        public int Weight { set; get; }
        public Cow(string nm = "UnNamed", int wt = 110)
        {
            Name = nm;
            Weight = wt;
        }
        public override string ToString()
        {
            return Name + "\t" + Weight;
        }

        public int CompareTo(Cow other)
        {
            //if (Weight == other.Weight) return 0;
            //if (Weight > other.Weight) return 1;
            //return -1;
            return Weight.CompareTo(other.Weight);
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