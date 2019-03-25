using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static Predicate<int> pd = (int a) => a % 2 == 0;
        static void Main(string[] args)
        {
            int[] a = { -1, -2, -3, -4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            List<int> list = new List<int> { -1, -2, -3, -4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            foreach(int x in a)
            {
                Console.Write(x + "\t");
            }
            Console.WriteLine("\n");

            var result = a.OrderBy(x => x).Where(x => x % 2 != 0).Select(x => x * x).Sum(x=>x);
            Console.WriteLine("Result = " + result + "\n");
            
            //foreach (int x in result)
            //{
            //    Console.Write(x + "\t");
            //}
            //Console.WriteLine("\n");

            //list.RemoveAll(F);
            //list.RemoveAll(pd);
            //list.RemoveAll(x => x % 5 == 0 && x % 3 == 0);
            //list.RemoveAll(x => x < 0);

            //foreach (int x in list)
            //{
            //    Console.Write(x + "\t");
            //}
            //Console.WriteLine("\n");

        }

        static bool F(int a)
        {
            return a % 2 != 0;
        }
    }
}