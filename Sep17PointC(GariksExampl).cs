using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace Classes_and_Structures
{
    public class PointC
    {
        public PointC()
        {
            X = 3;
            Y = 5;
            Color = ConsoleColor.Red;
            Name = "Dot";
        }
        public PointC(int a) : this()
        {
            X = a;
        }
        public PointC(int a, int b) : this(a)
        {
            Y = b;
        }
        public PointC(int a, int b, string s) : this(a, b)
        {
            Name = s;
        }
        public PointC(int a, int b, string s, ConsoleColor c) : this(a, b, s)
        {
            color = c;
        }
        private int x;
        private int y;
        private string name;
        private ConsoleColor color;
        public int X { get => x; set => x = value; }
        public ConsoleColor Color { get => color; set => color = value; }
        public string Name { get => name; set => name = value; }
        public int Y { get => y; set => y = value; }

        public void Draw(bool draw = true)
        {

            ForegroundColor = draw ? color : BackgroundColor;
            SetCursorPosition(X, Y);
            WriteLine("*");
            ResetColor();


        }
        public override string ToString()
        {
            return  "\tpt(" + X + "," + Y + ")";
        }
        public override bool Equals(object obj)
        {
            if (obj is PointC)
            {
                PointC pc = obj as PointC;
               /* if (X == pc.x && Y == pc.y)
                    return true;*/
                if (pc.ToString()== ToString())
                
                    return true;
            }
            return false;
                                        
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }

}