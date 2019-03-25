using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HanoyTower
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower A = new Tower();
            Tower B = new Tower();
            Tower C = new Tower();

            int n = 10;
            for(int i = n; i > 0; i-- )
            {
                A.Add(i);
            }

            A.Show();
            B.Show();
            C.Show();
            HanoysTower(n, A, C, B);
            A.Show();
            B.Show();
            C.Show();

            //for(int i = 0; i < n; i++)
            //{
            //    WriteLine(A.Last);
            //    A.Remove();
            //}
        }

        public static void HanoysTower(int n, Tower source, Tower target, Tower spare)
        {
            if (n == 1)
            {
                target.Add(source.Last);
                source.Remove();
            }
            else
            {
                HanoysTower(n - 1, source, spare, target);
                HanoysTower(1, source, target, spare);
                HanoysTower(n - 1, spare, target, source);
            }
        }
    }
}