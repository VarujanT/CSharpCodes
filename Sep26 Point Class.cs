using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarAndEmployee
{
    public class Point
    {
        public int X { set; get; }
        public int Y { set; get; }


        public Point(int a = 0, int b = 0)
        {
            X = a;
            Y = b;
        }


        public void Draw (bool draw = true)
        {
            ForegroundColor = draw == true ? ConsoleColor.Red : BackgroundColor;
            SetCursorPosition(X, Y);
            WriteLine("*");
            ResetColor();
        }
        public override string ToString()
        {
            return X + "," + Y;
        }


    }
}