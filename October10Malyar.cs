public class Maliar : Employee
    {
        private int sq;
        public int Sq
        {
            get => sq;

            set
            {
                if (value > 0)
                    sq = value;
            }
        }

        public Maliar(string nm = "UnNamed", int ag = 18, decimal sl = 100000,int k = 100) : base(nm,ag,sl)
        {
            Sq = k;
        }
        ~Maliar()
        {
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + sq;
        }
        public override decimal RealSalary()
        {
            return Salary - Tax + sq*1000;
        }
    }