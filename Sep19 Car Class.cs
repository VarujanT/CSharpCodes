using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Car
{
    public class Car
    {
        public String Mark { set; get; }
        private int Speed;
        private readonly int maxSpeed;
        public int MaxSpeed
        {
            get { return maxSpeed;}
        }
        public Car (string nm = "UnNamed", int sp = 93, int mx = 220)
        {
            Mark = nm;
            Speed = sp;
            maxSpeed = mx;
        }
        public override string ToString()
        {
            return Mark + "\t" + Speed + "\t" + MaxSpeed;
        }

    }
}
/*
  public int MaxSpeed1
        {
            get;
        }
*/