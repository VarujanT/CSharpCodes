using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptioneriMshakum
{
    public class Car
    {
        public string Name { set; get; }
        public int Speed { set; get; }
        public int MaxSpeed { get; }
        public Car(string nm = "Lada", int sp =50, int mx = 180)
        {
            Name = nm;
            Speed = sp;
            MaxSpeed = mx;
        }
        public override string ToString()
        {
            return Name + "\t" + Speed + "\t" + MaxSpeed;
        }

        public void Accelerate (int d)
        {
            Speed += d;
            try
            {
                if (Speed > MaxSpeed)
                    throw new Exception
                        ("Car is Crushed");
                else
                {
                    Console.WriteLine(this);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch(Exception e)
            {
                this.Speed = 0;
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}