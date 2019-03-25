using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace classANDstruct
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
        public PointC(int a):this()
        {
            X = a;
        }
        public PointC(int a,int b):this(a)
        {
            Y = b;
        }
        public PointC(int a, int b,string s):this(a,b)
        {
            Name = s;
        }
        public PointC(int a, int b, string s,ConsoleColor c):this(a,b,s)
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

        /*
public int Y
{
set
{
if (value >= 0 && value < WindowHeight) y = value;
else
throw new Exception("ERROR VALUE"+value);
}
get
{
return y;

}
}
*/
    }
}