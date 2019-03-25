using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    public delegate void CarEventHandler(string msg);

    public class Car
    {
        public CarEventHandler CarCrush;
        public CarEventHandler HighSpeed;
        public string Name { set; get; }
        public int Speed { set; get; }
        public int MaxSpeed { get; }
        public bool Crush { set; get; }
        public Car (string nm = "Lada", int sp = 79, int mx = 180)
        {

            Name = nm;
            Speed = sp;
            MaxSpeed = mx;
        }
        public override string ToString()
        {
            return Name + "\t" + Speed + "\t" + MaxSpeed;
        }

        public void Accelerate(int d)
        {
            if (Crush == true) return;
            Speed += d;
            if(Speed >=MaxSpeed)
            {
                Crush = true;
                if (CarCrush != null)
                {
                    CarCrush("Car is crushed!!!!");
                }
            }
            else if(Speed + 25>=MaxSpeed)
            {
                if(HighSpeed != null)
                {
                    HighSpeed("Very Fast");
                }
            }
            else
            {
                Console.WriteLine(this);
            }
        }

    }
}