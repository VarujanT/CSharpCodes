using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Animal_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Racer rc = new Racer()
            {
                A1 = new Dog("Max", 0, ConsoleColor.Green, '@'),
                A2 = new Horse("Jalal", 0, ConsoleColor.Yellow, '$'),
                Distance = 60,
                Flag = '#',
                SleepTime = 54
            };
            rc.Run();
        }
    }
}