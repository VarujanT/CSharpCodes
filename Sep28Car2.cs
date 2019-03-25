using System;
using static System.Console;

namespace Car
{
    public class Car
    {
        public String Mark { set; get; }
        public bool IsCrash { set; get; }
        private static int count;
        private readonly int maxSpeed;
        private int Speed;
        public int MaxSpeed
        {
            get { return maxSpeed; }
        }
        public static int Count { get => Count; }

        public Car(string nm = "UnNamed", int sp = 93, int mx = 220)
        {
            Mark = nm;
            Speed = sp;
            maxSpeed = mx;
            count++;
        }

        public override string ToString()
        {
            return Mark + "\t" + Speed + "\t" + MaxSpeed;
        }

        public void Accelerate(int d)
        {
            if (IsCrash) return;
            Speed += d;
            if (MaxSpeed <= Speed)
            {
                IsCrash = true;
            }
            else if (Speed + 10 > maxSpeed)
            {
            }
            else WriteLine(this);
        }
        public static bool operator <(Car c1,Car c2)
        {
            if (c1.MaxSpeed < c2.MaxSpeed)
                return true;
            return false;
        }
        public static bool operator >(Car c1, Car c2)
        {
            return !(c1 < c2 );
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(obj is Car)
            {
                Car c = obj as Car;
                if (c.GetHashCode() == this.GetHashCode()) return true;
            }
            return false;
        }
        public static bool operator ==(Car c1, Car c2)
        {
            return c1.Equals(c2);
        }
        public static bool operator !=(Car c1, Car c2)
        {
            return !c1.Equals(c2);
        }
    }
}
/*
  public int MaxSpeed1
        {
            get;
        }
*/