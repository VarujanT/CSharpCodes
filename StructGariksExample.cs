using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
namespace classANDstruct
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

        public int Y { get => y; set => y = value; }
    }
    public struct PointS1
    {
        public PointS1(int a)
        {
            x = a;
            y = default(int);
            pc = new PointC(18, 19);
        }
        private int x;
        private int y;
        private PointC pc;
        public int X { get { return x; } set { x = value; } }

        public int Y { get => y; set => y = value; }
        public PointC Pc { get => pc; set => pc = value; }
    }
}