using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFunctions
{
    public class Class1
    {
        public static Random rd = new Random();
        public static void FillArray(int[] a)
        {
            for(int i = 0; i < a.Length;i++)
            {
                a[i] = rd.Next(-99, 100);
            }
        }
        public static void ShowArray(int[]a)
        {
            Console.WriteLine();
            foreach(int x in a)
            {
                Console.Write(x + "\t");

            }
            Console.WriteLine();
        }
    }
}
//Build and then Rebuild in the end