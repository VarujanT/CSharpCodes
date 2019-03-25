using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace ThreadingSecondPart
{
    public class AddParams
    {
        public int A { set; get; }
        public int B { set; get; }

        public AddParams(int a = 10, int b = 20)
        {
            A = a;
            B = b;
        }

    }
}