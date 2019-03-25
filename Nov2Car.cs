using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Experements
{
	 public class Car
	{
		private static int count;
		public static int Count { get => count;}
		public String Mark { set; get; }

		private int speed;

		public bool IsCrushed { set; get; }
		public int Speed
		{
			set
			{
				if (value >= 0) speed = value;
				else throw new ArgumentException("Error value " + value);
			}
			get { return speed; }
		}

		private readonly int maxSpeed;
		public int MaxSpeed { get { return maxSpeed; } }
		


		public Car(string nm = "Unnamed", int sp = 93, int mx = 220)
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
			if (IsCrushed)
				return;
			this.Speed += d;
			if (MaxSpeed <= Speed)
				IsCrushed = true;
			else if (Speed + 1 > MaxSpeed) { }
			else
				WriteLine(this);
		}
		public static bool operator >(Car c1, Car c2)
		{
			if (c1.MaxSpeed > c2.MaxSpeed)
				return true;
			return false;
		}
		public static bool operator <(Car c1, Car c2)
		{
			return !(c1>c2 &&c1 ==c2);
		}
		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}
		public override bool Equals(object obj)
		{
			if (obj is Car)
			{
				Car c1 =obj as Car;
				if (c1.GetHashCode() == this.GetHashCode())
					return true;
			}
			return false;
		}
		public static bool operator ==(Car c1,Car c2)
		{
			return c1.Equals(c2);
		}
		public static bool operator !=(Car c1,Car c2)
		{
			return !(c1 == c2);
		}
	}
}