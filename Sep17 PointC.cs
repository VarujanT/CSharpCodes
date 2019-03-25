using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Classes_and_Structures
{
    public class PointC

    {
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public override bool Equals(Object o)
        {
            if ( o is PointC)
            {
                PointC pc = o as PointC;
                if(pc.ToString()==ToString())
                //if (X == pc.X && Y == pc.Y)
                
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "\tP(" + X + "," + Y + ")";
        }
        public PointC()
        {
            X = 3;
            Y = 5;
            Color = ConsoleColor.Red;
            Name = "Dot";
        }
        public PointC(int a):this()
        {
            X = a;
            //Y = 10;
            //Color = ConsoleColor.Red;
            //Name = "Dot";
        }
       
        public PointC (int a, int b):this (a)
        {
            //X = a;
            Y = b;
            //Color = ConsoleColor.Red;
            //Name = "Dot";
        }
        public PointC(int a, int b, string nm):this (a,b)
        {
            //X = a;
            //Y = b;
            //Color = ConsoleColor.Red;
            Name = nm;
        }
        public PointC(int a, int b, string nm, ConsoleColor clr):this(a, b, nm)
        {
            //X = a;
            //Y = b;
            Color = clr;
            //Name = nm;
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

        public string Name { get => name; set => name = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public int X { get => x; set => x = value; }

        private string name;
        private ConsoleColor color;
        private int x = 30;
        private int y = 15;
        public void SetX(int newValue)
        {
            if (newValue >= 0 && newValue <= WindowWidth) X = newValue;
            else WriteLine("Error Value : " + newValue);
        }
        public int GetX()
        {
            return X;
        }
        public void Draw(bool draw = true)
        {
            ForegroundColor = draw ? Color : BackgroundColor;
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = Color;
            WriteLine("*");
            ResetColor();

        }
         
    }
}