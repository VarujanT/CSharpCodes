public class MalStudent : Maliar
    {
        private double salaryCf = 0.5;
        public double SalaryCf
        {
            set
            {
                if (value < 1 && value > 0)
                    salaryCf = value;
                else
                    throw new Exception("Error Cf : " + value);
            }
            get => salaryCf;
        }
        public MalStudent(string nm = "UnNamed", int ag = 18, decimal sl = 100000, int k = 100, double scf = 0.5) : base(nm, ag, sl, k)
        {
            SalaryCf = scf;
        }
        public override decimal RealSalary()
        {
            return base.RealSalary() * (decimal)SalaryCf;
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + SalaryCf;
        }
    }