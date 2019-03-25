using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarAndEmployee
{
    public static class Timer
    {
        private static DateTime BirthDay { set; get; } // static "DateTime" property

        static Timer() // static constructor
        {
            Write("Enter BirthDay By Fromat Year Month Day  ");
            BirthDay = DateTime.Parse(ReadLine());
            WriteLine(BirthDay);
        }

        public static void CalcAge() // static function that calculates age
        {
            TimeSpan ts = DateTime.Now - BirthDay;
            WriteLine("Age By Milisecond = " + ts.TotalMilliseconds);
        }
        
       
    }
}