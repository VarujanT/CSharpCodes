using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClassesAndStructures
{
    public class PointC
    {
        private int x;
        private int y;
        public void SetX(int newValue)
        {
            if (newValue >= 0 && newValue < WindowWidth)
                x = newValue;
            else
                WriteLine("Error Value " + newValue);
        }
        public int GetX()
        {
            return x;
        }
    }
}