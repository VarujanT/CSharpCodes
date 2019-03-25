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
            Random rd = new Random();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        TestClass.TestMethod(0, DateTime.Now, rd.NextDouble());
                    }
                    else TestClass.TestMethod(rd.Next(1000), DateTime.Now, 3.14);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}