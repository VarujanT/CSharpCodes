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
        /*public EventHandler CarCrush;
          public EventHandler HighSpeed;*/

        /*private EventHandler CarCrush;
        private EventHandler HighSpeed;*/
        EventHandler highspeed;
        public event EventHandler CarCrush;
        public event EventHandler HighSpeed
        {
            add
            {
                highspeed += value;
            }
            remove
            {
                highspeed -= value;
            }
        }

       /* public void RegisterCarCrash(EventHandler e)
        {
            CarCrush += e;
        }
        public void UnRegisterCarCrash(EventHandler e)
        {
            CarCrush -= e;
        }

        public void RegisterHighSpeed(EventHandler e)
        {
            HighSpeed += e;
        }
        public void UnRegisterHighSpeed(EventHandler e)
        {
            HighSpeed -= e;
        }*/

        public string Name { set; get; }
        public int Speed { set; get; }
        public int MaxSpeed { get; }
        public bool Crush { set; get; }
        public Car(string nm = "Lada", int sp = 79, int mx = 180)
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
            if (Speed >= MaxSpeed)
            {
                Crush = true;
                if (CarCrush != null)
                {
                    CarCrush(this, EventArgs.Empty);
                }
            }
            else if (Speed + 25 >= MaxSpeed)
            {
                if (highspeed != null)
                {
                    highspeed(this, EventArgs.Empty);
                }
            }
            else
            {
                Console.WriteLine(this);
            }
        }

    }
}