using System;
using static System.Console;

namespace Car
{
    public static class Timer
    {
        private static DateTime BirthDay { set; get; }
        static Timer()
        {
            WriteLine("Enter Birth Day By Format (Y M D)");
            BirthDay = DateTime.Parse(ReadLine());
            WriteLine(BirthDay);
        }
        public static void CalcAge()
        {
            TimeSpan ts = DateTime.Now - BirthDay;
            WriteLine("Age by Milisecond "+ts.TotalMilliseconds);
            WriteLine("Age by Days " + ts.TotalDays);
        }
    }
}