using System;
using static System.Console;
using static System.Math;

namespace Classes_and_Structures
{
    public struct PointS
    {
        public PointS(int a)
        {
            x = a;
            y = default(int);
        }
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
    }
    public struct PointS1
    {
        public PointS1(int a)
        {
            x = a;
            y = default(int);
            pc = new PointC(8, 9);
        }
        private PointC pc;
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public PointC Pc { get => pc; set => pc = value; }
    }
}