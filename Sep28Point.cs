using System;
using static System.Console;
namespace Car
{
    public class Point
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Point(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }
        public void Draw(bool draw = true)
        {
            ForegroundColor = draw == true ? ConsoleColor.Red : BackgroundColor;
            SetCursorPosition(X, Y);
            WriteLine("*");
            ResetColor();
        }
        public override string ToString()
        {
            return X + "\t" + Y;
        }
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }
        public static Point operator +(Point p, int a)
        {
            return new Point(p.X + a, p.Y + a);
        }
        public static Point operator +(int a, Point p)
        {
            return p + a;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
                return true;
            return false;
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point pt = obj as Point;
                return pt == this;
            }
            return false;
        }
    }
}