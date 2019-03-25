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
        private static int count;
        //public static int count;

        public String Mark { set; get; }
        private int Speed;
        private readonly int maxSpeed;

        public static int Count { get => count; }

        public int MaxSpeed
        {
            get { return maxSpeed; }
        }


        public Car(string nm = "UnNamed", int sp = 93, int mx = 220)
        {
            Mark = nm;
            Speed = sp;
            maxSpeed = mx;
        }


        public override string ToString()
        {
            return Mark + "\t" + Speed + "\t" + MaxSpeed;
        }


        public void Accelerate(int d)
        {
            if (IsCrash) return;
            this.Speed += d;
            if (MaxSpeed <= Speed)
            {
                IsCrash = true;
            }
            else if (Speed + 1 > maxSpeed)
            {

            }
            else WriteLine(this);

        }

        public bool IsCrash { set; get; }

        

        /*public int GetCount()
        {
            return count;
        }*/
    }
}
/*
  public int MaxSpeed1
        {
            get;
        }
*/