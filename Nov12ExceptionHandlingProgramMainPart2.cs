using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.HelpLink);
                Console.WriteLine(e.Source + "\t" + e.StackTrace + "\t" + e.TargetSite);

            }
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void TestException()
        {
            Random rd = new Random();

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (i % 2 == 0)
                    {
                        TestClass.TestMethod(0, DateTime.Now, rd.NextDouble());
                    }
                    else TestClass.TestMethod(rd.Next(1000), DateTime.Now, 3.14);
                }
                catch (PiException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }
    }
}