using System;
using static System.Console;
using static System.Math;

namespace Classes_and_Structures
{
    public class PointC
    {
        public PointC()
        {

        }
        public PointC(int a)
        {
            Y = a;
        }
        public int Y
        {
            set
            {
                if (value >= 0 && value < WindowWidth) y = value;
                else throw new Exception("Error" + value);
            }
            get
            {
                return y;
            }
        }
        private int x = 30;
        private int y = 15;
        public void SetX(int newValue)
        {
            if (newValue >= 0 && newValue <= WindowWidth) x = newValue;
            else WriteLine("Error Value : " + newValue);
        }
        public int GetX()
        {
            return x;
        }
    }
}