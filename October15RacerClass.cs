using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;

namespace Animal_Run
{
    public class Racer
    {
        public Racer() { }
        public Racer(Animal a1, Animal a2, int distance, char flag, int sleepTime)
        {
            A1 = a1;
            A2 = a2;
            Distance = distance;
            Flag = flag;
            SleepTime = sleepTime;
        }

        public Animal A1 { set; get; }
        public Animal A2 { set; get; }
        public int Distance { set; get; }
        public char Flag { set; get; }
        public int SleepTime { set; get; }

        public void Show(bool show = true)
        {
            A1.Draw(show);
            A2.Draw(show);
            SetCursorPosition(Distance, 5);
            Write(Flag);
        }
        public Animal Run()
        {
            Clear();
            A1.X = A2.X = 0;
            while (true)
            {
                Show();
                Thread.Sleep(SleepTime);
                Show(false);
                A1.Move();
                A2.Move();
                if (A1.X >= Distance) return A1;
                if (A2.X >= Distance) return A2;
            }
        }
    }
}



Collapse 
8:04 AM
