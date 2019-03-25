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
            Tower tw = new Tower();
            Random rd = new Random();
            for (int i = 0; i < 15; i++)
            {
                try
                {
                    tw.Add(rd.Next(1, 20));
                }

                catch (Exception e)
                {
                    WriteLine("Error Value: " + e.Message);
                }
            }

            for(int i = 0; i<tw.Count;i++)
            {
                WriteLine(tw[i]);
            }
        }
    }
}